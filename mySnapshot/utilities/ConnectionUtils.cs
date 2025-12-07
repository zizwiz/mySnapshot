using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace mySnapshot.utilities
{
    class ConnectionUtils
    {
        public static void PingCamera(string myIPAddress, RichTextBox myRichTextBox)
        {
            Ping pingSender = new Ping();

            myRichTextBox.AppendText("\r\nPinging " + myIPAddress + " with 32 bytes of data");
            myRichTextBox.ScrollToCaret();

            PingReply reply = pingSender.Send(myIPAddress);

            if (reply.Status == IPStatus.Success)
            {
                myRichTextBox.AppendText("\r\nReply from " + reply.Address +
                                         ": bytes=" + reply.Buffer.Length +
                                         "  time =" + +reply.RoundtripTime + "ms" +
                                         "  TTL=" + reply.Options.Ttl + "\r\n");

                myRichTextBox.ScrollToCaret();
            }
            else
            {
                myRichTextBox.AppendText("\r\nFailed due to " + reply.Status + "\r\n");
                myRichTextBox.ScrollToCaret();
            }
        }

        public static void FindCameraIPAddress(RichTextBox myRichTextBox)
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

            myRichTextBox.AppendText("\r\nProbe sent. Listening for responses...");
            myRichTextBox.ScrollToCaret();

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

                            myRichTextBox.Text = input.Substring(secondSlash + 1, colonIndex - (secondSlash + 1));
                        }
                        catch (Exception ex)
                        {
                            myRichTextBox.AppendText($"\r\nError: {ex.Message}");
                            myRichTextBox.ScrollToCaret();
                        }

                        // txtbx_results.AppendText("\r\nCamera Service Address = " + xAddrsNode.InnerText);
                        flag = false;
                        return;
                    }

                }
            }
            catch (SocketException)
            {
                myRichTextBox.AppendText("\r\nListening finished (timeout). Please try again.");
                myRichTextBox.ScrollToCaret();
            }
        }
    }
}
