using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 看了這本子的人也在看
    /// </summary>
    public class Recommendation
    {
        [JsonProperty("comics")]
        public Comic_Recommendation[] Comics { get; set; }
    }
    /// <summary>
    /// 漫画信息
    /// </summary>
    public class Comic_Recommendation
    {
        /// <summary>
        /// 漫画id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 漫画标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 投稿人
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

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
        /// 点赞数？
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }
}
