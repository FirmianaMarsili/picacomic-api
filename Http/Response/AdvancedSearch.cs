

using Newtonsoft.Json;
using System;

namespace picacomic_api.Http.Response
{
    public class AdvancedSearch
    {
        [JsonProperty("comics")]
        public Comics_AdvancedSearch Comics { get; set; }
    }
    public partial class Comics_AdvancedSearch
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("docs")]
        public Doc_AdvancedSearch[] Docs { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class Doc_AdvancedSearch
    {
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("chineseTeam", NullValueHandling = NullValueHandling.Ignore)]
        public string ChineseTeam { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("finished")]
        public int Finished { get; set; }

        [JsonProperty("totalViews")]
        public int TotalViews { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("totalLikes")]
        public int TotalLikes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }
}
