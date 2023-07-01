using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 普通搜索
    /// </summary>
    public class Search
    {
        [JsonProperty("comics")]
        public Comics_Search Comics { get; set; }
    }
    /// <summary>
    /// 匹配信息
    /// </summary>
    public class Comics_Search
    {
        /// <summary>
        /// 匹配列表
        /// </summary>
        [JsonProperty("docs")]
        public Doc_Search[] Docs { get; set; }

        /// <summary>
        /// 匹配总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 当前页最大数量
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

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
    }

    /// <summary>
    /// 普通搜索返回的漫画信息
    /// </summary>
    public class Doc_Search
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
        /// 漫画id
        /// </summary>
        [JsonProperty("id")]
        public string DocId { get; set; }

        /// <summary>
        /// 总点赞数
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }
}
