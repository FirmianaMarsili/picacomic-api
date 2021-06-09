using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacomic.Http.Response
{
    public   class GetComicsBookOrder
    {
        [JsonProperty("pages")]
        public Pages Pages { get; set; }

        [JsonProperty("ep")]
        public Ep Ep { get; set; }
    }
    public class Ep
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Pages
    {
        [JsonProperty("docs")]
        public Doc_ComicsBookOrder[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int PagesPages { get; set; }
    }

    public class Doc_ComicsBookOrder
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("media")]
        public Thumb Media { get; set; }

        [JsonProperty("id")]
        public string DocId { get; set; }
    }
   
}
