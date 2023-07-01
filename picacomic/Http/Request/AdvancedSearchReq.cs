using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Request
{
    /// <summary>
    /// 关键词搜索
    /// </summary>
    public struct AdvancedSearchReq : RequestFormat
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 排序规则
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }
    }
}
