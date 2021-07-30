using System;
using System.Net;
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

                string imageName = DownloadImageFromUrl(SelectedVidInfo.thumb.Url);

                pictureBox1.ImageLocation = imageName;

                printOutInfo();
            }
            catch(Exception er)
            {
                Console.WriteLine("Error, Retriving information about youtube vid." + er);
                YouTubbeLinkInput_Textbox.Text = "Error, Retriving information about youtube vid. Write in a new one";
                Description_TextBox.Text = er.ToString();
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
            catch(Exception er)
            {
                Console.WriteLine("Error, Downloading youtube vid." + er);
                YouTubbeLinkInput_Textbox.Text = "Error, Downloading youtube vid. Try Again";
                Description_TextBox.Text = er.ToString();
            }
        }

        // Printout to gui
        private void printOutInfo()
        {
            Description_TextBox.Text = "Duration: " + SelectedVidInfo.Duration + "\n" + "Description: " + "\n" + SelectedVidInfo.Description ;
            VideoTitle_LBL.Text = "Title of the clip: " + SelectedVidInfo.VidTitle;
        }

        public string DownloadImageFromUrl(string imageUrl)
        {
            string imageName = @"Thumbnail.png";

            using (WebClient client4 = new WebClient())
            {
                client4.DownloadFile(new Uri(imageUrl), @"Thumbnail.WebP");
            }

            using (var image = Aspose.Imaging.Image.Load(@"Thumbnail.WebP"))
            {
                var options = new Aspose.Imaging.ImageOptions.PngOptions();
                image.Save(imageName, options);
            }

            return imageName;
        }
    }
}
