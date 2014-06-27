using Microsoft.Win32;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver
{
    class clsRegistry
    {
        private const string MenuName = "Folder\\shell\\Archiver";
        private const string Command = "Folder\\shell\\Archiver\\Copy";

        public void addMenu_Click(string name, string path)
        {
            string errorMessage = "No Error message";


            RegistryKey regmenu = null;
            RegistryKey regcmd = null;
            try
            {
                regmenu = Registry.ClassesRoot.CreateSubKey(MenuName);
                if (regmenu != null)
                    regmenu.SetValue("", name);
                regcmd = Registry.ClassesRoot.CreateSubKey(Command);
                if (regcmd != null)
                    regcmd.SetValue("", path);
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                MessageBox.Show(errorMessage, "An Error when adding shell context menu.", MessageBoxButtons.OK);
            }
            finally
            {
                if (regmenu != null)
                    regmenu.Close();
                if (regcmd != null)
                    regcmd.Close();
            }
        }

        public void btnRemoveMenu_Click(string name, string path)
        {
            string errorMessage = "No Error message";
            try
            {
                RegistryKey reg = Registry.ClassesRoot.OpenSubKey(Command);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(Command);
                }
                reg = Registry.ClassesRoot.OpenSubKey(MenuName);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(MenuName);
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                MessageBox.Show(errorMessage, "Error when deleting shell context menu.", MessageBoxButtons.OK);
            }
        }
    }
}
