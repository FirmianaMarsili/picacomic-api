using Newtonsoft.Json;
using System.Collections.Generic;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 获取热词
    /// </summary>
    public class Keywords
    {
        /// <summary>
        /// 热词列表
        /// </summary>
        [JsonProperty("keywords")]
        public string[] Keyword { get; set; }
    }
}
