using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
using DPFPCapture = DPFP.Capture;


namespace CapaPresentacion.Biometria
{
    public class FingerprintCapture : IDisposable
    {
        private DPFPCapture.Capture capturer;
        private DPFPCapture.EventHandler captureHandler;

        public event System.EventHandler FingerDetected;
        public event System.EventHandler FingerRemoved;
        public event System.EventHandler<string> CaptureError;
        public event System.EventHandler<SampleEventArgs> SampleCaptured;

        public FingerprintCapture()
        {
            capturer = new DPFPCapture.Capture();
            captureHandler = new CaptureHandler(this);
        }

        public void Start()
        {
            if (capturer == null)
                throw new InvalidOperationException(
                    "El lector no está inicializado.");

            try
            {
                capturer.EventHandler = captureHandler;
                capturer.StartCapture();
            }
            catch (Exception ex)
            {
                CaptureError?.Invoke(this, ex.Message);
            }
        }

        public void Stop()
        {
            if (capturer != null)
            {
                try
                {
                    capturer.StopCapture();
                }
                catch
                {
                    // No hacemos nada si ya estaba detenido.
                }
            }
        }

        private void FingerTouch(object Capture,string ReaderSerialNumber)
        {
            FingerDetected?.Invoke(
                this,
                System.EventArgs.Empty
            );
        }

        private void FingerGone(object Capture,string ReaderSerialNumber)
        {
            FingerRemoved?.Invoke(
                this,
                System.EventArgs.Empty
            );
        }

        public void Dispose()
        {
            Stop();

            if (capturer != null)
            {
                capturer.Dispose();
                capturer = null;
            }
        }

        public class SampleEventArgs : EventArgs
        {
            public DPFP.Sample Sample { get; private set; }

            public SampleEventArgs(DPFP.Sample sample)
            {
                Sample = sample;
            }
        }

        private void SampleComplete(DPFP.Sample sample)
        {
            SampleCaptured?.Invoke(
                this,
                new SampleEventArgs(sample)
            );
        }

        private class CaptureHandler : DPFPCapture.EventHandler
        {
            private readonly FingerprintCapture owner;

            public CaptureHandler(FingerprintCapture owner)
            {
                this.owner = owner;
            }

            public void OnComplete(object Capture,string ReaderSerialNumber,DPFP.Sample Sample)
            {
                owner.SampleComplete(Sample);
            }

            public void OnFingerGone(
                object Capture,
                string ReaderSerialNumber)
            {
                owner.FingerGone(
                    Capture,
                    ReaderSerialNumber
                );
            }

            public void OnFingerTouch(
                object Capture,
                string ReaderSerialNumber)
            {
                owner.FingerTouch(
                    Capture,
                    ReaderSerialNumber
                );
            }

            public void OnReaderConnect(
                object Capture,
                string ReaderSerialNumber)
            {
            }

            public void OnReaderDisconnect(
                object Capture,
                string ReaderSerialNumber)
            {
            }

            public void OnSampleQuality(
                object Capture,
                string ReaderSerialNumber,
                DPFP.Capture.CaptureFeedback CaptureFeedback)
            {
            }


        }
    }
}
