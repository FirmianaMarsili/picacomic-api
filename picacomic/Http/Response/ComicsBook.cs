using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 漫画信息
    /// </summary>
   public  class ComicsBook
    {
        [JsonProperty("comic")]
        public Comic_ComicsBook Comic { get; set; }
    }
    public class Comic_ComicsBook
    {
        /// <summary>
        /// 漫画id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 投稿人的具体信息
        /// </summary>
        [JsonProperty("_creator")]
        public Creator Creator { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 封面图片信息
        /// </summary>
        [JsonProperty("thumb")]
        public Thumb Thumb { get; set; }

        /// <summary>
        /// 投稿人
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 所属汉化组
        /// </summary>
        [JsonProperty("chineseTeam")]
        public string ChineseTeam { get; set; }

        /// <summary>
        /// 文章所属分类
        /// </summary>
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        /// <summary>
        /// 文章标签
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

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
        /// 最后一次更新
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 开放下载
        /// 即使屏蔽了，你依旧可以通过章节查看每张图片的下载地址。然后通过地址去下载
        /// </summary>
        [JsonProperty("allowDownload")]
        public bool AllowDownload { get; set; }

        /// <summary>
        /// 开放评论
        /// </summary>
        [JsonProperty("allowComment")]
        public bool AllowComment { get; set; }

        /// <summary>
        /// 总点赞数
        /// </summary>
        [JsonProperty("totalLikes")]
        public int TotalLikes { get; set; }

        /// <summary>
        /// 绅士指名次数
        /// </summary>
        [JsonProperty("totalViews")]
        public int TotalViews { get; set; }

        /// <summary>
        ///  绅士指名次数
        /// </summary>
        [JsonProperty("viewsCount")]
        public int ViewsCount { get; set; }

        /// <summary>
        /// 总点赞数
        /// </summary>
        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }

        /// <summary>
        /// 是否已经收藏
        /// </summary>
        [JsonProperty("isFavourite")]
        public bool IsFavourite { get; set; }

        /// <summary>
        /// 是否已经点赞
        /// </summary>
        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [JsonProperty("commentsCount")]
        public int CommentsCount { get; set; }
    }

    /// <summary>
    /// 投稿人
    /// </summary>
    public class Creator
    {
        /// <summary>
        /// 投稿人id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 称号
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 实名认证
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

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("characters")]
        public string[] Characters { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        [JsonProperty("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// 头像遮罩
        /// </summary>
        [JsonProperty("character", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Character { get; set; }
    }
}
