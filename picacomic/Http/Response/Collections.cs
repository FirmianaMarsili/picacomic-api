using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 本子神推荐
    /// </summary>
    public class Collections
    {
        [JsonProperty("collections")]
        public Collection[] Collection { get; set; }
    }
    public class Collection
    {
        /// <summary>
        /// 分类名字。如没意外，通常为"本子妹推薦"
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 推荐列表
        /// </summary>
        [JsonProperty("comics")]
        public Comic_Collections[] Comics { get; set; }
    }

    public class Comic_Collections
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
        /// 漫画总页数
        /// </summary>
        [JsonProperty("pagesCount")]
        public int PagesCount { get; set; }

        /// <summary>
        /// 总章节数
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
        /// 封面图片信息
        /// </summary>
        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }
    }
}
