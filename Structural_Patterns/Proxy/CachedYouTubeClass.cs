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
        private float listRequestedDate = 0;
        private float timeFoNewList = 7;

        public CachedYouTubeClass(YouTubeLib s) { service = s; }
        public async Task<ListVideos> ListMPVideos()
        {
            float now = (float)DateTime.Today.ToOADate();

            if (listCache == null && (now - listRequestedDate) >= timeFoNewList) //Requested again if a week has passed.
            {
                listCache = await service.ListMPVideos();
                listRequestedDate = now;
            }
            return listCache;
        }
        public async Task<Video> GetVideoInfo(string id)
        {
            if(videoCache == null || videoCache.id != id)
            {
                videoCache = await service.GetVideoInfo(id);
            }
            return videoCache;
        }
        public async Task<string> DownloadVideo(string id)
        {
            if(downloadedVideo == null || downloadedVideo != id)
            {
                downloadedVideo = await service.DownloadVideo(id);
            }
            return $"This is your downloaded video with id: {downloadedVideo}.";
        }
    }
}
