using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace picacomic_api.Http.Response
{
    public class MyComments
    {
        [JsonProperty("comments")]
        public Comments Comments { get; set; }
    }
    public class Comments
    {
        [JsonProperty("docs")]
        public List<Doc> Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("page")]
        [JsonConverter(typeof(ParseStringConverter))]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class Doc
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("_comic")]
        public Comic Comic { get; set; }

        [JsonProperty("hide")]
        public bool Hide { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("id")]
        public string DocId { get; set; }

        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }

        [JsonProperty("commentsCount")]
        public int CommentsCount { get; set; }

        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }
    }

    public class Comic
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
