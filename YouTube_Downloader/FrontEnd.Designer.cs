
namespace YouTube_Downloader
{
    partial class FrontEnd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontEnd));
            this.Retrive_Inmfio_BTN = new System.Windows.Forms.Button();
            this.VideoTitle_LBL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Description_LBL = new System.Windows.Forms.Label();
            this.YouTubbeLinkInput_Textbox = new System.Windows.Forms.TextBox();
            this.Download_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.Description_TextBox = new System.Windows.Forms.RichTextBox();
            this.DownloadProgressLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Retrive_Inmfio_BTN
            // 
            resources.ApplyResources(this.Retrive_Inmfio_BTN, "Retrive_Inmfio_BTN");
            this.Retrive_Inmfio_BTN.Name = "Retrive_Inmfio_BTN";
            this.Retrive_Inmfio_BTN.UseVisualStyleBackColor = true;
            this.Retrive_Inmfio_BTN.Click += new System.EventHandler(this.Retrive_Inmfio_BTN_Click);
            // 
            // VideoTitle_LBL
            // 
            resources.ApplyResources(this.VideoTitle_LBL, "VideoTitle_LBL");
            this.VideoTitle_LBL.Name = "VideoTitle_LBL";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Description_LBL
            // 
            resources.ApplyResources(this.Description_LBL, "Description_LBL");
            this.Description_LBL.Name = "Description_LBL";
            // 
            // YouTubbeLinkInput_Textbox
            // 
            resources.ApplyResources(this.YouTubbeLinkInput_Textbox, "YouTubbeLinkInput_Textbox");
            this.YouTubbeLinkInput_Textbox.Name = "YouTubbeLinkInput_Textbox";
            // 
            // Download_BTN
            // 
            resources.ApplyResources(this.Download_BTN, "Download_BTN");
            this.Download_BTN.Name = "Download_BTN";
            this.Download_BTN.UseVisualStyleBackColor = true;
            this.Download_BTN.Click += new System.EventHandler(this.Download_BTN_Click);
            // 
            // Exit_BTN
            // 
            resources.ApplyResources(this.Exit_BTN, "Exit_BTN");
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // Description_TextBox
            // 
            resources.ApplyResources(this.Description_TextBox, "Description_TextBox");
            this.Description_TextBox.Name = "Description_TextBox";
            // 
            // DownloadProgressLBL
            // 
            resources.ApplyResources(this.DownloadProgressLBL, "DownloadProgressLBL");
            this.DownloadProgressLBL.Name = "DownloadProgressLBL";
            // 
            // FrontEnd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DownloadProgressLBL);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Download_BTN);
            this.Controls.Add(this.YouTubbeLinkInput_Textbox);
            this.Controls.Add(this.Description_LBL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VideoTitle_LBL);
            this.Controls.Add(this.Retrive_Inmfio_BTN);
            this.Name = "FrontEnd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Retrive_Inmfio_BTN;
        private System.Windows.Forms.Label VideoTitle_LBL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Description_LBL;
        private System.Windows.Forms.TextBox YouTubbeLinkInput_Textbox;
        private System.Windows.Forms.Button Download_BTN;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.RichTextBox Description_TextBox;
        private System.Windows.Forms.Label DownloadProgressLBL;
    }
}

