using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archiver
{
    class clsArchiverTools
    {
        public string errorMessage { get; set; }
        public void copyFile(string fileName)
        {
            try
            {
                DateTime todaysDate;
                //todaysDate = now();
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                MessageBox.Show(errorMessage, "Error when copying file.", MessageBoxButtons.OK);
                throw;
            }
        }


    }
}
