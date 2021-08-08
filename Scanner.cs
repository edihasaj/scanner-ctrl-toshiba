using OposScanner_CCO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ScannerControlToshiba
{
    public partial class Scanner : Form
    {
        private OPOSScanner _scanner;

        public Scanner()
        {
            InitializeComponent();
            _scanner = new OPOSScanner();
        }

        private void openScannerConnection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barkodi " + _scanner.ScanData);
        }

        private void _scanner_DataEvent(int Status)
        {
            MessageBox.Show("Barkodi " + string.Copy(_scanner.ScanData));
            _scanner.DataEvent -= _scanner_DataEvent;
            _scanner.DataEventEnabled = true;
            _scanner.DataEvent += _scanner_DataEvent;
        }

        private void Scanner_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void closeConnection_Click(object sender, EventArgs e)
        {
            _scanner.DeviceEnabled = false;
            _scanner.DataEventEnabled = false;
            _scanner.ReleaseDevice();
            _scanner.Close();
            MessageBox.Show("Mbyllja u be me sukses!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _scanner.Open("RS232Scanner");
            _scanner.ClaimDevice(10000);
            _scanner.DeviceEnabled = true;
            _scanner.DataEventEnabled = true;
            _scanner.DecodeData = true;
            _scanner.DataEvent += _scanner_DataEvent;
            MessageBox.Show("Data count " + _scanner.DataCount);
            MessageBox.Show(_scanner.DeviceName + " " 
                + _scanner.OpenResult);
            _scanner.ErrorEvent += _scanner_ErrorEvent;
        }

        private void _scanner_ErrorEvent(int ResultCode,
            int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse)
        {
            MessageBox.Show(ResultCode + " "
                + ResultCodeExtended + " " + ErrorLocus + " " + pErrorResponse);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_scanner.DeviceName + " " 
                + _scanner.Claimed.ToString());
        }
    }
}
