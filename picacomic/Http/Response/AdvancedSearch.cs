

using Newtonsoft.Json;
using System;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 高级搜索
    /// </summary>
    public class AdvancedSearch
    {
        /// <summary>
        /// 搜索信息
        /// </summary>
        [JsonProperty("comics")]
        public Comics_AdvancedSearch Comics { get; set; }
    }
    /// <summary>
    /// 搜索信息
    /// </summary>
    public class Comics_AdvancedSearch
    {
        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("pages")]
        public int Pages { get; set; }

        /// <summary>
        /// 匹配漫画列表
        /// </summary>
        [JsonProperty("docs")]
        public Doc_AdvancedSearch[] Docs { get; set; }

        /// <summary>
        /// 当前页最大显示数量
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    /// <summary>
    /// 匹配漫画
    /// </summary>
    public class Doc_AdvancedSearch
    {
        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 封面信息
        /// </summary>
        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        /// <summary>
        /// 投稿人
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 漫画简介
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 所属汉化组
        /// </summary>
        [JsonProperty("chineseTeam", NullValueHandling = NullValueHandling.Ignore)]
        public string ChineseTeam { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 是否完结
        /// </summary>
        [JsonProperty("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// 绅士指名次数
        /// </summary>
        [JsonProperty("totalViews")]
        public int TotalViews { get; set; }

        /// <summary>
        /// 文章所属分类
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// 总点赞数
        /// </summary>
        [JsonProperty("totalLikes")]
        public int TotalLikes { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 文章标签
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// 漫画id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 总点赞数
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }
}
