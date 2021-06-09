using Newtonsoft.Json;
using System;

namespace picacomic_api.Http.Response
{
    public class GetComicsBookEps
    {
        [JsonProperty("eps")]
        public Eps Eps { get; set; }
    }
    public class Eps
    {
        [JsonProperty("docs")]
        public Doc_ComicsBookEps[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class Doc_ComicsBookEps
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("id")]
        public string DocId { get; set; }
    }

}
