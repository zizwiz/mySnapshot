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
            string camera_ip_address = myIPAddress;
            string url = "http://" + camera_ip_address + "/Snapshot/1/RemoteImageCapture?ImageFormat=2";
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

                        using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
                        {
                            fs.Write(bytes, 0, bytes.Length);
                            fs.Close();
                        }

                        await Task.Delay(30000, token); //waits 30 seconds

                        FileInfo info = new FileInfo(fileName); //create the file info object

                        myRichTextBox.AppendText($"\r\nSaved {fileName}" + "\r\nFilesize = " +
                                                 info.Length + " bytes");
                        myRichTextBox.ScrollToCaret();

                        myPictureBox.Image = Image.FromFile(fileName);

                    }
                    catch (Exception ex)
                    {
                        myRichTextBox.AppendText($"\r\nError: {ex.Message}");
                    }

                    await Task.Delay(30000, token); //waits 30 seconds
                }
            }
        }
    }
}
