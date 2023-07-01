

using Newtonsoft.Json;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 个人资料
    /// </summary>
    public class Profile
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
