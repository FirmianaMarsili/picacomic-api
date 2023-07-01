using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 获取我的评论
    /// </summary>
    public class MyComments
    {        
        [JsonProperty("comments")]
        public Comment_MyComments Comments { get; set; }
    }
    public class Comment_MyComments
    {
        /// <summary>
        /// 评论列表
        /// </summary>
        [JsonProperty("docs")]
        public List<Doc_MyComments> Docs { get; set; }

        /// <summary>
        /// 评论总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 当前页最大数量
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 当前返回的是第几页评论
        /// </summary>
        [JsonProperty("page")]
        [JsonConverter(typeof(ParseStringConverter))]
        public int Page { get; set; }

        /// <summary>
        /// 评论总共有几页
        /// </summary>
        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    /// <summary>
    /// 评论的具体信息
    /// </summary>
    public class Doc_MyComments
    {
        /// <summary>
        /// 当前评论的唯一id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评论所在的漫画或者聊天室
        /// </summary>
        [JsonProperty("_comic")]
        public Comic_MyComments Comic { get; set; }

        /// <summary>
        /// 是否被隐藏
        /// </summary>
        [JsonProperty("hide")]
        public bool Hide { get; set; }

        /// <summary>
        /// 发表日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 当前评论的唯一id 
        ///  同上 _id
        /// </summary>
        [JsonProperty("id")]
        public string DocId { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }

        /// <summary>
        /// 子评论数量
        /// </summary>
        [JsonProperty("commentsCount")]
        public int CommentsCount { get; set; }

        /// <summary>
        /// 子评论总数量
        /// </summary>
        [JsonProperty("totalComments", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalComments { get; set; }

        /// <summary>
        /// 是否已经给这条评论点赞
        /// </summary>
        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }
    }

    /// <summary>
    /// 漫画或者聊天室信息
    /// </summary>
    public class Comic_MyComments
    {
        /// <summary>
        /// 漫画或者聊天室的唯一id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 漫画或者聊天室的标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
