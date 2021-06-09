

using Newtonsoft.Json;

namespace picacomic_api.Http.Response
{
   public  class AddFavourite
    {
        [JsonProperty("action")]
        public string Action { get; set; }
    }
}
