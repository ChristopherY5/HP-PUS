using BatchFTP.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BatchFTP
{
    public class IOHelper
    {
        private static string resetPageFileName = "reset_page_count.txt";
        private static string resetMaintFileName = "reset_maint_count.txt";
        private static string resetSerialFileName = "reset_serial_number.txt";
        private static string configFileName = "config.txt";

        private static string batFile = "batTemp.bat";
        private static string ftpBatFile = "ftpBatFile.bat";

        public static void ftpPage(Settings settings)
        {
            // Do not allow user to reset page count unless password is 0
            if (settings.PageCount == 0 && !settings.PageCountPasswordCorrect)
            {
                MessageBox.Show(
                    "A correct password must be entered\nto reset page count to 0.",
                    "Incorrect Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Some printers need a hex value, so retreive this value
            string hexValue = settings.PageCount.ToString("X");

            // Make reset file
            string[] lines = new string[7];
            lines[0] = Resources.maint_page_LineStart;
            lines[1] = "@PJL SET PAGES=" + settings.PageCount;
            lines[2] = "@PJL DEFAULT PAGES=" + settings.PageCount;
            lines[3] = "@PJL DMINFO ASCIIHEX = \"04000401010109080300" + hexValue + "\"";
            lines[4] = "@PJL DMINFO ASCIIHEX = \"04000501040102060802" + hexValue + "\"";
            lines[5] = "@PJL SET SERVICEMODE=EXIT";
            lines[6] = Resources.lineEnd;
            File.WriteAllLines(resetPageFileName, lines);
            File.SetAttributes(resetPageFileName, File.GetAttributes(resetPageFileName) | FileAttributes.Hidden);
            settings.Log += "Page reset file created.\r\n\r\n";

            // Run Bat file
            makeCommandBatFile(settings);

            string[] batFtpLines = new string[6];
            batFtpLines[0] = "bin";
            batFtpLines[1] = "echo ";
            batFtpLines[2] = "echo ";
            batFtpLines[3] = "send " + resetPageFileName;
            batFtpLines[4] = "bye";
            batFtpLines[5] = "exit";

            File.WriteAllLines(ftpBatFile, batFtpLines);
            File.SetAttributes(ftpBatFile, File.GetAttributes(ftpBatFile) | FileAttributes.Hidden);
            settings.Log += "Batch files created.\r\n\r\n";

            IOHelper.lauchBat(batFile, settings);

            // Delete files 
            File.Delete(resetPageFileName);
            File.Delete(batFile);
            File.Delete(ftpBatFile);
        }
        public static void ftpMain(Settings settings)
        {
            // Make reset file
            string[] lines = new string[7];
            lines[0] = Resources.maint_page_LineStart;
            lines[1] = "@PJL DEFAULT MAINTCOUNT=0";
            lines[2] = "@PJL DEFAULT MAINTINTERVAL=999999";
            lines[3] = "@PJL DEFAULT ADFMAINTCOUNT=0";
            lines[4] = "@PJL DEFAULT ADFMAINTINTERVAL=999999";
            lines[5] = "@PJL SET SERVICEMODE=EXIT";
            lines[6] = Resources.lineEnd;
            File.WriteAllLines(resetMaintFileName, lines);
            File.SetAttributes(resetMaintFileName, File.GetAttributes(resetMaintFileName) | FileAttributes.Hidden);
            settings.Log += "Maintenance reset file created.\r\n\r\n";

            // Run Bat file
            makeCommandBatFile(settings);

            string[] batFtpLines = new string[6];
            batFtpLines[0] = "bin";
            batFtpLines[1] = "echo ";
            batFtpLines[2] = "echo ";
            batFtpLines[3] = "send " + resetMaintFileName;
            batFtpLines[4] = "bye";
            batFtpLines[5] = "exit";

            File.WriteAllLines(ftpBatFile, batFtpLines);
            File.SetAttributes(ftpBatFile, File.GetAttributes(ftpBatFile) | FileAttributes.Hidden);
            settings.Log += "Batch files created.\r\n\r\n";

            IOHelper.lauchBat(batFile, settings);

            // Delete files 
            File.Delete(resetMaintFileName);
            File.Delete(batFile);
            File.Delete(ftpBatFile);
        }
        public static void ftpSerial(Settings settings)
        {
            // Make reset file
            string[] lines = new string[6];
            lines[0] = Resources.serial_lineStart;
            lines[1] = "@PJL SET SERVICEMODE = HPBOISEID";
            lines[2] = "@PJL DEFAULT SERIALNUMBER = " + settings.SerialNumber;
            lines[3] = "@PJL SET SERVICEMODE = EXIT";
            lines[4] = "@PJL EOJ";
            lines[5] = Resources.lineEnd;
            File.WriteAllLines(resetSerialFileName, lines);
            File.SetAttributes(resetSerialFileName, File.GetAttributes(resetSerialFileName) | FileAttributes.Hidden);
            settings.Log += "Serial change file created.\r\n\r\n";
            
            // Run Bat file
            makeCommandBatFile(settings);

            string[] batFtpLines = new string[6];
            batFtpLines[0] = "bin";
            batFtpLines[1] = "echo";
            batFtpLines[2] = "echo";
            batFtpLines[3] = "send " + resetSerialFileName;
            batFtpLines[4] = "bye";
            batFtpLines[5] = "exit";

            File.WriteAllLines(ftpBatFile, batFtpLines);
            File.SetAttributes(ftpBatFile, File.GetAttributes(ftpBatFile) | FileAttributes.Hidden);
            settings.Log += "Batch files created.\r\n\r\n";

            IOHelper.lauchBat(batFile, settings);

            // Delete files 
            File.Delete(resetSerialFileName);
            File.Delete(batFile);
            File.Delete(ftpBatFile);
        }
        public static void printFile(Settings settings, string file)
        {
            // Run Bat file
            makeCommandBatFile(settings);

            string[] batFtpLines = new string[5];
            batFtpLines[0] = "echo";
            batFtpLines[1] = "echo";
            batFtpLines[2] = "put " + file + " port1";
            batFtpLines[3] = "bye";
            batFtpLines[4] = "exit";

            File.WriteAllLines(ftpBatFile, batFtpLines);
            File.SetAttributes(ftpBatFile, File.GetAttributes(ftpBatFile) | FileAttributes.Hidden);
            settings.Log += "Batch files created.\r\n\r\n";

            IOHelper.lauchBat(batFile, settings);

            // Delete files 
            File.Delete(batFile);
            File.Delete(ftpBatFile);
        }
        public static void ftpFirmware(Settings settings)
        {
            // Only do action if file exists 
            if (File.Exists(settings.FirmwareFile))
            {
                // Send file to printer
                // Run Bat file
                makeCommandBatFile(settings);

                string[] batFtpLines = new string[6];
                batFtpLines[0] = "bin";
                batFtpLines[1] = "echo";
                batFtpLines[2] = "echo";
                batFtpLines[3] = "put " + settings.FirmwareFile;
                batFtpLines[4] = "bye";
                batFtpLines[5] = "exit";

                File.WriteAllLines(ftpBatFile, batFtpLines);
                File.SetAttributes(ftpBatFile, File.GetAttributes(ftpBatFile) | FileAttributes.Hidden);
                settings.Log += "Batch files created.\r\n\r\n";

                IOHelper.lauchBat(batFile, settings);

                // Delete files 
                File.Delete(resetSerialFileName);
                File.Delete(batFile);
                File.Delete(ftpBatFile);
            }
            else
            {
                MessageBox.Show(
                    "Selected Firmware file cannot be found.",
                    "File not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void testPage(Settings settings)
        {
            // Make reset file
            string[] lines = new string[3];
            lines[0] = Resources.serial_lineStart;
            lines[1] = Resources.testpage;
            lines[2] = Resources.lineEnd;
            File.WriteAllLines(configFileName, lines);
            File.SetAttributes(configFileName, File.GetAttributes(configFileName) | FileAttributes.Hidden);
            settings.Log += "Test page file created.\r\n\r\n";

            // Run Bat file
            makeCommandBatFile(settings);

            string[] batFtpLines = new string[6];
            batFtpLines[0] = "bin";
            batFtpLines[1] = "echo";
            batFtpLines[2] = "echo";
            batFtpLines[3] = "send " + configFileName;
            batFtpLines[4] = "bye";
            batFtpLines[5] = "exit";

            File.WriteAllLines(ftpBatFile, batFtpLines);
            File.SetAttributes(ftpBatFile, File.GetAttributes(ftpBatFile) | FileAttributes.Hidden);
            settings.Log += "Batch files created.\r\n\r\n";

            IOHelper.lauchBat(batFile, settings);

            // Delete files 
            File.Delete(configFileName);
            File.Delete(batFile);
            File.Delete(ftpBatFile);
        }

        private static void makeCommandBatFile(Settings settings)
        {
            // Run Bat file
            string[] batLines;
            batLines = new string[settings.PrinterIPRange.Length];
            for (int i = 0; i < settings.PrinterIPRange.Length; i++)
                batLines[i] = "ftp -s:" + ftpBatFile + " " + settings.PrinterIPRange[i];
            File.WriteAllLines(batFile, batLines);
            File.SetAttributes(batFile, File.GetAttributes(batFile) | FileAttributes.Hidden);
        }

        /// <summary>
        /// Lauch the bat file represented by the string
        /// </summary>
        /// <param name="file"></param>
        public static void lauchBat(string file, Settings settings)
        {
            settings.Log += "========= Batch Launched =========\r\n";
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = file;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.\r\n
            settings.Log += "\r\n" + p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            settings.Log += "========= Batch Finished =========\r\n\r\n\r\n";
        }
    }
}
