using Newtonsoft.Json;

namespace picacomic.Http.Response
{
    /// <summary>
    /// 登录
    /// </summary>
    public class Login
    {
        [JsonProperty("token")]
        public string Authorization { get; set; }
    }
}
