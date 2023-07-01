using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Request
{
    /// <summary>
    /// 发送评论
    /// </summary>
    public struct SendCommentReq : RequestFormat
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
