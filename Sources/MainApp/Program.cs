using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourCounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "df29c248-e00e-4f87-8ada-7d72b2d7ad31", out result); //Unique ID for app

            if (!result)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());

            GC.KeepAlive(mutex); //This way GC Don't collect the mutex
        }
    }
}
