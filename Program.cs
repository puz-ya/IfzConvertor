using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IFZConvertor
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

            //Application.Run(new Form1());

            // If we want to create several forms and switch between them:
            // The trick is to use Application.Run() without parameters and Application.Exit() at the point where you want to exit the application.
            (new Form1()).Show();
            Application.Run();
        }
    }
}
