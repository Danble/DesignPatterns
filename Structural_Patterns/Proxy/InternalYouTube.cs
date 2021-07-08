using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    // Internal classes for parsing JSON YouTube Objects
    public class ListVideos
    {
        public List<Video> items { get; set; }
        public Info pageInfo { get; set; }
    }

    public class Info
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class Video
    {
        public string id { get; set; }
        public Snippet snippet { get; set; }
        public Statistics statistics { get; set; }
    }

    public class Snippet
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Statistics
    {
        public string viewCount { get; set; }
        public string likeCount { get; set; }
        public string dislikeCount { get; set; }
    }
}
