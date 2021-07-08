using System;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {   
        static async Task Main(string[] args)
        {
            YouTubeLib yt = new YouTubeClass();
            CachedYouTubeClass ytCache = new CachedYouTubeClass(yt);
            Video video = await ytCache.GetVideoInfo("hDutil3u-Ow");
            ListVideos lv = await ytCache.ListMPVideos();
            foreach (Video v in lv.items)
            {
                Console.WriteLine(v.snippet.title);
            }
            Console.WriteLine($"Título: {video.snippet.title}\nDescripción: {video.snippet.description}\n" +
                $"No de vistas: {video.statistics.viewCount}\nNo. likes: {video.statistics.likeCount}\n" +
                $"No. Dislikes: {video.statistics.dislikeCount}"
            );
            // Maybe this should need a real wrapper! Could it be Decorator pattern?
            ytCache.Reset();
            Video video2 = await ytCache.GetVideoInfo("WZQc7RUAg18");
            ytCache.AvoidReset();

            Console.WriteLine($"Título: {video2.snippet.title}\nDescripción: {video2.snippet.description}\n" +
                $"No de vistas: {video2.statistics.viewCount}\nNo. likes: {video2.statistics.likeCount}\n" +
                $"No. Dislikes: {video2.statistics.dislikeCount}"
            );
            Console.WriteLine(await ytCache.DownloadVideo("hDutil3u-Ow"));
            Console.WriteLine(await ytCache.DownloadVideo("hDutil3u-Ow"));
            Console.WriteLine(await ytCache.DownloadVideo("hDutil3u-Ow"));
        }
    }
}
