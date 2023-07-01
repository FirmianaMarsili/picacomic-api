using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Request
{
    /// <summary>
    /// 注册
    /// </summary>
    public struct RegisterReq : RequestFormat
    {
        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 生日 格式为： yyyy/MM/dd
        /// </summary>
        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 性别   m,f,bot
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 问题1
        /// </summary>
        [JsonProperty("question1")]
        public string Question1 { get; set; }

        /// <summary>
        /// 答案1
        /// </summary>
        [JsonProperty("answer1")]
        public string Answer1 { get; set; }

        /// <summary>
        /// 问题2
        /// </summary>
        [JsonProperty("question2")]
        public string Question2 { get; set; }

        /// <summary>
        /// 答案2
        /// </summary>
        [JsonProperty("answer2")]
        public string Answer2 { get; set; }

        /// <summary>
        /// 问题2
        /// </summary>
        [JsonProperty("question3")]
        public string Question3 { get; set; }

        /// <summary>
        /// 答案2
        /// </summary>
        [JsonProperty("answer3")]
        public string Answer3 { get; set; }
    }
}
