

using Newtonsoft.Json;

namespace picacomic_api.Http.Response
{
    public class Profile
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
