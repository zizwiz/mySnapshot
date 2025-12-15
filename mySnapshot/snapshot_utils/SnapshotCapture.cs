using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mySnapshot.Properties;

namespace mySnapshot.snapshot_utils
{
    class SnapshotCapture
    {
        public static async Task RunSnapshotCaptureLoop(CancellationToken token, RichTextBox myRichTextBox,
            PictureBox myPictureBox, string myIPAddress, string myUsername, string myPassword,
            Label myFilename_label, Label myFilesize_label, Label myRetries_label)
        {
            int counter = 0;
            int retry_times = 0;
            bool retry = true;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(Encoding.ASCII.GetBytes($"{myUsername}:{myPassword}")));

                while (!token.IsCancellationRequested)
                {
                    string fileName = $"{DateTime.Now:ddMMyyyy_HHmmss}_{counter++}.jpg";
                    
                    while (retry)
                    {
                        try
                        {
                            var response = await client.GetAsync("http://" + myIPAddress + "/Snapshot/1/RemoteImageCapture?ImageFormat=2", token);
                            response.EnsureSuccessStatusCode();

                            var bytes = await response.Content.ReadAsByteArrayAsync();


                            // await File.WriteAllBytesAsync(fileName, bytes, token); // Use instead of filestream on newer c# versions

                            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
                            {
                                fs.Write(bytes, 0, bytes.Length);
                                fs.Close();
                            }

                            retry = false;
                        }
                        catch (Exception ex)
                        {
                            // FYI:
                            // On Some IP camera Using POE we seem to lose the web browser from time to time
                            // this tells us when we lost it but also goes back round the loop until cancelled
                            // Supplying separate voltage to the IP camera always brings back image.
                            myRichTextBox.AppendText($"\r\nError: {ex.Message}");
                            myRichTextBox.AppendText($"\rRetry : {retry_times++}");

                            // We are missing an image and we need to put in small image as a marker
                            // Retrieve the image from project resources
                            //Image img = Resources.missingImage;

                            // Save the image to disk in jpg format
                            // img.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        await Task.Delay(500, token); //waits 0.5 seconds and then try again
                    }

                    if (retry_times > 60) retry_times = 60; // set ceiling of retry times to 30 seconds

                   await Task.Delay(30000 - (retry_times*500), token); //waits 30 seconds minus any retry time
                    
                    
                   
                    //Write data to richtextbox
                    FileInfo info = new FileInfo(fileName); //create the file info object
                    myRichTextBox.AppendText($"\r\nSaved {fileName}" + "\r\nFilesize = " +
                                             info.Length + " bytes"); //Get file size
                    myRichTextBox.ScrollToCaret();

                    // Show the image we just saved
                    myPictureBox.Image = Image.FromFile(fileName);

                    //write the data to a csv file
                    try
                    {
                        // Prepare CSV file path (will be created in the same folder as the executable)
                        string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "output.csv");

                       
                        // Check if file exists to decide whether to write header
                        bool writeHeader = !File.Exists(csvFilePath);

                        using (StreamWriter writer = new StreamWriter(csvFilePath, append: true))
                        {
                            if (writeHeader)
                            {
                                writer.WriteLine("Date,Time,FileName,FileSize,RetryTimes");
                            }

                            // Write CSV row
                            writer.WriteLine($"{DateTime.Now.ToString("ddMMyyyy", CultureInfo.InvariantCulture)}," +
                                             $"{DateTime.Now.ToString("HHmmss", CultureInfo.InvariantCulture)}," +
                                             $"{fileName},{info.Length},{retry_times}");
                        }

                        myFilename_label.Text = fileName;
                        myFilesize_label.Text = info.Length.ToString();
                        myRetries_label.Text = retry_times.ToString();

                    }
                    catch (Exception ex)
                    {
                        myRichTextBox.AppendText($"\r\nError: {ex.Message}"); //why did we get error
                        myRichTextBox.ScrollToCaret();
                    }

                    retry_times = 0; //reset to 0
                    await Task.Delay(30000, token); //waits 30 seconds to make sure we have written everything
                }
            }
        }

    }
}
