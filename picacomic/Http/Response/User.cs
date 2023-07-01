using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Picacomic.Http.Response
{
    public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户邮箱，一般都是账号
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        /// <summary>
        ///  性别
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

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
        /// 当前经验值
        /// </summary>
        [JsonProperty("exp")]
        public int Exp { get; set; }

        /// <summary>
        /// 当前等级
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// 希腊奶
        /// </summary>
        [JsonProperty("characters")]
        public object[] Characters { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 是否已经签到
        /// </summary>
        [JsonProperty("isPunched")]
        public bool IsPunched { get; set; }
    }
}
