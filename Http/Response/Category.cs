

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace picacomic_api.Http.Response
{
    public class Categories
    {
        [JsonProperty("categories")]
        public List<Category> Categorie { get; set; }
    }
    public class Category
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        [JsonProperty("isWeb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWeb { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Link { get; set; }

        [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public class Thumb
    {
        [JsonProperty("originalName")]
        public string OriginalName { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("fileServer")]
        public Uri FileServer { get; set; }
    }
}
