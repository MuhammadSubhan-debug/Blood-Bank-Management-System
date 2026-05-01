using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public static class Logger
    {
        private static readonly string logPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

        public static void LogException(Exception ex)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine("===== EXCEPTION =====");
                    sw.WriteLine("Time: " + DateTime.Now);
                    sw.WriteLine("Message: " + ex.Message);
                    sw.WriteLine("Source: " + ex.Source);
                    sw.WriteLine("StackTrace: " + ex.StackTrace);

                    if (ex.InnerException != null)
                    {
                        sw.WriteLine("Inner Exception: " + ex.InnerException.Message);
                    }

                    sw.WriteLine("=====================");
                    sw.WriteLine();
                    MessageBox.Show("Logs updated\nCheck for Errors");
                }
            }
            catch
            {
                // Avoid crash if logging fails
            }
        }
    }
}
