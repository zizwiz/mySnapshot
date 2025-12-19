using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mySnapshot.browsing;
using mySnapshot.snapshot_utils;
using mySnapshot.utilities;

namespace mySnapshot
{
    public partial class Form1 : Form
    {
        private static CancellationTokenSource _cts;
        private static Task _runningTask;
       
        // Base folder where images will be stored in date folders
        private static readonly string BaseFolder = @"C:\timelapse";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            await webview_browser.EnsureCoreWebView2Async();

            setButtonVisibility();
            btn_start_capture.Visible = true;
            btn_stop_capture.Visible = false;

            if (txtbx_unique_number.Text == "") txtbx_unique_number.Text = "0"; //set to zero if empty else leave alone

            // TimeLapse Folder management - Ensure today's folder exists
            try
            {
                //Create the folder if it does not exist
                FolderUtils.CreateDateFolder(DateTime.Now, rchtxtbx_snapshot_results, lbl_save_folder, BaseFolder);
            }
            catch (Exception ex)
            {
                rchtxtbx_snapshot_results.AppendText($"Error creating base folder: {ex.Message}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cts != null)
            {
                _cts.Cancel(); // make the token a cancel token
                _cts.Dispose();
            }
        }
        private void btn_ping_Click(object sender, EventArgs e)
        {
            ConnectionUtils.PingCamera(txtbx_camera_ip_address.Text, rchtxtbx_snapshot_results);
        }

        private void btn_findURI_Click(object sender, EventArgs e)
        {
            ConnectionUtils.FindCameraIPAddress(rchtxtbx_snapshot_results);
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            browse.NavigateTo("http://" + txtbx_camera_ip_address.Text, webview_browser);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxtbx_snapshot_results.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_get_image_Click(object sender, EventArgs e) // not used at present
        {
            string camera_ip_address = txtbx_camera_ip_address.Text;
            string url = "http://" + camera_ip_address + "/Snapshot/1/RemoteImageCapture?ImageFormat=2";
            string username = txtbx_username.Text;
            string password = txtbx_password.Text;

            int counter = 0;

            while (true)
            {
                try
                {

                    // Create the request
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(username, password);

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

                    using (Stream stream = response.GetResponseStream())
                    {
                        string fileName = $"snapshot_{DateTime.Now:ddMMyyyy_HHmmss}_{counter}.jpg";
                        using (FileStream fs = new FileStream(fileName, FileMode.Create))
                        {
                            stream.CopyTo(fs);
                        }

                        rchtxtbx_snapshot_results.AppendText($"\r\nSaved {fileName}");
                        rchtxtbx_snapshot_results.ScrollToCaret();
                    }
                }
                catch (Exception ex)
                {
                    rchtxtbx_snapshot_results.AppendText($"\r\nError: {ex.Message}");
                    rchtxtbx_snapshot_results.ScrollToCaret();

                }

                counter++;
                // Wait 1 minute
                Thread.Sleep(TimeSpan.FromMinutes(1));

                //if (picbx_image.InvokeRequired)
                //{
                //    picbx_image.BeginInvoke((MethodInvoker)delegate ()
                //    {
                //        picbx_image.Image = Bitmap.FromFile(fileName);
                //    });
                //}
            }
        }

        private void btn_stop_capture_Click(object sender, EventArgs e)
        {
            btn_start_capture.Visible = true;
            btn_stop_capture.Visible = false;

            if (_cts != null)
            {
                _cts.Cancel();
                rchtxtbx_snapshot_results.AppendText("\r\nStopping capture......");
            }
            else
            {
                rchtxtbx_snapshot_results.AppendText("\r\nNot running......");
            }
        }

        private void btn_start_capture_Click(object sender, EventArgs e)
        {
            btn_start_capture.Visible = false;
            btn_stop_capture.Visible = true;

            if (_runningTask == null || _runningTask.IsCompleted)
            {
                _cts = new CancellationTokenSource();
                _runningTask = SnapshotCapture.RunSnapshotCaptureLoop(_cts.Token, rchtxtbx_snapshot_results,
                    picbx_image,
                    txtbx_camera_ip_address.Text, txtbx_username.Text, txtbx_password.Text,
                    lbl_file_name, lbl_file_size, lbl_retries, lbl_save_folder,
                    txtbx_unique_number, BaseFolder);
                rchtxtbx_snapshot_results.AppendText("\r\nCapture started........");
            }
            else
            {
                rchtxtbx_snapshot_results.AppendText("\r\nAlready running.......");
            }
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            myFormatter.Centre(pnl_username_lbl, lbl_username, txtbx_null);
            myFormatter.Centre(pnl_username_txtbx, lbl_null, txtbx_username);
            myFormatter.Centre(pnl_password_lbl, lbl_password, txtbx_null);
            myFormatter.Centre(pnl_password_txtbx, lbl_null, txtbx_password);
            myFormatter.Centre(pnl_camera_ip_address_lbl, lbl_camera_ip_address, txtbx_null);
            myFormatter.Centre(pnl_camera_ip_address_txtbx, lbl_null, txtbx_camera_ip_address);
        }

        private void tabcntrl_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void setButtonVisibility()
        {
            if (tabcntrl_main.SelectedTab == tab_snapshot)
            {
                btn_browse.Visible = false;
                btn_clear.Visible = btn_ping.Visible = btn_start_capture.Visible = btn_stop_capture.Visible
                     = true;
            }
            else if (tabcntrl_main.SelectedTab == tab_web_browser)
            {
                btn_browse.Visible = true;
                btn_clear.Visible = btn_ping.Visible = btn_start_capture.Visible = btn_stop_capture.Visible
                    = false;
            }
        }

        private async void btn_sync_time_Click(object sender, EventArgs e)
        {
            //Use this to sync the camera time to that of the PC recording the images
            await TimeUtils.SetTime(rchtxtbx_snapshot_results, txtbx_camera_ip_address.Text, txtbx_username.Text,
                txtbx_password.Text);
        }
    }
}





