using System;
using System.IO;
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
                string todaysDate;
                string newFileName;
                
                // Seperate filename into filename and extension
                string[] filenameParts = fileName.Split('.');                

                // get new timestamp
                todaysDate = "-" + DateTime.Now.ToString("yyMMdd") + "-" + DateTime.Now.ToString("hhmm");

                // Add todays timestamp onto the end of the file name to get new file name
                newFileName = filenameParts[0] + todaysDate;

                // check if there is an extension
                if (filenameParts.Length > 1)
                {
                    newFileName += "." + filenameParts[1];
                }

                //MessageBox.Show(newFileName, "New File name");

                // copy the file
                File.Copy(fileName, newFileName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                MessageBox.Show(errorMessage, "Error copying file.", MessageBoxButtons.OK);
                throw;
            }
        }


    }
}
