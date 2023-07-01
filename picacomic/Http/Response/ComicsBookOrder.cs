using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 章节内容
    /// </summary>
    public   class ComicsBookOrder
    {
        /// <summary>
        /// 章节内容具体信息
        /// </summary>
        [JsonProperty("pages")]
        public Pages Pages { get; set; }

        /// <summary>
        /// 章节信息
        /// </summary>
        [JsonProperty("ep")]
        public Ep Ep { get; set; }
    }
    /// <summary>
    /// 章节简略信息
    /// </summary>
    public class Ep
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
    }

    public class Pages
    {
        /// <summary>
        /// 每张漫画的具体信息
        /// </summary>
        [JsonProperty("docs")]
        public Doc_ComicsBookOrder[] Docs { get; set; }

        /// <summary>
        /// 当前章节中图片总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 当前页最大显示数量
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
        public int PagesPages { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>

    public class Doc_ComicsBookOrder
    {
        /// <summary>
        /// 图片id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 图片的下载信息
        /// </summary>
        [JsonProperty("media")]
        public Thumb Media { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [JsonProperty("id")]
        public string DocId { get; set; }
    }
   
}
