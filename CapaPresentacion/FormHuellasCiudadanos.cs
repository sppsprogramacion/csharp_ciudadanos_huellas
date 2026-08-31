using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Biometria;
using CapaPresentacion.FuncionesGenerales;
using CapaPresentacion.Validaciones.NuevoCiudadano.Datos;
using CapaPresentacion.Validaciones.NuevoCiudadano.ValidacionNuevoCiudadano;
using Newtonsoft.Json;
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
    public partial class FormHuellasCiudadanos : Form
    {
        //VARIABLES GLOBALES
        private ErrorProvider errorProvider = new ErrorProvider();

        //para huellas
        private FingerprintCapture fingerprintCapture;
        private FingerprintProcessor fingerprintProcessor;
        private FingerprintTemplate fingerprintTemplate;
        private FingerprintVerifier fingerprintVerifier;
        private DPFP.Template templateRegistrado;
        private byte[] templateBytesRegistrado;
        private bool modoVerificacion = false;
        private bool modoIdentificacion = false;
        private string huellaBase64Global = "";

        //variabloes generales
        private int idCiudadanoGlobal = 0;


        public FormHuellasCiudadanos(int idCiudadano)
        {
            InitializeComponent();
            fingerprintCapture = new FingerprintCapture();
            fingerprintProcessor = new FingerprintProcessor();
            fingerprintTemplate = new FingerprintTemplate();
            fingerprintVerifier = new FingerprintVerifier();

            fingerprintCapture.FingerDetected += FingerprintCapture_FingerDetected;
            fingerprintCapture.FingerRemoved += FingerprintCapture_FingerRemoved;
            fingerprintCapture.CaptureError += FingerprintCapture_CaptureError;
            fingerprintCapture.SampleCaptured += FingerprintCapture_SampleCaptured;


            idCiudadanoGlobal = idCiudadano;
        }

        private async void FormHuellasCiudadanos_Load(object sender, EventArgs e)
        {

            //// Ajustar el tamaño del formulario            
            FormularioAyudas.AjustarFormulario(this);

            if (this.idCiudadanoGlobal == 0)
            {
                lblTitulo.Text = "Verificar huellas";
                return;
            }
            else{
                lblTitulo.Text = "Gestionar huellas del ciudadano";
            }

            NCiudadano nCiudadano = new NCiudadano();
            (DCiudadano dCiudadano, string errorResponse) = await nCiudadano.BuscarCiudadanoXID(idCiudadanoGlobal);

            if (dCiudadano == null)
            {
                MessageBox.Show(errorResponse, "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtIdCiudadano.Text = dCiudadano.id_ciudadano.ToString();
            txtApellidoCivil.Text = dCiudadano.apellido.ToString();
            txtNombreCivil.Text = dCiudadano.nombre.ToString();
            txtDniCivil.Text = dCiudadano.dni.ToString();
            txtSexo.Text = dCiudadano.sexo.sexo.ToString();
            txtFechaNacimiento.Text = dCiudadano.fecha_nac.ToShortDateString();
            txtFechaAlta.Text = dCiudadano.fecha_alta.ToShortDateString();
            picFotoVisita.Load(dCiudadano.foto);

            this.bloquearChecksHuellasCargadas(txtIdCiudadano.Text);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();

            frmNuevo FNuevo = new frmNuevo();
            FNuevo.ShowDialog();
        }

       
        private void btnIdentificarHuellas_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "IDENTIFICAR HUELLAS";

            btnIdentificarHuellas.Enabled = false;
            btnCancelarIdentificar.Enabled = true;
            gboxRegistrar.Enabled = false;
            gboxVerificarHuella.Enabled = false;

            fingerprintCapture.Start();
            this.modoIdentificacion = true;

            lblEstado.Text = "Esperando huella...";
        }

        private void btnCancelarIdentificar_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "_";

            this.modoIdentificacion = false;
            btnIdentificarHuellas.Enabled = true;
            btnCancelarIdentificar.Enabled = false;
            gboxRegistrar.Enabled = true;
            gboxVerificarHuella.Enabled = true;

            fingerprintCapture.Stop();

            lblEstado.Text = "Lector detenido";
            lblDedo.Text = "Esperando...";
        }

        
        private void btnIniciarRegistro_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "REGISTRAR UNA HUELLA";

            btnIniciarRegistro.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelarRegistrar.Enabled = true;
            gboxIdentificar.Enabled = false;
            gboxVerificarHuella.Enabled = false;

            fingerprintCapture.Start();
            modoVerificacion = false;

            fingerprintTemplate = new FingerprintTemplate();

            templateRegistrado = null;

            lblEstado.Text = "Coloque el dedo para registrarlo. Esperando huella...";
            //lblEstado.Text = "Esperando huella...";
        }
               
        private void btnCancelarRegistrar_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "_";

            btnIniciarRegistro.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelarRegistrar.Enabled = false;
            gboxIdentificar.Enabled = true;
            gboxVerificarHuella.Enabled = true;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.huellaBase64Global == "")
            {
                MessageBox.Show("No hay una huella valida para guardar", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtIdCiudadano.Text))
            {
                MessageBox.Show("No hay un ciudadano seleccionado", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NHuella nHuella = new NHuella();
                
            //limpiar errores de provider
            errorProvider.Clear();

            
            //enviar datos si son correctos
            var data = new
            {
                ciudadano_id = Convert.ToInt32(txtIdCiudadano.Text),
                dedo_id = 7,
                huella = this.huellaBase64Global,
                detalle_motivo = "Registro inicial",
                
            };

            string dataHuella = JsonConvert.SerializeObject(data);

            gboxRegistrar.Enabled = false;
            (DHuella dataRespuesta, string errorResponse) = await nHuella.CrearHuella(dataHuella);
            gboxRegistrar.Enabled = true;

            if (dataRespuesta != null)
            {
                MessageBox.Show("La huella se guardo correctamente", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bloquearChecksHuellasCargadas(txtIdCiudadano.Text);
                lblTituloImagenHuellas.Text = "_";

                btnIniciarRegistro.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelarRegistrar.Enabled = false;
                gboxIdentificar.Enabled = true;
                gboxVerificarHuella.Enabled = true;

            }
            else
            {
                MessageBox.Show(errorResponse, "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }

        private void btnVerificar2_Click(object sender, EventArgs e)
        {
            //limpiar errores de provider
            errorProvider.Clear();

            lblTituloImagenHuellas.Text = "VERIFICAR HUELLAS";
            btnVerificar2.Enabled = false;
            btnCancelarVerificar.Enabled = true;
            gboxIdentificar.Enabled = false;
            gboxRegistrar.Enabled = false;

            if (string.IsNullOrEmpty(txtIdCiudadano.Text))
            {
                MessageBox.Show("No hay un ciudadano seleccionado", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fingerprintCapture.Start();
            modoVerificacion = true;

            lblEstado.Text = "Coloque el dedo para verificar.";
        }

        private void btnCancelarVerificar_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "_";

            this.modoVerificacion = false;
            btnVerificar2.Enabled = true;
            btnCancelarVerificar.Enabled = false;
            gboxIdentificar.Enabled= true;
            gboxRegistrar.Enabled = true;

            fingerprintCapture.Stop();

            lblEstado.Text = "Lector detenido";
            lblDedo.Text = "Esperando...";
        }


        //METODOS PARA HUELLAS
        private void FingerprintCapture_FingerDetected(
            object sender,
            EventArgs e)
        {
            EjecutarEnUI(() =>
            {
                lblDedo.Text = "Dedo detectado";
            });
        }

        private void FingerprintCapture_FingerRemoved(
            object sender,
            EventArgs e)
        {
            EjecutarEnUI(() =>
            {
                lblDedo.Text = "Dedo retirado";
            });
        }

        private void FingerprintCapture_CaptureError(object sender, string e)
        {
            MessageBox.Show(
                e,
                "Error del lector",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        
        //PROCESO DE CAPTURA PARA REGISTRO Y/O VERIFICACION
        private async void FingerprintCapture_SampleCaptured(object sender, FingerprintCapture.SampleEventArgs e)
        {
            try
            {
                DPFP.FeatureSet featureSet;

                bool resultado;

                if (modoVerificacion || modoIdentificacion)
                {
                    resultado =
                        fingerprintProcessor.ExtractFeaturesForVerification(
                            e.Sample,
                            out featureSet
                        );
                }
                else
                {
                    resultado =
                        fingerprintProcessor.ExtractFeaturesForEnrollment(
                            e.Sample,
                            out featureSet
                        );
                }

                if (!resultado)
                {
                    EjecutarEnUI(() =>
                    {
                        lblEstado.Text =
                            "La calidad de la huella no es suficiente.";
                    });

                    return;
                }


                // -----------------------------------------
                // MODO VERIFICACIÓN
                // -----------------------------------------

                if (modoVerificacion)
                {
                    NHuella nHuellas = new NHuella();
                    MessageBox.Show("verificando", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    (List<DHuella> listaHuellas, string errorResponse) = await nHuellas.RetornarListaXCiudadano(Convert.ToInt32(txtIdCiudadano.Text));
                    if (listaHuellas == null)
                    {
                        MessageBox.Show(errorResponse, "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (listaHuellas.Count == 0)
                    {
                        MessageBox.Show("El ciudadano no posee huellas registradas.","Atención al Ciudadano",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    foreach (DHuella huella in listaHuellas)
                    {
                        try
                        {
                            byte[] templateBytes = Convert.FromBase64String(huella.huella);

                            DPFP.Template template = fingerprintTemplate.LoadTemplate(templateBytes);

                            if (fingerprintVerifier.Verify(featureSet, template))
                            {
                                MessageBox.Show( $"COINCIDE - dedo_id: {huella.dedo_id}");

                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            // registrar error si quieres
                            continue;
                        }
                    }

                    MessageBox.Show("NO COINCIDE");

                    return;
                    
                }

                // -----------------------------------------
                // MODO IDENTIFICACION
                // -----------------------------------------

                if (modoIdentificacion)
                {
                    NHuella nHuellas = new NHuella();
                    MessageBox.Show("Identificando", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    (List<DHuella> listaHuellas, string errorResponse) = await nHuellas.RetornarListaTodas();
                    if (listaHuellas == null)
                    {
                        MessageBox.Show(errorResponse, "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (listaHuellas.Count == 0)
                    {
                        MessageBox.Show("No hay huellas registradas.", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    foreach (DHuella huella in listaHuellas)
                    {
                        try
                        {
                            byte[] templateBytes = Convert.FromBase64String(huella.huella);

                            DPFP.Template template = fingerprintTemplate.LoadTemplate(templateBytes);

                            if (fingerprintVerifier.Verify(featureSet, template))
                            {
                                MessageBox.Show($"COINCIDE - dedo_id: {huella.dedo_id}");

                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            // registrar error si quieres
                            continue;
                        }
                    }

                    MessageBox.Show("NO COINCIDE");
                                        
                    return;

                }


                // -----------------------------------------
                // MODO REGISTRO
                // -----------------------------------------

                bool agregada =
                    fingerprintTemplate.AddFeatures(featureSet);

                uint faltantes =
                    fingerprintTemplate.FeaturesNeeded;


                EjecutarEnUI(() =>
                {
                    if (fingerprintTemplate.IsComplete)
                    {
                        // Obtiene el Template original.
                        templateRegistrado = fingerprintTemplate.GetTemplate();

                        // Lo convierte a bytes.
                        templateBytesRegistrado = fingerprintTemplate.GetTemplateBytes();
                        string huellaBase64 = Convert.ToBase64String(templateBytesRegistrado);
                        this.huellaBase64Global = huellaBase64;

                        // Reconstruye el Template desde los bytes.
                        DPFP.Template templateReconstruido = fingerprintTemplate.LoadTemplate(templateBytesRegistrado);

                        // Para esta prueba utilizaremos
                        // únicamente el Template reconstruido.
                        templateRegistrado = templateReconstruido;

                        EjecutarEnUI(() =>
                        {
                            if (templateRegistrado != null)
                            {
                                lblEstado.Text =
                                    "Template generado y reconstruido correctamente. " +
                                    "Tamaño: " +
                                    templateBytesRegistrado.Length +
                                    " bytes";
                            }
                            else
                            {
                                lblEstado.Text =
                                    "Error al reconstruir el Template.";
                            }
                        });
                    }
                    else if (agregada)
                    {
                        lblEstado.Text =
                            "Captura correcta. Faltan " +
                            faltantes +
                            " muestras.";
                    }
                    else
                    {
                        lblEstado.Text =
                            "La muestra no fue aceptada. " +
                            "Coloque nuevamente el dedo.";
                    }
                });
            }
            catch (Exception ex)
            {
                EjecutarEnUI(() =>
                {
                    lblEstado.Text = "Error: " + ex.Message;
                });
            }
        }


        protected override void OnFormClosing(
            FormClosingEventArgs e)
        {
            fingerprintCapture?.Dispose();

            base.OnFormClosing(e);
        }

        private void EjecutarEnUI(Action accion)
        {
            if (InvokeRequired)
            {
                Invoke(accion);
                return;
            }

            accion();
        }

        //PRocedimiento para bloquear dedos segun huella cargada
        private async void bloquearChecksHuellasCargadas(string idCiudadano)
        {
            if (string.IsNullOrEmpty(txtIdCiudadano.Text))
            {
                MessageBox.Show("No hay un ciudadano seleccionado", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NHuella nHuellas = new NHuella();

            (List<DHuella> listaHuellas, string errorResponse) = await nHuellas.RetornarListaXCiudadano(Convert.ToInt32(txtIdCiudadano.Text));
            if (listaHuellas == null)
            {
                MessageBox.Show(errorResponse, "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listaHuellas.Count == 0)
            {
                MessageBox.Show("El ciudadano no posee huellas registradas.", "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            foreach (DHuella huella in listaHuellas)
            {
                int dedo = Convert.ToInt32(huella.dedo_id);
                //MessageBox.Show (dedo);
                switch (dedo)
                {
                    case 1:
                        opPD.Enabled = false;
                        opPD.FlatStyle = FlatStyle.Flat;
                        opPD.BackColor = Color.Green;
                        break;                        

                    case 2:
                        opID.Enabled = false;
                        opID.FlatStyle = FlatStyle.Flat;
                        opID.BackColor = Color.Green;
                        break;
                        
                    case 3:
                        opMAD.Enabled = false;
                        opMAD.FlatStyle = FlatStyle.Flat;
                        opMAD.BackColor = Color.Green;
                        break;
                        
                    case 4:
                        opAD.Enabled = false;
                        opAD.FlatStyle = FlatStyle.Flat;
                        opAD.BackColor = Color.Green;
                        break;
                                                
                    case 5:
                        opMED.Enabled = false;
                        opMED.FlatStyle = FlatStyle.Flat;
                        opMED.BackColor = Color.Green;
                        break;
                        
                    case 6:
                        opPI.Enabled = false;
                        opPI.FlatStyle = FlatStyle.Flat;
                        opPI.BackColor = Color.Green;
                        break;

                    case 7:
                        opII.Enabled = false;
                        opII.FlatStyle = FlatStyle.Flat;
                        opII.BackColor = Color.Green;
                        break;

                    case 8:
                        opMAI.Enabled = false;
                        opMAI.FlatStyle = FlatStyle.Flat;
                        opMAI.BackColor = Color.Green;
                        break;
                        
                    case 10:
                        opAI.Enabled = false;
                        opAI.FlatStyle = FlatStyle.Flat;
                        opAI.BackColor = Color.Green;
                        break;
                        
                    case 12:
                        opMEI.Enabled = false;
                        opMEI.FlatStyle = FlatStyle.Flat;
                        opMEI.BackColor = Color.Green;
                        break;

                    default:
                        break;


                }//fin switch
            }//fin foreach
        }
        //FIN PRocedimiento para bloquear dedos segun huella cargada
    }
}
