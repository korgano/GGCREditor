using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GGCREditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            catch (Exception ex)
            {
                string logPath = Path.Combine(Application.StartupPath, "log");
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
                string logFile = Path.Combine(logPath, "error_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".log");
                string logContent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " FATAL ERROR\r\n" +
                    "Message: " + ex.Message + "\r\n\r\nStack Trace:\r\n" + ex.StackTrace;
                File.WriteAllText(logFile, logContent);
                MessageBox.Show("FATAL ERROR: " + ex.Message + "\n\nStack trace:\n" + ex.StackTrace + "\n\nError logged to:\n" + logFile,
                    "GGCREditor Crash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
