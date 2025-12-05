using System.Windows.Forms;

namespace mySnapshot.utilities
{
    class myFormatter
    {
        /// <summary>
        /// Centers the Label or Textbox in its parent panel
        /// </summary>
        /// <param name="myPanel"></param>
        /// <param name="myLabel"></param>
        /// <param name="myTextBox"></param>
        public static void Centre(Panel myPanel, Label myLabel, TextBox myTextBox)
        {
            if (myLabel.Name != "lbl_null")
            {
                // Calculate centered position for label
                myLabel.Left = (myPanel.ClientSize.Width - myLabel.Width) / 2;
                myLabel.Top = (myPanel.ClientSize.Height - myLabel.Height) / 2;
            }
            else if(myTextBox.Name != "lbl_null")
            {
                // Calculate centered position for Textbox
                myTextBox.Left = (myPanel.ClientSize.Width - myTextBox.Width) / 2;
                myTextBox.Top = (myPanel.ClientSize.Height - myTextBox.Height) / 2;
            }
        }

    }
}
