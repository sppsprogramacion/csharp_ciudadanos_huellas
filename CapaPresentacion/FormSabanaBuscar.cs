using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FuncionesGenerales;
using CommonCache;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormSabanaBuscar : Form
    {
        public FormSabanaBuscar()
        {
            InitializeComponent();
        }

        private void FormInternosBuscar_Load(object sender, EventArgs e)
        {
            //// Ajustar el tamaño del formulario            
            FormularioAyudas.AjustarFormulario(this);


            List<DElegirBusquedaInterno> listaElegir = new List<DElegirBusquedaInterno>();

            listaElegir.Add(new DElegirBusquedaInterno
            {
                id_busqueda = "unidad",
                texto = "Apellido en: Mi unidad"
            });

            listaElegir.Add(new DElegirBusquedaInterno
            {
                id_busqueda = "todas",
                texto = "Apellido en: Todas las unidades"
            });

            
            cmbBusqueda.ValueMember = "id_busqueda";    // id
            cmbBusqueda.DisplayMember = "texto";  // texto
            cmbBusqueda.DataSource = listaElegir;

            // Seleccionar algo por defecto
            cmbBusqueda.SelectedIndex = 0;

            //inicializar controles
            radVisita.Checked = true;
            cmbBusqueda.Enabled = false;
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length < 2)
            {
                MessageBox.Show("Debe ingresar al menos 2 caracteres en el cuadro de busqueda", "Internos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radInterno.Checked)
            {
                this.CargarInternos();
            }

            if (radVisita.Checked)
            {
                this.CargarVisitas();
            }
        }

        private void radVisita_CheckedChanged(object sender, EventArgs e)
        {
            if (radVisita.Checked == true)
            {
                cmbBusqueda.Enabled = false;
                txtBusqueda.Text = string.Empty;
                dtgResultado.DataSource = null;
                gboxResultado.Text = "RESULTADO";
            }
        }

        private void radInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (radInterno.Checked == true)
            {
                cmbBusqueda.Enabled = true;
                txtBusqueda.Text = string.Empty;
                dtgResultado.DataSource = null;
                gboxResultado.Text = "RESULTADO";
            }
        }

        private void dtgResultado_KeyDown(object sender, KeyEventArgs e)
        {
            //AL PRESIONAR ENTER MOSTRAR EL TRAMITE
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int idEnResultado = 0;

                idEnResultado = Convert.ToInt32(dtgResultado.CurrentRow.Cells["ID"].Value.ToString());

                if (dtgResultado.SelectedRows.Count > 0)
                {
                    if (idEnResultado > 0)
                    {
                        DateTime fechaInicio = dtpFechaInicio.Value;
                        DateTime fechaFin = dtpFechaFin.Value;

                        if (radInterno.Checked) {
                        
                            FormSabanaInternos formSabanaInternos = new FormSabanaInternos(idEnResultado, fechaInicio, fechaFin);
                            formSabanaInternos.ShowDialog();
                        }
                        if (radVisita.Checked)
                        {

                            FormSabanaCiudadano formSabanaCiudadano = new FormSabanaCiudadano(idEnResultado, fechaInicio, fechaFin);
                            formSabanaCiudadano.ShowDialog();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Debe seleccionar un registro.");
                    }
                }
            }
        }



        //CARGAR INTERNOOS
        private async void CargarInternos()
        {
            NInterno nInterno = new NInterno();
            List<DInterno> listaInternos = new List<DInterno>();

            if (cmbBusqueda.SelectedValue.ToString() == "unidad")
            {
                this.Enabled = false;
                (List<DInterno> listaInternosEncontrados, string errorResponse) = await nInterno.RetornarListaInternoXapellido(txtBusqueda.Text);
                this.Enabled = true;

                if (listaInternosEncontrados == null)
                {
                    MessageBox.Show(errorResponse, "Internos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                listaInternos = listaInternosEncontrados;
            }

            if (cmbBusqueda.SelectedValue.ToString() == "todas")
            {
                this.Enabled = false;
                (List<DInterno> listaInternosEncontrados, string errorResponse) = await nInterno.ListaInternosXApellidoGeneral(txtBusqueda.Text);
                this.Enabled = true;

                if (listaInternosEncontrados == null)
                {
                    MessageBox.Show(errorResponse, "Internos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                listaInternos = listaInternosEncontrados;
            }


            var datosFiltrados = listaInternos
                .Select(c => new
                {
                    ID = c.id_interno,
                    Apellido = c.apellido,
                    Nombre = c.nombre,
                    Prontuario = c.prontuario,
                    Sexo = c.sexo.sexo

                })
                .ToList();

            dtgResultado.DataSource = datosFiltrados;
            gboxResultado.Text = "INTERNOS";

            if (listaInternos.Count == 0)
            {
                MessageBox.Show("No se encontraron registros", "Restriccion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dtgResultado.Columns[0].Width = 90;
                dtgResultado.Columns[1].Width = 200;
                dtgResultado.Columns[2].Width = 200;
                dtgResultado.Columns[3].Width = 90;
                dtgResultado.Columns[4].Width = 90;

                dtgResultado.Focus();
            }
        }
        //FIN CARGAR INTERNOS
        //---------------------------------------------------------------------------

        //CARGAR VISITAS
        private async void CargarVisitas()
        {
            NCiudadano nCiudadano = new NCiudadano();
            (List<DCiudadano> listaCiudadanos, string errorResponse) = await nCiudadano.RetornarListaCiudadanosXapellido(txtBusqueda.Text);

            if (listaCiudadanos == null)
            {
                MessageBox.Show(errorResponse, "Restricion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var datosFiltrados = listaCiudadanos
                .Select(c => new
                {
                    ID = c.id_ciudadano,
                    Apellido = c.apellido,
                    Nombre = c.nombre,
                    DNI = c.dni,
                    Sexo = c.sexo.sexo

                })
                .ToList();

            dtgResultado.DataSource = datosFiltrados;
            gboxResultado.Text = "VISITAS";

            if (listaCiudadanos.Count == 0)
            {
                MessageBox.Show("No se encontraron registros", "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dtgResultado.Columns[0].Width = 90;
                dtgResultado.Columns[1].Width = 200;
                dtgResultado.Columns[2].Width = 200;
                dtgResultado.Columns[3].Width = 90;
                dtgResultado.Columns[4].Width = 90;
            }
        }

        
        
        //FIN CARGAR VISITAS
        //-----------------------------------------------------------------------------
    }
}
