using System;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Resolved conflict: The application will always start with the Splash screen.
            Application.Run(new Splash());
        }
    }
}