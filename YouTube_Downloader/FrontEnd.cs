using AngleSharp;
using MySql.Data.MySqlClient.Memcached;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
using YouTubeDownloadProject.Model;
using YouTubeDownloadProject.Services;

namespace YouTube_Downloader
{
    public partial class FrontEnd : Form
    {
        VidInfoModell SelectedVidInfo = new VidInfoModell();

        public FrontEnd()
        {
            InitializeComponent();
        }

        // Buttons
        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Retrive_Inmfio_BTN_Click(object sender, EventArgs e)
        {
            getYoutubeInfo();
        }

        private void Download_BTN_Click(object sender, EventArgs e)
        {
            DownloadVideo();
        }

        // Retrive info from frontend.
        private string GetEntertYoutubeLink()
        {
            return YouTubbeLinkInput_Textbox.Text;
        }

        // Api calls
        private async void getYoutubeInfo()
        {
            WebClient client = new WebClient();

            try
            {
                SelectedVidInfo = await RetriveYouTubeVidInfo.getYoutubeVidAsync(GetEntertYoutubeLink());

                pictureBox1.ImageLocation = SelectedVidInfo.thumb.Url.Trim();

                printOutInfo();
            }
            catch(Exception er)
            {
                Console.WriteLine("Error, Retriving information about youtube vid.");
                YouTubbeLinkInput_Textbox.Text = "Error, Retriving information about youtube vid. Write in a new one";
            }
        }

        private async void DownloadVideo()
        {
            try
            {
                DownloadProgressLBL.Text = "Downloading";
                await DownloadYouTubeVid.DownloadYouTubeVidFunction(SelectedVidInfo);
                DownloadProgressLBL.Text = "Downloaded to Aplication Folder";
            }
            catch
            {
                Console.WriteLine("Error, Downloading youtube vid.");
                YouTubbeLinkInput_Textbox.Text = "Error, Downloading youtube vid. Try Again";
            }
        }

        // Printout to gui
        private void printOutInfo()
        {
            Description_TextBox.Text = "Duration: " + SelectedVidInfo.Duration + "\n" + "Description: " + "\n" + SelectedVidInfo.Description ;
            VideoTitle_LBL.Text = "Title of the clip: " + SelectedVidInfo.VidTitle;
        }

        public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
        {
            System.Drawing.Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return image;
        }
    }
}
