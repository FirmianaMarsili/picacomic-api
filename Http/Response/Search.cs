using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacomic.Http.Response
{
    public class Search
    {
        [JsonProperty("comics")]
        public Comics_Search Comics { get; set; }
    }
    public class Comics_Search
    {
        [JsonProperty("docs")]
        public Doc_Search[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class Doc_Search
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

        [JsonProperty("id")]
        public string DocId { get; set; }

        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }
}
