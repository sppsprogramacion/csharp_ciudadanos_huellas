using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP.Processing;

namespace CapaPresentacion.Biometria
{
    public class FingerprintProcessor
    {
        private FeatureExtraction extractor;

        public FingerprintProcessor()
        {
            extractor = new FeatureExtraction();
        }
    }
}
