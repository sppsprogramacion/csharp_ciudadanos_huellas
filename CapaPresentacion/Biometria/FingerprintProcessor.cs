using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP.Capture;
using DPFP;
using DPFP.Processing;

namespace CapaPresentacion.Biometria
{
    public class FingerprintProcessor
    {
        // Procesa las muestras obtenidas del lector.
        private FeatureExtraction extractor;


        // Inicializa el procesador.
        public FingerprintProcessor()
        {
            extractor = new FeatureExtraction();
        }


        // Extrae las características biométricas de una muestra.
        public bool ExtractFeatures( Sample sample,out FeatureSet featureSet)
        {
            featureSet = new FeatureSet();

            // Indica que las características se utilizarán
            // para registrar una nueva huella.
            DataPurpose purpose = DataPurpose.Enrollment;

            // Recibe el resultado de calidad de la muestra.
            CaptureFeedback feedback = CaptureFeedback.None;

            // Extrae las características de la huella.
            extractor.CreateFeatureSet(sample,purpose,ref feedback, ref featureSet);

            // Solo consideramos válida una captura de buena calidad.
            return feedback == CaptureFeedback.Good;
        }
    }
}
