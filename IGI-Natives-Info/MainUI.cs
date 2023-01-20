using MethodSignatureFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGI_Natives_Info
{
    static class MainUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                bool instanceCount = false;
                Mutex mutex = null;
                var projAppName = AppDomain.CurrentDomain.FriendlyName;

                mutex = new Mutex(true, projAppName, out instanceCount);
                if (instanceCount)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new IGINativesForm());
                    mutex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("IGI Natives Info is already running", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
