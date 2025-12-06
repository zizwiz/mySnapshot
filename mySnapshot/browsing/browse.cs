using System.Windows.Forms;
using CenteredMessagebox;
using Microsoft.Web.WebView2.WinForms;

namespace mySnapshot.browsing
{
    class browse
    {
        public static void NavigateTo(string URL, WebView2 browser)
        {
            if (URL.Substring(0, 4) == "http")
            {
                if (browser != null && browser.CoreWebView2 != null)
                {
                    browser.CoreWebView2.Navigate(URL);
                }
            }
            else
            {
                MsgBox.Show("The URL needs to start with https://", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
