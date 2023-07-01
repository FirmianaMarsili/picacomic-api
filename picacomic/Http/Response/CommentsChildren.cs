using Newtonsoft.Json;
using System;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 获取子评论
    /// </summary>
    public class CommentsChildren
    {        
        [JsonProperty("comments")]
        public Comment_CommentsChildren Comments { get; set; }
    }
    public class Comment_CommentsChildren
    {
        /// <summary>
        /// 子评论列表
        /// </summary>
        [JsonProperty("docs")]
        public Doc_CommentsChildren[] Docs { get; set; }

        /// <summary>
        /// 总数量
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
        [JsonConverter(typeof(ParseStringConverter))]
        public int Page { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class Doc_CommentsChildren: Doc_GetComments
    {
        /// <summary>
        /// 父评论的id
        /// </summary>
        [JsonProperty("_parent")]
        public string Parent { get; set; }       
    }

    

  
}
