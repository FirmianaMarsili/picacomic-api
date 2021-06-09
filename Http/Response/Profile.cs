

using Newtonsoft.Json;

namespace picacomic.Http.Response
{
    public class Profile
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
