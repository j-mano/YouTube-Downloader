﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouTubeDownloadProject.Model;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;

namespace YouTubeDownloadProject.Services
{
    public class DownloadYouTubeVid
    {
        // Youtube Download api:
        // https://github.com/Tyrrrz/YoutubeExplode

        /// <summary>
        /// Download 720/30 fps as maximum or highest resolution by uploader.
        /// </summary>
        /// <param name="VidToDownload"></param>
        /// <returns></returns>

        public static async Task DownloadYouTubeVidFunction(VidInfoModell VidToDownload)
        {
            var youtube = new YoutubeClient();

            try
            {
                Console.WriteLine("Start Downloading");
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(VidToDownload.id);

                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                // Download the stream to a file. Local aplication folder.
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            }
            catch
            {
                Console.WriteLine("Error while downloading");
            }
            /*
             * Note that while it may be tempting to just always use muxed streams, given that they contain both audio and video,
             * it's important to note that they are limited in quality and don't go beyond 720p30.
             * If you want to download the video in maximum quality, you need to download the audio-only and video-only streams separately and then mux them together on your own using tools like FFmpeg.
             * You can also use YoutubeExplode.Converter which wraps FFmpeg and provides an extension point for YoutubeExplode to download videos directly.
             * https://github.com/Tyrrrz/YoutubeExplode.Converter
             */
        }
        /// <summary>
        /// Download highest posible video stream
        /// </summary>
        /// <param name="VidToDownload"></param>
        public static async void HighEndDownload(VidInfoModell VidToDownload)
        {
            var youtube = new YoutubeClient();

            try
            {
                // Get stream manifest
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(VidToDownload.id);

                // Select streams (GetWith Highest VideoQuality / highest bitrate audio)
                var audioStreamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();
                var videoStreamInfo = streamManifest.GetVideoStreams().GetWithHighestVideoQuality();
                var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };

                // Download and process them into one file
                await youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder("video.mp4").Build());
            }
            catch
            {

            }

        }
        /// <summary>
        /// Download video only
        /// </summary>
        /// <param name="VidToDownload"></param>
        /// <returns></returns>
        public static async Task DownloadYouTubeVidFunctionVideoOnly(VidInfoModell VidToDownload)
        {
            var youtube = new YoutubeClient();

            try
            {
                Console.WriteLine("Start Downloading");
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(VidToDownload.id);

                var streamInfo = streamManifest
                .GetVideoOnlyStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();

                // Download the stream to a file. Local aplication folder.
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            }
            catch
            {

            }
        }
        /// <summary>
        /// Download Audio only
        /// </summary>
        /// <param name="VidToDownload"></param>
        /// <returns></returns>
        public static async Task DownloadYouTubeVidFunctionAudioOnly(VidInfoModell VidToDownload)
        {
            var youtube = new YoutubeClient();

            try
            {
                Console.WriteLine("Start Downloading");
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(VidToDownload.id);

                var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                // Download the stream to a file. Local aplication folder.
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            }
            catch
            {

            }
        }
    }
}