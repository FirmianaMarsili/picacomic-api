using Newtonsoft.Json;
using System;

namespace picacomic.Http.Response
{
    public class GetCommentsChildren
    {
        [JsonProperty("comments")]
        public Comments_CommentsChildren Comments { get; set; }
    }
    public class Comments_CommentsChildren
    {
        [JsonProperty("docs")]
        public Doc_CommentsChildren[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("page")]
        [JsonConverter(typeof(ParseStringConverter))]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class Doc_CommentsChildren: Doc_GetComments
    {

        [JsonProperty("_parent")]
        public string Parent { get; set; }       
    }

    

  
}
