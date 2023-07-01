

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 分类信息
    /// </summary>
    public class Category
    {
        [JsonProperty("categories")]
        public List<Categorie> Categories { get; set; }
    }

    /// <summary>
    /// 分类
    /// </summary>
    public class Categorie
    {
        /// <summary>
        /// 类别名字
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 分类封面信息
        /// </summary>
        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public Thumb Thumb { get; set; }


        [JsonProperty("isWeb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWeb { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Link { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}
