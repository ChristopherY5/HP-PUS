using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BatchFTP
{
    public class Settings
    {
        public MainForm parent;
        private string printerIP = "0.0.0.0";
        private string[] printerIPRange = new string[] { "0.0.0.0", "0.0.0.0", "0.0.0.0" };
        private string log = "";
        private bool showLog = false;
        private string firmwareFile = "";
        private int pageCount = 0;
        private bool pageCountPasswordCorrect = false;

        // FTP Serial Variables 
        private string serialNumber = "none";

        public string PrinterIP
        {
            get { return printerIP; }
            set { printerIP = value; }
        }
        public string[] PrinterIPRange
        {
            get { return printerIPRange; }
            set { printerIPRange = value; }
        }
        public string Log
        {
            get { return log; }
            set
            {
                log = value;

                if (parent != null)
                    parent.resetLog();
            }
        }
        public bool ShowLog
        {
            get { return showLog; }
            set { showLog = value; }
        }
        public string FirmwareFile
        {
            get { return firmwareFile; }
            set { firmwareFile = value; }
        }
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (value >= 0)
                    pageCount = value;
            }
        }
        public bool PageCountPasswordCorrect
        {
            get { return pageCountPasswordCorrect; }
            set { pageCountPasswordCorrect = value; }
        }

        // FTP Serial settings 
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
    }
}
