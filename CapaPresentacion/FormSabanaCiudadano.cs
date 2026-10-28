using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FuncionesGenerales;
using CapaPresentacion.Reportes.SabanasVisitasInternos;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormSabanaCiudadano : Form
    {
        //VARIABLES GLOBALES
        private ErrorProvider errorProvider = new ErrorProvider();        
        DCiudadanoSabanaResponse ciudadanoSabanaGlobal = new DCiudadanoSabanaResponse();

        int idCiudadanoGlobal = 0;
        DateTime fechaInicioGlobal;
        DateTime fechaFinGlobal;


        public FormSabanaCiudadano(int idCiudadanoX, DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            this.idCiudadanoGlobal = idCiudadanoX;
            this.fechaInicioGlobal = fechaInicio;
            this.fechaFinGlobal = fechaFin;

        }

        private async void FormSabanaCiudadano_Load(object sender, EventArgs e)
        {
            //// Ajustar el tamaño del formulario            
            FormularioAyudas.AjustarFormulario(this);

            //BUSCAR INTERNO CON EL ID PASADO DESDE EL FORMULARIO DE BUSQUEDA (FormInternos)
            NEntradaSalida nEntradaSalida = new NEntradaSalida();
            (DCiudadanoSabanaResponse dCiudadanoSabanaResponse, string errorInternoResponse) = await nEntradaSalida.BuscarCiudadanoSabanaXInterno(this.idCiudadanoGlobal, fechaInicioGlobal.ToString("yyyy-MM-dd"), fechaFinGlobal.ToString("yyyy-MM-dd"));

            if (dCiudadanoSabanaResponse != null)
            {
                this.ciudadanoSabanaGlobal = dCiudadanoSabanaResponse;
            }
            else
            {
                MessageBox.Show("no se encontró el ciudadano: " + errorInternoResponse, "Restriccion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //CARGAR DATOS DEL INTERNO
            txtDni.Text = this.ciudadanoSabanaGlobal.dni.ToString();
            txtVisita.Text = this.ciudadanoSabanaGlobal.nombre_visita;
            txtSexo.Text = this.ciudadanoSabanaGlobal.sexo;
            txtEdad.Text = this.ciudadanoSabanaGlobal.edad.ToString();
            txtDomicilio.Text = this.ciudadanoSabanaGlobal.domicilio;
            pictureFoto.Load(this.ciudadanoSabanaGlobal.foto);

            //CARGAR VINCULOS
            var datosfiltrados = this.ciudadanoSabanaGlobal.listaVinculosResponse
                .Select(c => new
                {
                    IdInterno = c.interno_id,
                    Interno = c.interno.apellido + " " + c.interno.nombre,
                    Prontuario = c.interno.prontuario,
                    Unidad = c.interno.organismo.organismo,
                    Parentesco = c.parentesco.parentesco,
                    Vigente = c.vigente,
                    Anulado = c.anulado,
                    Prohibido = c.prohibido,
                    FechaProhib = c.fecha_prohibido,
                    FechaInicio = c.fecha_inicio,
                    FechaFin = c.fecha_fin,
                    DetalleProhib = c.detalles_prohibicion,
                    FechaAlta = c.fecha_alta,                    

                })
                .ToList();

            dtgvParentescos.DataSource = datosfiltrados;

            if (this.ciudadanoSabanaGlobal.listaVinculosResponse.Count == 0)
            {
                MessageBox.Show("No se encontraron registros de vinculos.", "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                dtgvParentescos.Columns[0].Width = 50;
                dtgvParentescos.Columns[1].Width = 200;
                dtgvParentescos.Columns[3].Width = 150;
                dtgvParentescos.Columns[5].Width = 70;
                dtgvParentescos.Columns[6].Width = 70;
                dtgvParentescos.Columns[7].Width = 70;
            }

            //CARGAR SABANA DE INGRESO DE VISITAS
            dtpFechaInicio.Value = fechaInicioGlobal;
            dtpFechaFin.Value = fechaFinGlobal;

            var datosfiltradosSabana = this.ciudadanoSabanaGlobal.listaEntradasResponse
                .Select(c => new
                {
                    Fecha = c.fecha_registro,
                    Interno = c.nombre_interno,
                    Parentesco = c.parentesco,
                    Entrada = c.hora_registro,
                    Salida = c.hora_egreso,
                    Menores = c.menores,
                    Organismo = c.organismo
                })
                .ToList();

            dtgIngresos.DataSource = datosfiltradosSabana;

            if (this.ciudadanoSabanaGlobal.listaEntradasResponse.Count == 0)
            {
                MessageBox.Show("No se encontraron registros de sabana", "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                dtgIngresos.Columns[0].Width = 80;
                dtgIngresos.Columns[1].Width = 250;
                dtgIngresos.Columns[2].Width = 90;
                dtgIngresos.Columns[3].Width = 70;
                dtgIngresos.Columns[4].Width = 70;
                dtgIngresos.Columns[5].Width = 300;
                dtgIngresos.Columns[6].Width = 150;

            }
        }

        private void dtgvParentescos_KeyDown(object sender, KeyEventArgs e)
        {
            //AL PRESIONAR ENTER MOSTRAR
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (dtgvParentescos.SelectedRows.Count > 0)
                {
                    int id_interno;
                    id_interno = Convert.ToInt32(dtgvParentescos.CurrentRow.Cells["IdInterno"].Value.ToString());

                    

                    if (id_interno > 0)
                    {
                        txtIdInterno.Text = id_interno.ToString();
                        txtInternoVinculado.Text = dtgvParentescos.CurrentRow.Cells["Interno"].Value.ToString();
                        txtParentesco.Text = dtgvParentescos.CurrentRow.Cells["Parentesco"].Value.ToString();
                        txtDetalleProhibicionParentesco.Text = dtgvParentescos.CurrentRow.Cells["DetalleProhib"].Value?.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una vinculo.", "Restricción Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnImprimirVinculos_Click(object sender, EventArgs e)
        {
            

            // Generar PDF en memoria
            MemoryStream msOriginal = ReportesSabanaVisitasInternos.RepPdfVinculosDeLaVisita(ciudadanoSabanaGlobal);

            // Clonar el stream para que PdfiumViewer pueda cerrarlo sin afectar el original
            MemoryStream ms = new MemoryStream(msOriginal.ToArray());

            PdfDocument pdfDocument = null;

            try
            {
                pdfDocument = PdfDocument.Load(ms);

                Form formVisor = new Form
                {
                    Text = "Vista previa PDF",
                    Width = 800,
                    Height = 600,
                    StartPosition = FormStartPosition.CenterScreen,
                };

                PdfViewer pdfViewer = new PdfViewer
                {
                    Dock = DockStyle.Fill,
                    Document = pdfDocument
                };

                formVisor.Controls.Add(pdfViewer);

                formVisor.FormClosed += (s, args) =>
                {
                    // Liberar recursos al cerrar el visor
                    pdfViewer.Document.Dispose();
                    pdfViewer.Dispose();
                    formVisor.Dispose();
                    ms.Dispose();
                    pdfDocument = null;
                };

                formVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar PDF: " + ex.Message);
                ms.Dispose();
                pdfDocument?.Dispose();
            }
        }

        private void btnVerSabana_Click(object sender, EventArgs e)
        {
            this.CargarDataGridSabana();
        }

        private void btnImprimirSabana_Click(object sender, EventArgs e)
        {
            // Generar PDF en memoria
            MemoryStream msOriginal = ReportesSabanaVisitasInternos.RepPdfCiudadanoSabana(ciudadanoSabanaGlobal);

            // Clonar el stream para que PdfiumViewer pueda cerrarlo sin afectar el original
            MemoryStream ms = new MemoryStream(msOriginal.ToArray());

            PdfDocument pdfDocument = null;

            try
            {
                pdfDocument = PdfDocument.Load(ms);

                Form formVisor = new Form
                {
                    Text = "Vista previa PDF",
                    Width = 800,
                    Height = 600,
                    StartPosition = FormStartPosition.CenterScreen,
                };

                PdfViewer pdfViewer = new PdfViewer
                {
                    Dock = DockStyle.Fill,
                    Document = pdfDocument
                };

                formVisor.Controls.Add(pdfViewer);

                formVisor.FormClosed += (s, args) =>
                {
                    // Liberar recursos al cerrar el visor
                    pdfViewer.Document.Dispose();
                    pdfViewer.Dispose();
                    formVisor.Dispose();
                    ms.Dispose();
                    pdfDocument = null;
                };

                formVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar PDF: " + ex.Message);
                ms.Dispose();
                pdfDocument?.Dispose();
            }
        }


        //METODO PARA OBTENER LA LISTA DE SABANA DEL CIUDADANO
        async private void CargarDataGridSabana()
        {
            NEntradaSalida nEntradaSalida = new NEntradaSalida();
            (List<DEntradaSalidaSabanaCiudadano> listaSabana, string errorResponse) = await nEntradaSalida.ListaSabanaXCiudadano(idCiudadanoGlobal, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));

            if (listaSabana == null)
            {
                MessageBox.Show(errorResponse, "Restriccion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.ciudadanoSabanaGlobal.listaEntradasResponse = listaSabana;
            
            var datosfiltrados = listaSabana
                .Select(c => new
                {
                    Fecha = c.fecha_registro,
                    Interno = c.nombre_interno,
                    Parentesco = c.parentesco,
                    Entrada = c.hora_registro,
                    Salida = c.hora_egreso,
                    Menores = c.menores,
                    Organismo = c.organismo
                })
                .ToList();

            dtgIngresos.DataSource = datosfiltrados;

            if (listaSabana.Count == 0)
            {
                MessageBox.Show("No se encontraron registros", "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dtgIngresos.Columns[0].Width = 80;
                dtgIngresos.Columns[1].Width = 250;
                dtgIngresos.Columns[2].Width = 90;
                dtgIngresos.Columns[3].Width = 70;
                dtgIngresos.Columns[4].Width = 70;
                dtgIngresos.Columns[5].Width = 300;
                dtgIngresos.Columns[6].Width = 150;

            }
        }        
        //FIN METODO PARA OBTENER LA LISTA DE SABANA DEL CIUDADANO
        //----------------------------------------------------------------------------------
    }
}
