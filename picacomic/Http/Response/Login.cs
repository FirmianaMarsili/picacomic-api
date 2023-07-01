using Newtonsoft.Json;

namespace Picacomic.Http.Response
{
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
}
