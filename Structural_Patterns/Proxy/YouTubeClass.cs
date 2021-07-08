using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Proxy
{
    class YouTubeClass : YouTubeLib
    {
        private const string URI = "https://www.googleapis.com/youtube/v3/videos?";
        // Weird! It doesn't work make it const...
        private string KEY = Environment.GetEnvironmentVariable("YouTube_KEY", EnvironmentVariableTarget.User);
        private HttpClient client = new HttpClient();
        public async Task<ListVideos> ListMPVideos()
        {
            string listParams = "part=snippet&chart=mostPopular&maxResults=10";
            string response = await client.GetStringAsync($"{URI}{listParams}{KEY}");
            ListVideos listVideos = JsonConvert.DeserializeObject<ListVideos>(response);

            return listVideos;
        }

        public async Task<Video> GetVideoInfo(string id)
        {
            string infoParams = "part=statistics,snippet&id=";
            string response = await client.GetStringAsync($"{URI}{infoParams}{id}{KEY}");
            ListVideos video = JsonConvert.DeserializeObject<ListVideos>(response);

            return video.items[0];
        }

        public async Task<string> DownloadVideo(string id)
        {
            // Mocking a video download.
            await Task.Delay(3500);
            return id;
        }
    }
}
