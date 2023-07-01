using Newtonsoft.Json;
using Picacomic.Http.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//兼容旧版本的GitHub Action
namespace picacomic.Http.Response
{

    [Obsolete("应该使用Picacomic.Http.Response.Login")]
    /// <summary>
    /// 登录
    /// </summary>
    public class Login
    {
        /// <summary>
        /// 用户token,有时效，大概为一周？,在登陆成功以后需要将其设置到header里。Head.SetAuthorization
        /// </summary>
        [JsonProperty("token")]
        public string Authorization { get; set; }
    }

    [Obsolete("应该使用Picacomic.Http.Response.Profile")]
    /// <summary>
    /// 个人资料
    /// </summary>
    public class Profile
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }

    [Obsolete("应该使用Picacomic.Http.Response.Punch")]
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

}
