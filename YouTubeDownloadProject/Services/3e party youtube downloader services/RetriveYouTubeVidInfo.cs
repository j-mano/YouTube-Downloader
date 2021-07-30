using System;
using System.Threading.Tasks;
using YouTubeDownloadProject.Model;
using YoutubeExplode;

namespace YouTubeDownloadProject.Services
{
    public class RetriveYouTubeVidInfo
    {
        public static async Task<VidInfoModell> getYoutubeVidAsync(String youtubelink)
        {
            VidInfoModell returninfo = new VidInfoModell();
            returninfo.VidLink = youtubelink;

            try
            {
                // Loadup default values
                var youtube = new YoutubeClient();
                var video   = await youtube.Videos.GetAsync(returninfo.VidLink);

                // Creating model of info
                returninfo.Author       = video.Author.Title;
                returninfo.Description  = video.Description;
                returninfo.Duration     = video.Duration.Value;
                returninfo.VidTitle     = video.Title;
                returninfo.id           = video.Id;
                returninfo.thumb        = video.Thumbnails[0];
            }
            catch
            {
                returninfo.VidTitle = "No Title Found.";
            }

            return returninfo;
        }

        public static string getYouTubeThumbnail(string YoutubeUrl)
        {
            string youTubeThumb = string.Empty;
            if (YoutubeUrl == "")
                return "";

            if (YoutubeUrl.IndexOf("=") > 0)
            {
                youTubeThumb = YoutubeUrl.Split('=')[1];
            }
            else if (YoutubeUrl.IndexOf("/v/") > 0)
            {
                string strVideoCode = YoutubeUrl.Substring(YoutubeUrl.IndexOf("/v/") + 3);
                int ind = strVideoCode.IndexOf("?");
                youTubeThumb = strVideoCode.Substring(0, ind == -1 ? strVideoCode.Length : ind);
            }
            else if (YoutubeUrl.IndexOf('/') < 6)
            {
                youTubeThumb = YoutubeUrl.Split('/')[3];
            }
            else if (YoutubeUrl.IndexOf('/') > 6)
            {
                youTubeThumb = YoutubeUrl.Split('/')[1];
            }

            return "http://img.youtube.com/vi/" + youTubeThumb + "/mqdefault.jpg";
        }
    }
}
