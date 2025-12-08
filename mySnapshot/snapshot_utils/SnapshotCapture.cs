using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySnapshot.snapshot_utils
{
    class SnapshotCapture
    {
        public static async Task RunSnapshotCaptureLoop(CancellationToken token, RichTextBox myRichTextBox,
            PictureBox myPictureBox, string myIPAddress, string myUsername, string myPassword)
        {
            int counter = 0;
            string url = "http://" + myIPAddress + "/Snapshot/1/RemoteImageCapture?ImageFormat=2";
            string username = myUsername;
            string password = myPassword;

            using (var client = new HttpClient())
            {
                var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

               while (!token.IsCancellationRequested)
                {
                    try
                    {
                        var response = await client.GetAsync(url, token);
                        response.EnsureSuccessStatusCode();

                        var bytes = await response.Content.ReadAsByteArrayAsync();

                        string fileName = $"snapshot_{DateTime.Now:ddMMyyyy_HHmmss}_{counter++}.jpg";
                        // await File.WriteAllBytesAsync(fileName, bytes, token); // Use instead of filestream on newer c# versions

                        using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
                        {
                            fs.Write(bytes, 0, bytes.Length);
                            fs.Close();
                        }

                        await Task.Delay(30000, token); //waits 30 seconds to write complete file

                        FileInfo info = new FileInfo(fileName); //create the file info object

                        myRichTextBox.AppendText($"\r\nSaved {fileName}" + "\r\nFilesize = " +
                                                 info.Length + " bytes"); //Get file size
                        myRichTextBox.ScrollToCaret();

                        myPictureBox.Image = Image.FromFile(fileName); // Show the image we just saved

                    }
                    catch (Exception ex)
                    {
                        // FYI:
                        // On Some IP camera Using POE we seem to lose the web broswer from time to time
                        // this tells us when we lost it but also goes back round the loop until cancelled
                        // Supplying separate voltage to the IP camera always brings back image.
                        myRichTextBox.AppendText($"\r\nError: {ex.Message}"); 
                    }

                    await Task.Delay(30000, token); //waits 30 seconds in case we lost the web browser
                }
            }
        }
    }
}
