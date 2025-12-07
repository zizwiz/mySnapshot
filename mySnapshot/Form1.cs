using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using CenteredMessagebox;
using mySnapshot.browsing;
using mySnapshot.utilities;
using Timer = System.Windows.Forms.Timer;

namespace mySnapshot
{
    public partial class Form1 : Form
    {
        CancellationTokenSource tokenSource; // Declare the cancellation token

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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tokenSource.Cancel(); // make the token a cancel token
        }

        private void btn_findURI_Click(object sender, EventArgs e)
        {


            // WS-Discovery multicast address and port
            string multicastAddress = "239.255.255.250";
            int multicastPort = 3702;

            // Create UDP client
            UdpClient udpClient = new UdpClient();
            udpClient.EnableBroadcast = true;

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(multicastAddress), multicastPort);


            // Build WS-Discovery Probe message (SOAP XML)
            string probeMessage = @"<?xml version=""1.0"" encoding=""UTF-8""?>
        <Envelope xmlns=""http://www.w3.org/2003/05/soap-envelope""
                  xmlns:a=""http://schemas.xmlsoap.org/ws/2004/08/addressing""
                  xmlns:d=""http://schemas.xmlsoap.org/ws/2005/04/discovery"">
          <Header>
            <a:Action mustUnderstand=""1"">http://schemas.xmlsoap.org/ws/2005/04/discovery/Probe</a:Action>
            <a:MessageID>urn:uuid:" + Guid.NewGuid().ToString() + @"</a:MessageID>
            <a:To mustUnderstand=""1"">urn:schemas-xmlsoap-org:ws:2005:04:discovery</a:To>
          </Header>
          <Body>
            <d:Probe>
              <d:Types>dn:NetworkVideoTransmitter</d:Types>
            </d:Probe>
          </Body>
        </Envelope>";

            byte[] probeBytes = Encoding.UTF8.GetBytes(probeMessage);

            // Send probe
            udpClient.Send(probeBytes, probeBytes.Length, endPoint);

            rchtxtbx_snapshot_results.AppendText("\r\nProbe sent. Listening for responses...");
            rchtxtbx_snapshot_results.ScrollToCaret();

            // Listen for responses (timeout after 5 seconds)
            udpClient.Client.ReceiveTimeout = 5000;

            try
            {
                bool flag = true;

                while (flag)
                {
                    IPEndPoint remoteEP = null;
                    byte[] responseBytes = udpClient.Receive(ref remoteEP);
                    string responseXml = Encoding.UTF8.GetString(responseBytes);

                    // txtbx_results.AppendText("\r\nResponse from " + remoteEP.Address);
                    // txtbx_results.AppendText("\r\n" + responseXml + "\r\n");

                    // Parse XML to extract XAddrs (service address)
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(responseXml);

                    XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
                    ns.AddNamespace("d", "http://schemas.xmlsoap.org/ws/2005/04/discovery");
                    ns.AddNamespace("a", "http://schemas.xmlsoap.org/ws/2004/08/addressing");
                    ns.AddNamespace("wsd", "http://schemas.xmlsoap.org/ws/2005/04/discovery");
                    ns.AddNamespace("soap", "http://www.w3.org/2003/05/soap-envelope");

                    XmlNode xAddrsNode = doc.SelectSingleNode("//wsd:XAddrs", ns);
                    if (xAddrsNode != null)
                    {
                        string input = xAddrsNode.InnerText;
                        try
                        {
                            // Find the index of the first and second '/'
                            int firstSlash = input.IndexOf('/');
                            if (firstSlash == -1) throw new Exception("First '/' not found.");

                            int secondSlash = input.IndexOf('/', firstSlash + 1);
                            if (secondSlash == -1) throw new Exception("Second '/' not found.");

                            // Find the first ':' after the second '/'
                            int colonIndex = input.IndexOf(':', secondSlash + 1);
                            if (colonIndex == -1) throw new Exception("':' not found after second '/'.");

                            // Extract the substring between second '/' and ':'
                            //string result = input.Substring(secondSlash + 1, colonIndex - (secondSlash + 1));
                            //txtbx_results.AppendText($"\r\nCamera IP Address = {result}");

                            txtbx_camera_ip_address.Text = input.Substring(secondSlash + 1, colonIndex - (secondSlash + 1));
                        }
                        catch (Exception ex)
                        {
                            rchtxtbx_snapshot_results.AppendText($"\r\nError: {ex.Message}");
                            rchtxtbx_snapshot_results.ScrollToCaret();
                        }



                        // txtbx_results.AppendText("\r\nCamera Service Address = " + xAddrsNode.InnerText);
                        flag = false;
                        return;
                    }

                }
            }
            catch (SocketException)
            {
                rchtxtbx_snapshot_results.AppendText("\r\nListening finished (timeout). Please try again.");
                rchtxtbx_snapshot_results.ScrollToCaret();
            }



        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxtbx_snapshot_results.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static Timer _timer;


        //private void btn_get_image_Click(object sender, EventArgs e)
        //{






        //    // Camera credentials
        //    //private static string cameraIp = "192.168.1.50";   // replace with your camera IP
        //    //private static string username = "admin";          // replace with your username
        //    //private static string password = "12345";          // replace with your password


        //    // Set up a timer to trigger every 60 seconds
        //    _timer = new Timer(60 * 1000);
        //    _timer.Elapsed += GrabSnapshot;
        //    _timer.AutoReset = true;
        //    _timer.Enabled = true;

        //    //Console.WriteLine("Press Enter to exit...");
        //    //Console.ReadLine();
        //}

        private static void GrabSnapshot(object sender, ElapsedEventArgs e)
        {
        }

        private void btn_get_image_Click(object sender, EventArgs e)
        {

            //// Load a webpage
            //try
            //{
            //    webbsr_image.Navigate("http://192.168.1.113/Snapshot/1/RemoteImageCapture?ImageFormat=2");
            //}
            //catch (UriFormatException)
            //{
            //    MessageBox.Show("Invalid URL format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error loading page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            string camera_ip_address = txtbx_camera_ip_address.Text;
            string url = "http://" + camera_ip_address + "/Snapshot/1/RemoteImageCapture?ImageFormat=2";
            string username = txtbx_username.Text;
            string password = txtbx_password.Text;

            int counter = 0;



            while (true)
            {
                //string fileName = $"snapshot_{DateTime.Now:ddMMyyyy_HHmmss}_{counter}.jpg";

                try
                {

                    // Create the request
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(username, password);

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

                    using (Stream stream = response.GetResponseStream())
                    {
                        //Thread.Sleep(200);
                        //Thread.Sleep(TimeSpan.FromMinutes(0.5));
                        string fileName = $"snapshot_{DateTime.Now:ddMMyyyy_HHmmss}_{counter}.jpg";
                        using (FileStream fs = new FileStream(fileName, FileMode.Create))
                        {
                            stream.CopyTo(fs);
                        }

                        rchtxtbx_snapshot_results.AppendText($"\r\nSaved {fileName}");
                        rchtxtbx_snapshot_results.ScrollToCaret();

                        //picbx_image.Image = Bitmap.FromFile(fileName);
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
                //Thread.Sleep(TimeSpan.FromMinutes(0.5));



                //if (picbx_image.InvokeRequired)
                //{
                //    picbx_image.BeginInvoke((MethodInvoker)delegate ()
                //    {
                //        picbx_image.Image = Bitmap.FromFile(fileName);
                //    });
                //}
            }




        }

        private void DrawImage(PictureBox myPictureBox, string myLocation)
        {
            // Draw picture to UI but as we have a task watch for cross threading

            if (myPictureBox.InvokeRequired)
            {
                myPictureBox.BeginInvoke((MethodInvoker)delegate ()
                {
                    myPictureBox.ImageLocation = myLocation;
                });
            }
            else
            {
                myPictureBox.ImageLocation = myLocation;
            }
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            string ip_address = txtbx_camera_ip_address.Text;
            Ping pingSender = new Ping();

            rchtxtbx_snapshot_results.AppendText("\r\nPinging " + ip_address + " with 32 bytes of data");
            rchtxtbx_snapshot_results.ScrollToCaret();

            PingReply reply = pingSender.Send(ip_address);

            if (reply.Status == IPStatus.Success)
            {
                //txtbx_results.AppendText("\r\nResult = Success");
                //txtbx_results.AppendText("\r\nAddress: " + reply.Address);
                //txtbx_results.AppendText("\r\nRoundTrip time: " + reply.RoundtripTime);
                //txtbx_results.AppendText("\r\nTime to live: " + reply.Options.Ttl);
                //txtbx_results.AppendText("\r\nDon't fragment: " + reply.Options.DontFragment);
                //txtbx_results.AppendText("\r\nBuffer size: " + reply.Buffer.Length + "\r\n");

                rchtxtbx_snapshot_results.AppendText("\r\nReply from " + reply.Address +
                                                     ": bytes=" + reply.Buffer.Length +
                                                     "  time =" + +reply.RoundtripTime + "ms" +
                                                     "  TTL=" + reply.Options.Ttl + "\r\n");
                rchtxtbx_snapshot_results.ScrollToCaret();

            }
            else
            {
                rchtxtbx_snapshot_results.AppendText("\r\nFailed due to " + reply.Status + "\r\n");
                rchtxtbx_snapshot_results.ScrollToCaret();

            }
        }

        private void btn_stop_capture_Click(object sender, EventArgs e)
        {
            btn_start_capture.Visible = true;
            btn_stop_capture.Visible = false;
            tokenSource.Cancel(); // make the token a cancel token
        }

        private void btn_start_capture_Click(object sender, EventArgs e)
        {
            btn_start_capture.Visible = false;
            btn_stop_capture.Visible = true;
            StartCapture(picbx_image);
        }

        public void StartCapture(PictureBox myPictureBox)
        {
            // WriteUIData("Sequence Started @ " + DateTime.Now, mySequenceStartedLabel);

            tokenSource = new CancellationTokenSource();    //Make a new instance
            Task.Run(() => RunSequence(tokenSource.Token, myPictureBox)); //Run the task that we need to stop
        }

        private async void RunSequence(CancellationToken _ct, PictureBox myPictureBox)
        {
            int counter = 1;
            string camera_ip_address = txtbx_camera_ip_address.Text;
            string url = "http://" + camera_ip_address + "/Snapshot/1/RemoteImageCapture?ImageFormat=2";
            string username = txtbx_username.Text;
            string password = txtbx_password.Text;

            while (!_ct.IsCancellationRequested)
            {
                GC.Collect(); //clean orphaned memory
                try
                {
                    // Create the request
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(username, password);

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

                    using (Stream stream = response.GetResponseStream())
                    {
                        string fileName = $"snapshot_{DateTime.Now:ddMMyyyy_HHmmss}_{counter++}.jpg";
                        using (FileStream fs = new FileStream(fileName, FileMode.Create))
                        {
                            stream.CopyTo(fs);
                        }

                        await Task.Delay(30000, _ct); //waits 30 seconds

                        FileInfo info = new FileInfo(fileName); //create the file info object

                        rchtxtbx_snapshot_results.AppendText($"\r\nSaved {fileName}" + "\r\nFilesize = " +
                                                             info.Length + " bytes");
                        rchtxtbx_snapshot_results.ScrollToCaret();

                        myPictureBox.Image = Image.FromFile(fileName);
                    }
                }
                catch (Exception ex)
                {
                    MsgBox.Show($"An error occurred: {ex.Message}", "Error_1", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                await Task.Delay(30000, _ct); //waits 30 seconds 

            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            browse.NavigateTo("http://" + txtbx_camera_ip_address.Text, webview_browser);
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
                    = btn_get_image.Visible = true;
            }
            else if (tabcntrl_main.SelectedTab == tab_web_browser)
            {
                btn_browse.Visible = true;
                btn_clear.Visible = btn_ping.Visible = btn_start_capture.Visible = btn_stop_capture.Visible
                    = btn_get_image.Visible = false;
            }

        }


    }
}





