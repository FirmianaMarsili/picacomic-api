using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// APP基本信息
    /// </summary>
    public class Platform
    {
        /// <summary>
        /// 是否已经签到
        /// </summary>
        [JsonProperty("isPunched")]
        public bool IsPunched { get; set; }

        /// <summary>
        /// 最后更新信息
        /// </summary>
        [JsonProperty("latestApplication")]
        public LatestApplication LatestApplication { get; set; }

        /// <summary>
        /// 文件下载基址
        /// </summary>
        [JsonProperty("imageServer")]
        public Uri ImageServer { get; set; }

        /// <summary>
        /// sdkVersion?
        /// </summary>
        [JsonProperty("apiLevel")]
        public int ApiLevel { get; set; }

        /// <summary>
        /// sdkVersion?
        /// </summary>
        [JsonProperty("minApiLevel")]
        public int MinApiLevel { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// 通知
        /// </summary>
        [JsonProperty("notification")]
        public object Notification { get; set; }

        [JsonProperty("isIdUpdated")]
        public bool IsIdUpdated { get; set; }
    }

    /// <summary>
    /// APP更新信息
    /// </summary>
    public class LatestApplication
    {
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// 当前版本app的下载地址
        /// </summary>
        [JsonProperty("downloadUrl")]
        public Uri DownloadUrl { get; set; }

        /// <summary>
        /// 更新说明
        /// </summary>
        [JsonProperty("updateContent")]
        public string UpdateContent { get; set; }

        /// <summary>
        /// 当前版本
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// app下载地址信息
        /// 可以直接使用上面的DownloadUrl
        /// </summary>
        [JsonProperty("apk")]
        public Apk Apk { get; set; }
    }

    /// <summary>
    /// app的下载信息，可以像其他文件一样去拼接
    /// </summary>
    public class Apk
    {
        /// <summary>
        /// 文件名字
        /// </summary>
        [JsonProperty("originalName")]
        public string OriginalName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 基址
        /// </summary>
        [JsonProperty("fileServer")]
        public Uri FileServer { get; set; }
    }
}
