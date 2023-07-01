using Newtonsoft.Json;
using System;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 获取漫画章节信息
    /// </summary>
    public class ComicsBookEps
    {
        /// <summary>
        /// 章节信息
        /// </summary>
        [JsonProperty("eps")]
        public Eps Eps { get; set; }
    }
    /// <summary>
    /// 章节信息
    /// </summary>
    public class Eps
    {
        /// <summary>
        /// 章节列表，倒序。下标从1
        /// </summary>
        [JsonProperty("docs")]
        public Doc_ComicsBookEps[] Docs { get; set; }
        /// <summary>
        /// 总章节
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
    /// 章节具体信息
    /// </summary>
    public class Doc_ComicsBookEps
    {
        /// <summary>
        /// 漫画id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 章节名字
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 第几章
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 漫画id
        /// </summary>
        [JsonProperty("id")]
        public string DocId { get; set; }
    }

}
