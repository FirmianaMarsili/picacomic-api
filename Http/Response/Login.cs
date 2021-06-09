using Newtonsoft.Json;

namespace picacomic_api.Http.Response
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
