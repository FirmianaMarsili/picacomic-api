

using Newtonsoft.Json;

namespace picacomic.Http.Response
{
    public class Rank
    {
        [JsonProperty("comics")]
        public Comic_Rank[] Comics { get; set; }
    }

    public class Comic_Rank
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("totalViews")]
        public int TotalViews { get; set; }

        [JsonProperty("totalLikes")]
        public int TotalLikes { get; set; }

        [JsonProperty("pagesCount")]
        public int PagesCount { get; set; }

        [JsonProperty("epsCount")]
        public int EpsCount { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        [JsonProperty("viewsCount")]
        public int ViewsCount { get; set; }

        [JsonProperty("leaderboardCount")]
        public int LeaderboardCount { get; set; }
    }
}
