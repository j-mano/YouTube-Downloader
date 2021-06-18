
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
            this.Retrive_Inmfio_BTN.Location = new System.Drawing.Point(509, 10);
            this.Retrive_Inmfio_BTN.Name = "Retrive_Inmfio_BTN";
            this.Retrive_Inmfio_BTN.Size = new System.Drawing.Size(75, 23);
            this.Retrive_Inmfio_BTN.TabIndex = 0;
            this.Retrive_Inmfio_BTN.Text = "Retrive Info";
            this.Retrive_Inmfio_BTN.UseVisualStyleBackColor = true;
            this.Retrive_Inmfio_BTN.Click += new System.EventHandler(this.Retrive_Inmfio_BTN_Click);
            // 
            // VideoTitle_LBL
            // 
            this.VideoTitle_LBL.AutoSize = true;
            this.VideoTitle_LBL.Location = new System.Drawing.Point(12, 50);
            this.VideoTitle_LBL.Name = "VideoTitle_LBL";
            this.VideoTitle_LBL.Size = new System.Drawing.Size(59, 15);
            this.VideoTitle_LBL.TabIndex = 1;
            this.VideoTitle_LBL.Text = "VideoTitle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 301);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Description_LBL
            // 
            this.Description_LBL.AutoSize = true;
            this.Description_LBL.Location = new System.Drawing.Point(12, 372);
            this.Description_LBL.Name = "Description_LBL";
            this.Description_LBL.Size = new System.Drawing.Size(67, 15);
            this.Description_LBL.TabIndex = 3;
            this.Description_LBL.Text = "Description";
            // 
            // YouTubbeLinkInput_Textbox
            // 
            this.YouTubbeLinkInput_Textbox.Location = new System.Drawing.Point(12, 11);
            this.YouTubbeLinkInput_Textbox.Name = "YouTubbeLinkInput_Textbox";
            this.YouTubbeLinkInput_Textbox.Size = new System.Drawing.Size(491, 23);
            this.YouTubbeLinkInput_Textbox.TabIndex = 4;
            // 
            // Download_BTN
            // 
            this.Download_BTN.Location = new System.Drawing.Point(509, 390);
            this.Download_BTN.Name = "Download_BTN";
            this.Download_BTN.Size = new System.Drawing.Size(75, 23);
            this.Download_BTN.TabIndex = 5;
            this.Download_BTN.Text = "Download Video";
            this.Download_BTN.UseVisualStyleBackColor = true;
            this.Download_BTN.Click += new System.EventHandler(this.Download_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.Location = new System.Drawing.Point(509, 584);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(75, 23);
            this.Exit_BTN.TabIndex = 6;
            this.Exit_BTN.Text = "Exit";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.Location = new System.Drawing.Point(12, 390);
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(491, 217);
            this.Description_TextBox.TabIndex = 9;
            this.Description_TextBox.Text = "";
            // 
            // DownloadProgressLBL
            // 
            this.DownloadProgressLBL.AutoSize = true;
            this.DownloadProgressLBL.Location = new System.Drawing.Point(394, 372);
            this.DownloadProgressLBL.Name = "DownloadProgressLBL";
            this.DownloadProgressLBL.Size = new System.Drawing.Size(109, 15);
            this.DownloadProgressLBL.TabIndex = 10;
            this.DownloadProgressLBL.Text = "Download Progress";
            // 
            // FrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 619);
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
            this.Text = "Youtube Downloader";
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

