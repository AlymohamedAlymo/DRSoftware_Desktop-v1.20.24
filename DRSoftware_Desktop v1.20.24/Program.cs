using DRSoftware_Desktop_v1._20._24.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DRSoftware_Desktop_v1._20._24
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}