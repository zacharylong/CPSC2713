namespace WebBrowser.UI
{
    partial class Bookmark_Manager_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxBookmark = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxBookmark
            // 
            this.listBoxBookmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBookmark.FormattingEnabled = true;
            this.listBoxBookmark.Location = new System.Drawing.Point(0, 0);
            this.listBoxBookmark.Name = "listBoxBookmark";
            this.listBoxBookmark.Size = new System.Drawing.Size(800, 450);
            this.listBoxBookmark.TabIndex = 0;
            // 
            // Bookmark_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxBookmark);
            this.Name = "Bookmark_Manager_Form";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.Bookmark_Manager_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookmark;
    }
}