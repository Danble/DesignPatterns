using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CachedYouTubeClass : YouTubeLib
    {
        private YouTubeLib service;
        private ListVideos listCache;
        private Video videoCache;
        private string downloadedVideo;
        bool needReset;

        public CachedYouTubeClass(YouTubeLib s) { service = s; }
        public async Task<ListVideos> ListMPVideos()
        {
            if(listCache == null || needReset)
            {
                listCache = await service.ListMPVideos();
            }
            return listCache;
        }
        public async Task<Video> GetVideoInfo(string id)
        {
            if(videoCache == null || needReset)
            {
                videoCache = await service.GetVideoInfo(id);
            }
            return videoCache;
        }
        public async Task<string> DownloadVideo(string id)
        {
            if(downloadedVideo == null || needReset)
            {
                downloadedVideo = await service.DownloadVideo(id);
            }
            return downloadedVideo;
        }
        public void Reset() { needReset = true; }
        public void AvoidReset() { needReset = false; }
    }
}
