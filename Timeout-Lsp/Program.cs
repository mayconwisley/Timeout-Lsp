using System;
using System.Windows.Forms;

namespace Timeout_Copacol
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                Application.Run(new FrmPrincipal(args[0]));
            }
            else
            {
                Application.Run(new FrmPrincipal("2"));
            }
        }
    }
}
