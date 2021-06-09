using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacomic_api.Http.Response
{
    public class GetCollections
    {
        [JsonProperty("collections")]
        public Collection[] Collection { get; set; }
    }
    public class Collection
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("comics")]
        public Comic_Collections[] Comics { get; set; }
    }

    public class Comic_Collections
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
    }
}
