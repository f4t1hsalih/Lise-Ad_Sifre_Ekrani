using System;
using System.Windows.Forms;

namespace Ad_Sifre_Ekrani
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
            Application.Run(new FormAnaform());
        }
    }
}
