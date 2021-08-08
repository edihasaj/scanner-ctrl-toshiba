using OposScanner_CCO;
using System; 

namespace ScannerControlToshiba
{
    public class ToshibaScanner : IDisposable
    {
        public OPOSScanner Scanner;
        public string ScannerType { get; set; }

        public ToshibaScanner(string scannerType = "RS232Scanner")
        {
            try
            {

            Scanner = new OPOSScanner();
            ScannerType = scannerType;
            }
            catch (Exception)
            { 
            }
        }

        public void OpenScannerConnection()
        {
            if (Scanner == null)
                return;
            Scanner.Open(ScannerType);
            Scanner.ClaimDevice(10000);
            Scanner.DeviceEnabled = true;
            Scanner.DataEventEnabled = true;
            Scanner.DecodeData = true;
        }

        public void CloseScannerConnection()
        {
            if (Scanner == null)
                return;
            Scanner.DeviceEnabled = false;
            Scanner.DataEventEnabled = false;
            Scanner.ReleaseDevice();
            Scanner.Close();
        }

        public void CloseScannerConnectionPermanently()
        {
            if (Scanner == null)
                return;

            Scanner.DeviceEnabled = false;
            Scanner.DataEventEnabled = false;
            Scanner.ReleaseDevice();
            Scanner.Close();
        }

        public string GetBarcode()
        {
            return !string.IsNullOrEmpty(Scanner.ScanData) ?
                string.Copy(Scanner.ScanData) : string.Empty;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            CloseScannerConnectionPermanently();

            if (disposing == true)
            {
                ReleaseManagedResources();
            }
            else
            {
            }

            ReleaseUnmangedResources();
        }

        ~ToshibaScanner()
        {
            Dispose(false);
        }

        void ReleaseManagedResources()
        {
            if (Scanner != null)
            {
                Scanner = null;
            }
        }

        void ReleaseUnmangedResources()
        { }
    }
}
