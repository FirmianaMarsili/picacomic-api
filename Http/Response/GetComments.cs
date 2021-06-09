using Newtonsoft.Json;
using System;

namespace picacomic_api.Http.Response
{
    public class GetComments
    {
        [JsonProperty("comments")]
        public Comments_GetComments Comment { get; set; }

        [JsonProperty("topComments")]
        public TopComment[] TopComments { get; set; }
    }
    public class Comments_GetComments
    {
        [JsonProperty("docs")]
        public Doc_GetComments[] Docs { get; set; }

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

    public class Doc_GetComments
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("_user")]
        public User_GetComments User { get; set; }

        [JsonProperty("_comic")]
        public string Comic { get; set; }

        [JsonProperty("isTop")]
        public bool IsTop { get; set; }

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

    public class User_GetComments
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("gender")]
        public picacg.PicacomicUrl.gender Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("exp")]
        public long Exp { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("characters")]
        public object[] Characters { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("avatar")]
        public Thumb Avatar { get; set; }

        [JsonProperty("slogan", NullValueHandling = NullValueHandling.Ignore)]
        public string Slogan { get; set; }

        [JsonProperty("character", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Character { get; set; }
    }

    public partial class TopComment
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("_user")]
        public User User { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("_comic")]
        public string Comic { get; set; }

        [JsonProperty("isTop")]
        public bool IsTop { get; set; }

        [JsonProperty("hide")]
        public bool Hide { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("likesCount")]
        public long LikesCount { get; set; }

        [JsonProperty("commentsCount")]
        public long CommentsCount { get; set; }

        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }
    }
}
