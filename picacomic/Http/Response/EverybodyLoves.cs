using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 大家都在看
    /// </summary>
   public  class EverybodyLoves
    {
        [JsonProperty("comics")]
        public Comics_EverybodyLoves Comics { get; set; }
    }
    public class Comics_EverybodyLoves
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// 当前最多显示数量
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 漫画列表
        /// </summary>
        [JsonProperty("docs")]
        public Doc_EverybodyLoves[] Docs { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class Doc_EverybodyLoves
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
        /// 漫画总页数
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
        /// 漫画所属分类
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// 封面图标信息
        /// </summary>
        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        /// <summary>
        /// 总点赞数
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }
    }

}
