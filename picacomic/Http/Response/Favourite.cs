using Newtonsoft.Json;
using System;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 收藏夹
    /// </summary>
    public class Favourite
    {
        [JsonProperty("comics")]
        public Comics_Favourite Comics { get; set; }
    }
    /// <summary>
    /// 收藏夹信息
    /// </summary>
    public class Comics_Favourite
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("pages")]
        public int Pages { get; set; }

        /// <summary>
        /// 收藏总数量
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 当前页具体信息
        /// </summary>
        [JsonProperty("docs")]
        public Doc_Favourite[] Docs { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// 当前页最大数量
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    /// <summary>
    /// 收藏夹里的漫画具体信息
    /// </summary>
    public class Doc_Favourite
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
        /// 投稿人名字
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
        /// 是否已经完结
        /// </summary>
        [JsonProperty("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// 文章所属分类
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// 封面信息
        /// </summary>
        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }

    /// <summary>
    /// 文件地址信息
    /// </summary>
    public class Thumb
    {        
        /// <summary>
        /// 基址
        /// </summary>
        [JsonProperty("fileServer")]
        public Uri FileServer { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("originalName")]
        public string OriginalName { get; set; }
    }
}
