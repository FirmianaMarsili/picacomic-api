using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 获取聊天室
    /// </summary>
    public class Chat
    {
        /// <summary>
        /// 聊天室列表
        /// </summary>
        [JsonProperty("chatList")]
        public List<ChatRes> ChatList { get; set; }
    }
    /// <summary>
    /// 聊天室
    /// </summary>
    public class ChatRes
    {
        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 连接
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }
    }
}
