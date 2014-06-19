using Microsoft.Win32;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Archiver
{
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());

            clsRegistry Registry;
            Registry = new clsRegistry();

            clsArchiverTools archiverTools;
            archiverTools = new clsArchiverTools();

            //Registry.addMenu_Click("Archiver", "cmd");
            //Registry.btnRemoveMenu_Click("Archiver", "cmd");

            MessageBox.Show(args[0].ToString());
        }
    }
}
