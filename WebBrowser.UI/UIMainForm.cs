using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class UIMainForm : Form
    {
        public UIMainForm()
        {
            InitializeComponent();
        }

        // Reference for this project:
        // https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-add-web-browser-capabilities-to-a-windows-forms-application



        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the web browser project for CPSC 2713"
                + "\nWritten by Zachary Long zzl0100"
                + "\n\nI hope it works!"
                
                );
        }



        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var accessAddressBox = new BrowserUserControl();
                Navigate(accessAddressBox.addressTextBox.Text);
            }
        }

        //https://docs.microsoft.com/en-us/dotnte/api/system.windows.forms.webbrowser?view=netframework-4.7.2

        private void goButton_Click(object sender, EventArgs e)
        {
            //clicking this button will perform the same behavior as when you press the Enter key
            //load the new address in the web browser
            var goButtonAccess = new BrowserUserControl();
            Navigate(goButtonAccess.addressTextBox.Text);
        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                    !address.StartsWith("https://")) {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void webBrowser1_Navigated(object sender,
            WebBrowserNavigatedEventArgs e)
        {
            var navigatedAccess = new BrowserUserControl();
            navigatedAccess.addressTextBox.Text = webBrowser1.Url.ToString();
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
