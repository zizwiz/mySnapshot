using System;
using System.IO;
using System.Windows.Forms;

namespace mySnapshot.utilities
{
    class FolderUtils
    {
        /// <summary>
        /// Creates a folder structure: BaseFolder\Year\Month\Day
        /// </summary>
        public static void CreateDateFolder(DateTime myDate, RichTextBox myRichTextBox, Label myPathLabel, string myBaseFolder)
        {
            string yearFolder = Path.Combine(myBaseFolder, myDate.ToString("yyyy"));
            string monthFolder = Path.Combine(yearFolder, myDate.ToString("MMM"));
            string dayFolder = Path.Combine(monthFolder, myDate.ToString("dd"));

            try
            {
                // Create nested folders
                Directory.CreateDirectory(dayFolder);

                // write path name to label but invoke to prevent cross threading
                myPathLabel.Text = $"{dayFolder}\\";
                   
            }
            catch (Exception ex)
            {
                myRichTextBox.AppendText($"Error creating folder '{dayFolder}': {ex.Message}");
            }
        }
    }
}
