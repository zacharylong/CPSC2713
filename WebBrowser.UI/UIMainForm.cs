﻿using System;
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
            var tabAdd = new BrowserUserControl();
            tabAdd.tabControl1.TabPages.Add(new TabPage("New Tab"));
        }

        private void BrowserUserControl_KeyDown(object sender, KeyEventArgs e)
        {
            var keyAccess = new BrowserUserControl();

            if (e.Control && (e.KeyCode == Keys.T))
            {

                keyAccess.tabControl1.TabPages.Add(new TabPage("new Tab"));
            }

            if (e.Control && (e.KeyCode == Keys.W))
                keyAccess.tabControl1.TabPages.RemoveAt(keyAccess.tabControl1.SelectedIndex);
        }

        private void browserUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
