using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sampleprjct
{
    static class Program
    {
        public static String FrmState;
        public static String username;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmmainmenu());
        }
    }
}
