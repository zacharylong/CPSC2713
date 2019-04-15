using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Net.Http;

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
            webBrowser1.CanGoBackChanged +=
                new EventHandler(webBrowser1_CanGoBackChanged);
            webBrowser1.CanGoForwardChanged +=
                new EventHandler(webBrowser1_CanGoForwardChanged);
            webBrowser1.DocumentTitleChanged +=
                new EventHandler(webBrowser1_DocumentTitleChanged);
            webBrowser1.StatusTextChanged +=
                new EventHandler(webBrowser1_StatusTextChanged);
        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("Enter key pressed");
                Navigate(addressTextBox.Text);
            }
        }

        private void webBrowser1_Navigated(object sender, 
            WebBrowserNavigatedEventArgs e)
        {
            
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            backButton.Enabled = webBrowser1.CanGoBack;
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            forwardButton.Enabled = webBrowser1.CanGoForward;
        }

        private void webBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
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

        //private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        //webBrowser1.Navigate(addressTextBox.Text);
        //        //Navigate(addressTextBox.Text);
        //        goButton_Click_1(null, null);
        //    }
        //}

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

        //private void webBrowser1_Navigated(object sender,
        //    WebBrowserNavigatedEventArgs e)
        //{
        //    addressTextBox.Text = webBrowser1.Url.ToString();
        //    //addressTextBox.Text = Url;
        //}

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

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void forwardButton_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            //toolstrip for status label updates here from dotnet tutorial
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            //url and title of current page added to the bookmark table in the database
            //use bookmark manager
            string title = ((HtmlDocument)webBrowser1.Document).Title;
            var item = new BookmarkItem();
            item.Title = title;
            item.URL = webBrowser1.Document.Url.ToString();

            BookmarkManager.AddItem(item);
        }

        private void webBrowser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            //addressTextBox.Text = webBrowser1.Url.ToString();
            //addressTextBox.Text = webBrowser1.Document.Url.ToString();
            if (addressTextBox.Text != e.Url.ToString())
            {
                addressTextBox.Text = e.Url.ToString();
            }

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string title = ((HtmlDocument)webBrowser1.Document).Title;
            var item = new HistoryItem();
            item.Title = title;
            item.URL = webBrowser1.Document.Url.ToString();
            item.Date = DateTime.Now;

            HistoryManager.AddItem(item);
        }

        private void addressTextBox_Click_2(object sender, EventArgs e)
        {
            addressTextBox.SelectionStart = 0;
            addressTextBox.SelectionLength = addressTextBox.Text.Length;
        }
    }
}
