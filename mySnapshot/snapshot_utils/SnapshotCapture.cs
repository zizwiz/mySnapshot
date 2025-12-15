using System;
using System.Drawing;
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
            PictureBox myPictureBox, string myIPAddress, string myUsername, string myPassword)
        {
            int counter = 0;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(Encoding.ASCII.GetBytes($"{myUsername}:{myPassword}")));

                while (!token.IsCancellationRequested)
                {
                    string fileName = $"{DateTime.Now:ddMMyyyy_HHmmss}_{counter++}.jpg";

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
                    }
                    catch (Exception ex)
                    {
                        // FYI:
                        // On Some IP camera Using POE we seem to lose the web browser from time to time
                        // this tells us when we lost it but also goes back round the loop until cancelled
                        // Supplying separate voltage to the IP camera always brings back image.
                        myRichTextBox.AppendText($"\r\nError: {ex.Message}");

                        // We are missing an image and we need to put in small image as a marker
                        // Retrieve the image from project resources
                        Image img = Resources.missingImage;

                        // Save the image to disk in jpg format
                        img.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    await Task.Delay(30000, token); //waits 30 seconds to write complete file

                    //Write data to richtextbox
                    FileInfo info = new FileInfo(fileName); //create the file info object
                    myRichTextBox.AppendText($"\r\nSaved {fileName}" + "\r\nFilesize = " +
                                             info.Length + " bytes"); //Get file size
                    myRichTextBox.ScrollToCaret();

                    // Show the image we just saved
                    myPictureBox.Image = Image.FromFile(fileName);

                    await Task.Delay(30000, token); //waits 30 seconds in case we lost the web browser
                }
            }
        }
    }
}
