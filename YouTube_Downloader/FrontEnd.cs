using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                SelectedVidInfo = await RetriveYouTubeVidInfo.getYoutubeVidAsync(GetEntertYoutubeLink());
                printOutInfo();
            }
            catch
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
    }
}
