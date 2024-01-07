using System;
using System.Windows.Forms;

namespace quan_li_ngan_hang
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
           Application.Run(new Formdangnhap1 ());
        }
    }
}
