using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFTP
{
    public partial class MainForm : Form
    {
        // Used to know what ftp action to use
        enum FTPAction
        {
            RESET_SERIAL,
            RESET_PAGE,
            RESET_MAIN,
            FIRMWARE_UPGRADE
        }

        // Current ftp action
        FTPAction currentFTPAction = FTPAction.RESET_SERIAL;

        // Settings to create file with 
        private Settings settings = new Settings();

        public MainForm()
        {
            InitializeComponent();

            settings.parent = this;
            hideLog();
        }

        #region Logging
        private void showLog()
        {
            button1.Text = "Hide Log";
            this.Size = new System.Drawing.Size(902, 558);
        }

        private void hideLog()
        {
            button1.Text = "Show Log";
            this.Size = new System.Drawing.Size(462, 558);
        }

        public void resetLog()
        {
            textBox3.Text = settings.Log;
        }
        public void writeLog(string text)
        {
            settings.Log += "\r\n" + text;
            resetLog();
        }
        #endregion

        private bool isValidIP(string ip)
        {
            // Make a regex to match to ip case
            Match match = Regex.Match(ip, @"\b(?:\d{1,3}\.){3}\d{1,3}\b",
                RegexOptions.IgnoreCase);

            // Here we check the Match instance.
            if (match.Success)
                return true;
            return false;
        }

        private void ftpButton_Click(object sender, EventArgs e)
        {
            // TODO Print Config page 

            // Do ftp action
            if (currentFTPAction == FTPAction.RESET_MAIN)
            {
                IOHelper.ftpMain(settings);
            }
            else if (currentFTPAction == FTPAction.RESET_PAGE)
            {
                IOHelper.ftpPage(settings);
            }
            else if (currentFTPAction == FTPAction.RESET_SERIAL)
            {
                // Only allow Serial reset on one printer
                if (settings.PrinterIPRange.Length == 1)
                    IOHelper.ftpSerial(settings);
                else
                {
                    writeLog("You can only reset the Serial on one printer. \n Multiple printers are not allowed to have the same serial.");
                    showLog();
                }
            }
            else if (currentFTPAction == FTPAction.FIRMWARE_UPGRADE)
            {
                // If user selects a file and pushes ok, then upgrade the firmware
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }

            // Reset the log
            resetLog();
        }

        private void radioResetSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioResetSerial.Checked)
                currentFTPAction = FTPAction.RESET_SERIAL;
            else if (radioResetPage.Checked)
                currentFTPAction = FTPAction.RESET_PAGE;
            else if (radioMaint.Checked)
                currentFTPAction = FTPAction.RESET_MAIN;
        }

        private void textBoxSerial_Leave(object sender, EventArgs e)
        {
            // If textbox is not blank, set the serial equal to it. 
            // If false, sent the reverse
            if (!textBoxSerial.Text.Equals(""))
                settings.SerialNumber = textBoxSerial.Text;
            else
                textBoxSerial.Text = settings.SerialNumber;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings.ShowLog = !settings.ShowLog;

            if (settings.ShowLog)
                showLog();
            else
                hideLog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.parent = null;
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Log = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Make the text box allways display the newest logs 
            textBox3.SelectionStart = textBox3.TextLength;
            textBox3.ScrollToCaret();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            // Get the line of IP's 
            string[] lines = Regex.Split(textBox2.Text, "\r\n");

            // Check which IP's are valid
            List<string> ips = new List<string>();
            for (int i = 0; i < lines.Length; i++)
                if (isValidIP(lines[i]))
                    ips.Add(lines[i]);

            // Set ip list as ips from textbox2
            if (ips.Count > 0)
                settings.PrinterIPRange = ips.ToArray();

            // Reset textbox2 text
            textBox2.Text = "";
            // Put all valid ip's back into text box 
            for (int i = 0; i < settings.PrinterIPRange.Length; i++)
            {
                if (i != settings.PrinterIPRange.Length - 1)
                    textBox2.Text += settings.PrinterIPRange[i] + "\r\n";
                else
                    textBox2.Text += settings.PrinterIPRange[i];
            }
        }

        private void pageCountBox_TextChanged(object sender, EventArgs e)
        {
            // try to parse text box
            try
            {
                int hold = Convert.ToInt32(pageCountBox.Text);
                settings.PageCount = hold;
            }
            catch (Exception ex) { }

            // Set textbox back to page count value
            pageCountBox.Text = "" + settings.PageCount;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Equals("sunprint5441"))
            {
                settings.PageCountPasswordCorrect = true;
                passwordStatusLabel.Text = "Correct";
                passwordStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                settings.PageCountPasswordCorrect = false;
                passwordStatusLabel.Text = "Incorrect";
                passwordStatusLabel.ForeColor = Color.Red;
            }
        }

        private void sendTestFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If user selects a file, print it
            if (printFileDialoge.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = printFileDialoge.FileName;
                IOHelper.printFile(settings, file);
            }
        }

        private void updateFirmwareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Request the user to select a file
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // If a file is selected, display it in the text box 
                settings.FirmwareFile = openFileDialog1.FileName;
                IOHelper.ftpFirmware(settings);
            }
        }

        private void printConfigPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IOHelper.testPage(settings);
        }
    }
}
