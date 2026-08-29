using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Biometria;
using CapaPresentacion.FuncionesGenerales;
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
        //para huellas
        private FingerprintCapture fingerprintCapture;
        private FingerprintProcessor fingerprintProcessor;
        private FingerprintTemplate fingerprintTemplate;
        private FingerprintVerifier fingerprintVerifier;
        private DPFP.Template templateRegistrado;
        private bool modoVerificacion = false;

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

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();

            frmNuevo FNuevo = new frmNuevo();
            FNuevo.ShowDialog();
        }

        private void btnVerificarHuellas_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "Verificar huellas";

            //btnVerificarHuellas.Enabled = false;
            //btnCancelarVerificar.Enabled = true;
            //gboxRegistrar.Enabled = false;

            fingerprintCapture.Start();

            lblEstado.Text = "Esperando huella...";
        }

        private void btnCancelarVerificar_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "_";

            //btnVerificarHuellas.Enabled = true;
            //btnCancelarVerificar.Enabled = false;
            //gboxRegistrar.Enabled = true;

            fingerprintCapture.Stop();

            lblEstado.Text = "Lector detenido";
            lblDedo.Text = "Esperando...";
        }

        private void btnIniciarRegistro_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "Registrar una huella";

            //btnIniciarRegistro.Enabled = false;
            //btnGuardar.Enabled = true;
            //btnCancelarRegistrar.Enabled = true;
            //gboxVerificar.Enabled = false;
        }

        

        private void btnCancelarRegistrar_Click(object sender, EventArgs e)
        {
            lblTituloImagenHuellas.Text = "_";

            //btnIniciarRegistro.Enabled = true;
            //btnGuardar.Enabled = false;
            //btnCancelarRegistrar.Enabled = false;
            //gboxVerificar.Enabled = true;
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

        //private void FingerprintCapture_SampleCaptured(object sender, FingerprintCapture.SampleEventArgs e)
        //{
        //    try
        //    {
        //        DPFP.FeatureSet featureSet;

        //        bool resultado = fingerprintProcessor.ExtractFeatures( e.Sample, out featureSet);

        //        if (!resultado)
        //        {
        //            EjecutarEnUI(() =>
        //            {
        //                lblEstado.Text =
        //                    "La calidad de la huella no es suficiente.";
        //            });

        //            return;
        //        }


        //        // Agrega la muestra al proceso de Enrollment.
        //        bool agregada = fingerprintTemplate.AddFeatures(featureSet);

        //        uint faltantes =
        //            fingerprintTemplate.FeaturesNeeded;

        //        EjecutarEnUI(() =>
        //        {
        //            if (fingerprintTemplate.IsComplete)
        //            {
        //                // Obtiene el Template convertido a bytes.
        //                //byte[] templateBytes =
        //                //    fingerprintTemplate.GetTemplateBytes();

        //                //lblEstado.Text =
        //                //    "Template generado correctamente. " +
        //                //    "Tamaño: " +
        //                //    templateBytes.Length +
        //                //    " bytes";

        //                // Obtiene el Template como bytes.
        //                byte[] templateBytes =
        //                    fingerprintTemplate.GetTemplateBytes();

        //                // Reconstruye el Template desde los bytes.
        //                DPFP.Template templateReconstruido =
        //                    fingerprintTemplate.LoadTemplate(templateBytes);

        //                if (templateReconstruido != null)
        //                {
        //                    lblEstado.Text =
        //                        "Template generado y reconstruido correctamente. " +
        //                        "Tamaño: " +
        //                        templateBytes.Length +
        //                        " bytes";
        //                }
        //                else
        //                {
        //                    lblEstado.Text =
        //                        "No se pudo reconstruir el Template.";
        //                }
        //            }
        //            else if (agregada)
        //            {
        //                lblEstado.Text =
        //                    "Captura correcta. Faltan " +
        //                    faltantes +
        //                    " muestras.";
        //            }
        //            else
        //            {
        //                lblEstado.Text =
        //                    "La muestra no fue aceptada. " +
        //                    "Coloque nuevamente el dedo.";
        //            }
        //        });

        //    }
        //    catch (Exception ex)
        //    {
        //        EjecutarEnUI(() =>
        //        {
        //            lblEstado.Text = "Error: " + ex.Message;
        //        });
        //    }
        //}

        private void FingerprintCapture_SampleCaptured(
    object sender,
    FingerprintCapture.SampleEventArgs e)
        {
            try
            {
                DPFP.FeatureSet featureSet;

                bool resultado =
                    fingerprintProcessor.ExtractFeatures(
                        e.Sample,
                        out featureSet
                    );

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
                    bool coincide =
                        fingerprintVerifier.Verify(
                            featureSet,
                            templateRegistrado
                        );

                    EjecutarEnUI(() =>
                    {
                        if (coincide)
                        {
                            lblEstado.Text =
                                "HUELLA COINCIDE";
                        }
                        else
                        {
                            lblEstado.Text =
                                "HUELLA NO COINCIDE";
                        }
                    });

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
                        templateRegistrado =
                            fingerprintTemplate.GetTemplate();

                        byte[] templateBytes =
                            fingerprintTemplate.GetTemplateBytes();

                        lblEstado.Text =
                            "Template generado correctamente. " +
                            "Tamaño: " +
                            templateBytes.Length +
                            " bytes";
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
                    lblEstado.Text =
                        "Error: " + ex.Message;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modoVerificacion = false;

            fingerprintTemplate =
                new FingerprintTemplate();

            templateRegistrado = null;

            lblEstado.Text =
                "Coloque el dedo para registrarlo.";
        }

        private void btnVerificar2_Click(object sender, EventArgs e)
        {
            if (templateRegistrado == null)
            {
                lblEstado.Text =
                    "Primero debe registrar una huella.";

                return;
            }

            modoVerificacion = true;

            lblEstado.Text =
                "Coloque el dedo para verificar.";
        }
    }
}
