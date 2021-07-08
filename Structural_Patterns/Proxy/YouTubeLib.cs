using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Proxy
{
    interface YouTubeLib
    {
        Task<ListVideos> ListMPVideos();
        Task<Video> GetVideoInfo(string id);
        Task<string> DownloadVideo(string id);
    }
}
