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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addNewTab();
            //refactored this commend out to its own method to try to use for Ctrl-T as well.

            //tb.Controls.Add(buc);
            //var tabAdd = new BrowserUserControl();
            //tabAdd.tabControl1.TabPages.Add(new TabPage("New Tab"));
        }

        private void BrowserUserControl_KeyDown(object sender, KeyEventArgs e)
        {
            //var keyAccess = new BrowserUserControl();
            //mod4 lecture video code to add quick key functionality
            if (e.Control && (e.KeyCode == Keys.T))
            {

                this.tabControl1.TabPages.Add(new TabPage("new Tab"));
            }

            if (e.Control && (e.KeyCode == Keys.W))
                this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        private void browserUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close currently selected tab
            //var closeTab = new BrowserUserControl();

            //this.tabControl1.TabPages.RemoveAt(this.Focused);

            //remove tab functionality for menu item does not seem to work.
            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        //private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        private void UIMainFormControl_KeyDown(object sender, KeyEventArgs e)
        {
            //code from Module 4 lecture videos.
            if (e.Control && (e.KeyCode == Keys.T))
            {

                this.tabControl1.TabPages.Add(new TabPage("New Tab"));
            }

            //following the lecture videos.
            if (e.Control && (e.KeyCode == Keys.W))
                this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        public void addNewTab()
        {
            BrowserUserControl browserControl = new BrowserUserControl();
            browserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage("New Tab");
            myTabPage.Controls.Add(browserControl);
            this.tabControl1.TabPages.Add(myTabPage);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyManager = new History_Manager_Form();
            historyManager.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkManager = new Bookmark_Manager_Form();
            bookmarkManager.ShowDialog();
        }
    }
}

