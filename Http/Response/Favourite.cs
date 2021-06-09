using Newtonsoft.Json;
using System;

namespace picacomic_api.Http.Response
{
    public class Favourite
    {
        [JsonProperty("comics")]
        public Comics_Favourite Comics { get; set; }
    }
    public class Comics_Favourite
    {
        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("docs")]
        public Doc_Favourite[] Docs { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class Doc_Favourite
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("totalViews")]
        public long TotalViews { get; set; }

        [JsonProperty("totalLikes")]
        public long TotalLikes { get; set; }

        [JsonProperty("pagesCount")]
        public long PagesCount { get; set; }

        [JsonProperty("epsCount")]
        public long EpsCount { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        [JsonProperty("likesCount")]
        public long LikesCount { get; set; }
    }

    public class Thumb
    {
        [JsonProperty("fileServer")]
        public Uri FileServer { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("originalName")]
        public string OriginalName { get; set; }
    }
}
