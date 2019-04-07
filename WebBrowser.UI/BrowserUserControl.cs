using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class BrowserUserControl : UserControl
    {
        String Url = string.Empty;
        public BrowserUserControl()
        {
            InitializeComponent();
            Url = "http://www.auburn.edu";
            myBrowser();

        }

        private void webBrowser1_Load(object sender, EventArgs e)
        {
            backButton.Enabled = false;
            forwardButton.Enabled = false;
        }

        private void myBrowser()
        {
            if (addressTextBox.Text != "")
            {
                Url = addressTextBox.Text;
            }
            webBrowser1.Navigate(Url);
            //webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webpage_Navigated);
            //webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webpage_DocumentCompleted);
        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //webBrowser1.Navigate(addressTextBox.Text);
                //Navigate(addressTextBox.Text);
                goButton_Click_1(null, null);
            }
        }

        //https://docs.microsoft.com/en-us/dotnte/api/system.windows.forms.webbrowser?view=netframework-4.7.2

        //private void goButton_Click(object sender, EventArgs e)
        //{
        //    //clicking this button will perform the same behavior as when you press the Enter key
        //    //load the new address in the web browser
        //    //string webPage = addressTextBox.Text.Trim();
        //    //Navigate(addressTextBox.Text);
        //    //webBrowser1.Navigate(webPage);
        //    myBrowser();
        //}

        //Diable Old Mod3 Navigate for Mod4
        //private void Navigate(String address)
        //{
        //    if (String.IsNullOrEmpty(address)) return;
        //    if (address.Equals("about:blank")) return;
        //    if (!address.StartsWith("http://") &&
        //            !address.StartsWith("https://"))
        //    {
        //        address = "http://" + address;
        //    }
        //    try
        //    {
        //        webBrowser1.Navigate(new Uri(address));
        //    }
        //    catch (System.UriFormatException)
        //    {
        //        return;
        //    }
        //}

        private void webBrowser1_Navigated(object sender,
            WebBrowserNavigatedEventArgs e)
        {
            addressTextBox.Text = webBrowser1.Url.ToString();
            //addressTextBox.Text = Url;
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void goButton_Click_1(object sender, EventArgs e)
        {
            myBrowser();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                backButton.Enabled = true;
            }
            else backButton.Enabled = false;

            if (webBrowser1.CanGoForward)
            {
                forwardButton.Enabled = true;
            }
            else forwardButton.Enabled = false;
        }

        private void addressTextBox_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BrowserUserControl_KeyDown(object sender, KeyEventArgs e)
        {
            //var keyAccess = new BrowserUserControl();


        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Navigate (String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") && 
                !address.StartsWith("https://"))
            {
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

        private void goButton_Click(object sender, EventArgs e)
        {
            Navigate(addressTextBox.Text);
        }
    }
}
