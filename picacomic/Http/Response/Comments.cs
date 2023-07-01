using Newtonsoft.Json;
using System;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 获取某个本子的评论。或者是聊天室的评论
    /// </summary>
    public class Comments
    {
        /// <summary>
        /// 评论列表
        /// </summary>
        [JsonProperty("comments")]
        public Comments_GetComments Comment { get; set; }

        /// <summary>
        /// 置顶评论列表
        /// </summary>
        [JsonProperty("topComments")]
        public TopComment[] TopComments { get; set; }
    }
    public class Comments_GetComments
    {
        [JsonProperty("docs")]
        public Doc_GetComments[] Docs { get; set; }

        /// <summary>
        /// 总评论数
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
        [JsonConverter(typeof(ParseStringConverter))]
        public int Page { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    /// <summary>
    /// 评论的具体信息
    /// </summary>
    public class Doc_GetComments
    {
        /// <summary>
        /// 当前评论的id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评论的具体信息
        /// </summary>
        [JsonProperty("_user")]
        public User_GetComments User { get; set; }

        /// <summary>
        /// 评论所在的漫画或者聊天室的id
        /// </summary>
        [JsonProperty("_comic")]
        public string Comic { get; set; }

        /// <summary>
        /// 置顶
        /// </summary>
        [JsonProperty("isTop")]
        public bool IsTop { get; set; }
        
        /// <summary>
        /// 隐藏
        /// </summary>
        [JsonProperty("hide")]
        public bool Hide { get; set; }

        /// <summary>
        /// 发表日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 当前评论的id
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
        [JsonProperty("commentsCount", NullValueHandling = NullValueHandling.Ignore)]
        public int CommentsCount { get; set; }

        /// <summary>
        /// 是否已经点赞
        /// </summary>
        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }
    }

    /// <summary>
    /// 评论人的个人资料
    /// </summary>
    public class User_GetComments
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("gender")]
        public PicAcgReq.Gender Gender { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 称号？
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 实名认证？
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// 经验
        /// </summary>
        [JsonProperty("exp")]
        public int Exp { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("characters")]
        public object[] Characters { get; set; }


        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [JsonProperty("avatar")]
        public Thumb Avatar { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("slogan", NullValueHandling = NullValueHandling.Ignore)]
        public string Slogan { get; set; }

        /// <summary>
        /// 头像遮罩
        /// </summary>
        [JsonProperty("character", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Character { get; set; }
    }

    /// <summary>
    /// 置顶评论
    /// </summary>
    public class TopComment
    {
        /// <summary>
        /// 评论id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评论人
        /// </summary>
        [JsonProperty("_user")]
        public User User { get; set; }

        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }


        /// <summary>
        /// 所属漫画或者聊天室的id
        /// </summary>
        [JsonProperty("_comic")]
        public string Comic { get; set; }

        /// <summary>
        /// 置顶
        /// </summary>
        [JsonProperty("isTop")]
        public bool IsTop { get; set; }

        /// <summary>
        /// 隐藏
        /// </summary>
        [JsonProperty("hide")]
        public bool Hide { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }

        /// <summary>
        /// 子评论数
        /// </summary>
        [JsonProperty("commentsCount")]
        public int CommentsCount { get; set; }

        /// <summary>
        /// 是否点赞
        /// </summary>
        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }
    }
}
