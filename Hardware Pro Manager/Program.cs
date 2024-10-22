using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
<<<<<<< HEAD
            Application.Run(new Splash());
=======
            Application.Run(new Items());
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
        }
    }
}
