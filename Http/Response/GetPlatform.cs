using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace picacomic_api.Http.Response
{
    public class GetPlatform
    {
        [JsonProperty("isPunched")]
        public bool IsPunched { get; set; }

        [JsonProperty("latestApplication")]
        public LatestApplication LatestApplication { get; set; }

        [JsonProperty("imageServer")]
        public Uri ImageServer { get; set; }

        [JsonProperty("apiLevel")]
        public int ApiLevel { get; set; }

        [JsonProperty("minApiLevel")]
        public int MinApiLevel { get; set; }

        [JsonProperty("categories")]
        public List<GetCategory> Categories { get; set; }

        [JsonProperty("notification")]
        public object Notification { get; set; }

        [JsonProperty("isIdUpdated")]
        public bool IsIdUpdated { get; set; }
    }

    public class LatestApplication
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("downloadUrl")]
        public Uri DownloadUrl { get; set; }

        [JsonProperty("updateContent")]
        public string UpdateContent { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("apk")]
        public Apk Apk { get; set; }
    }

    public class Apk
    {
        [JsonProperty("originalName")]
        public string OriginalName { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("fileServer")]
        public Uri FileServer { get; set; }
    }
}
