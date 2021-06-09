

using Newtonsoft.Json;

namespace picacomic.Http.Response
{
   public  class AddFavourite
    {
        [JsonProperty("action")]
        public string Action { get; set; }
    }
}
