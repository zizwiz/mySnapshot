using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace mySnapshot
{
    public partial class Form1
    {
        /// <summary>
        /// Thread method that checks the date and creates folders when it changes.
        /// </summary>
        private void DateWatcher(RichTextBox myRichTextBox, Label myPathLabel, string myBaseFolder)
        {
            //Store the original start time
            DateTime currentDate = DateTime.Now;

            //Create the folder if it does not exist
            CreateDateFolder(currentDate, myRichTextBox, myPathLabel, myBaseFolder);

            while (true)
            {
                try
                {
                    DateTime newDate = DateTime.Now;

                    if (newDate.Date != currentDate.Date)
                    {
                        currentDate = newDate;
                        CreateDateFolder(currentDate, myRichTextBox, myPathLabel, myBaseFolder);
                    }
                }
                catch (Exception ex)
                {
                    // to prevent cross threading
                    if (myRichTextBox.InvokeRequired)
                    {
                        myRichTextBox.BeginInvoke((MethodInvoker)delegate ()
                        {
                            myRichTextBox.AppendText($"Error in date watcher: {ex.Message}");
                        });
                    }
                }

                // Sleep for 1 minute to reduce CPU usage
                Thread.Sleep(TimeSpan.FromMinutes(1));
            }
        }

        /// <summary>
        /// Creates a folder structure: BaseFolder\Year\Month\Day
        /// </summary>
        private void CreateDateFolder(DateTime date, RichTextBox myRichTextBox, Label myPathLabel, string myBaseFolder)
        {
            string yearFolder = Path.Combine(myBaseFolder, date.ToString("yyyy"));
            string monthFolder = Path.Combine(yearFolder, date.ToString("MMM"));
            string dayFolder = Path.Combine(monthFolder, date.ToString("dd"));

            try
            {
                // Create nested folders
                Directory.CreateDirectory(dayFolder);
                
                // write path name to label but invoke to prevent cross threading
                if (myPathLabel.InvokeRequired)
                {
                    myPathLabel.BeginInvoke((MethodInvoker)delegate ()
                    {
                       myPathLabel.Text = $"{dayFolder}\\";
                    });
                }
            }
            catch (Exception ex)
            {
                // to prevent cross threading
                if (myRichTextBox.InvokeRequired)
                {
                    myRichTextBox.BeginInvoke((MethodInvoker)delegate ()
                    {
                        myRichTextBox.AppendText($"Error creating folder '{dayFolder}': {ex.Message}");
                    });
                }
            }
        }
    }
}
