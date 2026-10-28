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
    public partial class FormSabanaInternos : Form
    {
        //VARIABLES GLOBALES
        private ErrorProvider errorProvider = new ErrorProvider();
        DInternoSabanaResponse internoSabanaGlobal = new DInternoSabanaResponse();

        int idInternoGlobal = 0;
        DateTime fechaInicioGlobal;
        DateTime fechaFinGlobal;

        
        public FormSabanaInternos(int idInternoX, DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            this.idInternoGlobal = idInternoX;
            this.fechaInicioGlobal = fechaInicio;
            this.fechaFinGlobal = fechaFin;

        }

        private async void FormSabanaInternos_Load(object sender, EventArgs e)
        {
            //// Ajustar el tamaño del formulario            
            FormularioAyudas.AjustarFormulario(this);

            //BUSCAR INTERNO CON EL ID PASADO DESDE EL FORMULARIO DE BUSQUEDA (FormInternos)
            NEntradaSalida nEntradaSalida = new NEntradaSalida();

            (DInternoSabanaResponse dInternoSabanaResponse, string errorInternoResponse) = await nEntradaSalida.BuscarInternoSabanaXInterno(this.idInternoGlobal, fechaInicioGlobal.ToString("yyyy-MM-dd"), fechaFinGlobal.ToString("yyyy-MM-dd"));

            if (dInternoSabanaResponse != null)
            {
                this.internoSabanaGlobal = dInternoSabanaResponse;
            }
            else
            {
                MessageBox.Show("no se encontró el interno: " + errorInternoResponse, "Restriccion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //CARGAR DATOS DEL INTERNO
            txtProntuario.Text = this.internoSabanaGlobal.prontuario.ToString();
            txtInterno.Text = this.internoSabanaGlobal.nombre_interno;
            txtEstadoProcesalVer.Text = this.internoSabanaGlobal.estado_procesal;
            txtJurisdiccionVer.Text = this.internoSabanaGlobal.jurisdiccion;
            txtOrganismoAlojamientoVer.Text = this.internoSabanaGlobal.organismo;
            txtFechaAlojamiento.Text = this.internoSabanaGlobal.fecha_alojamiento.ToShortDateString();
            pictureFoto.Load(this.internoSabanaGlobal.foto);
            //txtCausa.Text = this.internoSabanaGlobal.caaa

            //CARGAR VINCULOS
            var datosfiltrados = this.internoSabanaGlobal.listaVinculosResponse
                .Select(c => new
                {
                    IdVisita = c.ciudadano_id,
                    Visita = c.ciudadano.apellido + " " + c.ciudadano.nombre,
                    DNI = c.ciudadano.dni,
                    Parentesco = c.parentesco.parentesco,
                    Vigente = c.vigente,
                    Anulado = c.anulado,
                    Prohibido = c.prohibido,
                    FechaProhib = c.fecha_prohibido,
                    FechaInicio = c.fecha_inicio,
                    FechaFin = c.fecha_fin,
                    DetalleProhib = c.detalles_prohibicion,
                    FechaAlta = c.fecha_alta,
                    //Usuario = c.usuario.apellido + " " + c.usuario.nombre

                })
                .ToList();

            dtgvParentescos.DataSource = datosfiltrados;

            if (this.internoSabanaGlobal.listaVinculosResponse.Count == 0)
            {
                MessageBox.Show("No se encontraron registros de vinculos.", "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {

                dtgvParentescos.Columns[1].Width = 200;
            }

            //CARGAR SABANA DE INGRESO DE VISITAS
            dtpFechaInicio.Value = fechaInicioGlobal;
            dtpFechaFin.Value = fechaFinGlobal;

            var datosfiltradosSabana = this.internoSabanaGlobal.listaEntradasResponse
                .Select(c => new
                {
                    Fecha = c.fecha_registro,
                    Visita = c.nombre_visita,
                    Parentesco = c.parentesco,
                    Entrada = c.hora_registro,
                    Salida = c.hora_egreso,
                    Menores = c.menores,
                    Organismo = c.organismo
                })
                .ToList();

            dtgIngresos.DataSource = datosfiltradosSabana;

            if (this.internoSabanaGlobal.listaEntradasResponse.Count == 0)
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
                    int id_visita;
                    id_visita = Convert.ToInt32(dtgvParentescos.CurrentRow.Cells["IdVisita"].Value.ToString());



                    if (id_visita > 0)
                    {
                        txtIdVisita.Text = id_visita.ToString();
                        txtVisita.Text = dtgvParentescos.CurrentRow.Cells["Visita"].Value.ToString();
                        txtParentesco.Text = dtgvParentescos.CurrentRow.Cells["Parentesco"].Value.ToString();
                        txtDetalleProhibicionParentesco.Text = dtgvParentescos.CurrentRow.Cells["DetalleProhib"].Value?.ToString();

                        this.CargarDataGridProhibiciones(id_visita);
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
            MemoryStream msOriginal = ReportesSabanaVisitasInternos.RepPdfVinculosDelInterno(internoSabanaGlobal);

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
            MemoryStream msOriginal = ReportesSabanaVisitasInternos.RepPdfInternoSabana(internoSabanaGlobal);

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
            (List<DEntradaSalidaSabanaInterno> listaSabana, string errorResponse) = await nEntradaSalida.ListaSabanaXInterno(idInternoGlobal, dtpFechaInicio.Value.ToString("yyyy-MM-dd"), dtpFechaFin.Value.ToString("yyyy-MM-dd"));

            if (listaSabana == null)
            {
                MessageBox.Show(errorResponse, "Restriccion Visitas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.internoSabanaGlobal.listaEntradasResponse = listaSabana;

            var datosfiltrados = listaSabana
                .Select(c => new
                {
                    Fecha = c.fecha_registro,
                    Visita = c.nombre_visita,
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


        //METODO PARA OBTENER LA LISTA DE PROHIBICIONES Y CARGARLO EN UN DATA GRID DE PROHIBICIONES
        async private void CargarDataGridProhibiciones(int idCiudadano)
        {
            NProhibicionVisita nProhibicionVisita = new NProhibicionVisita();
            (List<DProhibicionVisita> listaProhibicionesVisita, string errorResponse) = await nProhibicionVisita.RetornarListaProhibicionesVisita(idCiudadano);

            if (listaProhibicionesVisita == null)
            {
                MessageBox.Show(errorResponse, "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var datosfiltrados = listaProhibicionesVisita
                .Select(c => new
                {
                    Id = c.id_prohibicion_visita,
                    Disposicion = c.disposicion,
                    Detalle = c.detalle,
                    FechaInicio = c.fecha_inicio,
                    FechaFin = c.fecha_fin,
                    FechaProhibicion = c.fecha_prohibicion,
                    Organismo = c.organismo.organismo,
                    Prohibida = c.vigente,
                    TipoLevantamiento = c.tipo_levantamiento,
                    Anulado = c.anulado

                })
                .ToList();

            dtgvProhibiciones.DataSource = datosfiltrados;

            if (listaProhibicionesVisita.Count == 0)
            {
                MessageBox.Show("No se encontraron registros de prohibicion", "Restrición Visitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dtgvProhibiciones.Columns[0].Width = 50;
                dtgvProhibiciones.Columns[2].Width = 300;
                dtgvProhibiciones.Columns[3].Width = 80;
                dtgvProhibiciones.Columns[4].Width = 80;
                dtgvProhibiciones.Columns[5].Width = 80;
                dtgvProhibiciones.Columns[6].Width = 150;
            }

            foreach (DataGridViewRow row in dtgvProhibiciones.Rows)
            {
                if (row.Cells["Prohibida"].Value != null && Convert.ToBoolean(row.Cells["Prohibida"].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange; // Cambiar color de fondo
                    row.DefaultCellStyle.ForeColor = Color.Black;    // Cambiar color del texto
                }

                if (row.Cells["Anulado"].Value != null && Convert.ToBoolean(row.Cells["Anulado"].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Black; // Cambiar color de fondo
                    row.DefaultCellStyle.ForeColor = Color.White;    // Cambiar color del texto
                }
            }


        }
                
        //FIN METODO PARA OBTENER LA LISTA DE PROHIBICIONES Y CARGARLO EN UN DATA GRID DE PROHIBICIONES
        //--------------------------------------------------------------------------------------------...........



    }
}
