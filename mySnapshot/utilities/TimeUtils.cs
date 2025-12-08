using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySnapshot.utilities
{
    class TimeUtils
    {

        public static async Task SetTime(RichTextBox myRichTextBox, string myCameraIP, string myUsername, string myPassword)
        {
            
            // Build Basic Auth header
            var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{myUsername}:{myPassword}"));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"http://{myCameraIP}/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

                // Format current PC time as YYYYMMDDThhmmss
                string systemTime = DateTime.Now.ToString("yyyyMMdd'T'HHmmss");

                // Build XML payload
                string xmlPayload = $@"<?xml version=""1.0"" encoding=""UTF-8""?>
                                        <Time Version=""1.0"">
                                            <DateTimeFormat>DDMMYYYYWhhmmss</DateTimeFormat>
                                            <TimeFormat>24hour</TimeFormat>
                                            <SystemTime>{systemTime}</SystemTime>
                                            <SyncNTPFlag>NoSync</SyncNTPFlag>
                                        </Time>";

                var content = new StringContent(xmlPayload, Encoding.UTF8, "application/xml");

                // POST or PUT depending on camera API (try PUT first)
                HttpResponseMessage response = await client.PutAsync("System/Time", content);

                if (response.IsSuccessStatusCode)
                {
                    myRichTextBox.AppendText("\r\nTime sync successfull");
                    string resp = await response.Content.ReadAsStringAsync();
                    myRichTextBox.AppendText("\r\n" + resp);
                }
                else
                {
                    myRichTextBox.AppendText($"\r\nFailed to sync time. Status: {response.StatusCode}");
                    string resp = await response.Content.ReadAsStringAsync();
                    myRichTextBox.AppendText("\r\n" + resp);
                }
            }
        }
    }
}
