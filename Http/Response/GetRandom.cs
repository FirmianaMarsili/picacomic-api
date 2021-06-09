using Newtonsoft.Json;
using System;

namespace picacomic_api.Http.Response
{
    public class GetRandom
    {
        [JsonProperty("comics")]
        public Comic_Random[] Comics { get; set; }
    }
    public class Comic_Random
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("epsCount")]
        public int EpsCount { get; set; }

        [JsonProperty("pagesCount")]
        public int PagesCount { get; set; }

        [JsonProperty("totalViews")]
        public int TotalViews { get; set; }

        [JsonProperty("totalLikes")]
        public int TotalLikes { get; set; }

        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }
}
