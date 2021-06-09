using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacomic_api.Http.Response
{
   public  class GetComicsBook
    {
        [JsonProperty("comic")]
        public Comic_ComicsBook Comic { get; set; }
    }
    public class Comic_ComicsBook
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_creator")]
        public Creator Creator { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("chineseTeam")]
        public string ChineseTeam { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("pagesCount")]
        public int PagesCount { get; set; }

        [JsonProperty("epsCount")]
        public int EpsCount { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("allowDownload")]
        public bool AllowDownload { get; set; }

        [JsonProperty("allowComment")]
        public bool AllowComment { get; set; }

        [JsonProperty("totalLikes")]
        public int TotalLikes { get; set; }

        [JsonProperty("totalViews")]
        public int TotalViews { get; set; }

        [JsonProperty("viewsCount")]
        public int ViewsCount { get; set; }

        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }

        [JsonProperty("isFavourite")]
        public bool IsFavourite { get; set; }

        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }

        [JsonProperty("commentsCount")]
        public int CommentsCount { get; set; }
    }

    public class Creator
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("exp")]
        public int Exp { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("characters")]
        public string[] Characters { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("avatar")]
        public Thumb Avatar { get; set; }

        [JsonProperty("slogan")]
        public string Slogan { get; set; }

        [JsonProperty("character")]
        public Uri Character { get; set; }
    }
}
