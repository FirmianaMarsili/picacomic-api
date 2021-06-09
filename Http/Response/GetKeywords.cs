using Newtonsoft.Json;
using System.Collections.Generic;

namespace picacomic.Http.Response
{
    public class GetKeywords
    {
        [JsonProperty("keywords")]
        public string[] Keyword { get; set; }
    }
}
