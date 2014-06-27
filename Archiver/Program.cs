using System.Windows.Forms;
using System;

namespace Archiver
{

    /* 
     * Verison History
     * 
     * Jun-14: Inital program created
     * 
     * - Copys files only
     * - does not insert registry entry this has to be done manually
     * 
    */

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

            clsTools myTools = new clsTools();

            clsArchiverTools archiverTools;
            archiverTools = new clsArchiverTools();

            string fileName = args[0].ToString();

            //TODO: Add code to verify if Archive settings are in registry

            // check Registry
            // is the registry entry the same as the current program path!

            // If not valid enter new settings

            // End check

            //Registry.addMenu_Click("Archiver", "cmd");
            //Registry.btnRemoveMenu_Click("Archiver", "cmd");

            //MessageBox.Show(fileName,myTools.PublishVersion);
            archiverTools.copyFile(fileName);
        }
    }
}
