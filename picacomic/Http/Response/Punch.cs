using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 签到
    /// </summary>
    public class Punch
    {
        [JsonProperty("res")]
        public PunchRes Res { get; set; }

        /// <summary>
        /// 自定义内容。只要签到成功一次以后，当天内Res都会有值。只有当天第一次签到时，Res的内容才是正确的
        /// 获取通过GetPlatform里的isPunch字段判断
        /// </summary>
        public bool PunchSuccess
        {
            get { return Res != null; }
        }
    }
    /// <summary>
    /// 签到请求返回内容。 只有当天第一次签到成功才会返回正确内容，其他时候只有返回Status为fail
    /// </summary>
    public class PunchRes
    {
        /// <summary>
        /// 签到操作状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 最后一次签到日期
        /// </summary>
        [JsonProperty("punchInLastDay")]
        public DateTime PunchInLastDay { get; set; }        
    }


}
