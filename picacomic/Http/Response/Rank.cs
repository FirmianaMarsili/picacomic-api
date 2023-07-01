

using Newtonsoft.Json;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 排行榜
    /// </summary>
    public class Rank
    {
        /// <summary>
        /// 排行榜漫画列表
        /// </summary>
        [JsonProperty("comics")]
        public Comic_Rank[] Comics { get; set; }
    }

    /// <summary>
    /// 排行榜漫画信息
    /// </summary>
    public class Comic_Rank
    {
        /// <summary>
        /// 漫画id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 投稿人
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 绅士指名次数
        /// </summary>
        [JsonProperty("totalViews")]
        public int TotalViews { get; set; }

        /// <summary>
        /// 总点赞数
        /// </summary>
        [JsonProperty("totalLikes")]
        public int TotalLikes { get; set; }

        /// <summary>
        /// 漫画页数
        /// </summary>
        [JsonProperty("pagesCount")]
        public int PagesCount { get; set; }

        /// <summary>
        /// 章节数
        /// </summary>
        [JsonProperty("epsCount")]
        public int EpsCount { get; set; }

        /// <summary>
        /// 是否完结
        /// </summary>
        [JsonProperty("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// 文章所属分类
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// 封面图标信息
        /// </summary>
        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        /// <summary>
        /// 绅士指名次数
        /// </summary>
        [JsonProperty("viewsCount")]
        public int ViewsCount { get; set; }

        /// <summary>
        /// 排名分
        /// </summary>
        [JsonProperty("leaderboardCount")]
        public int LeaderboardCount { get; set; }
    }
}
