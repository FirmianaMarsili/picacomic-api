using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace picacomic_api.Http.Response
{
    public class User
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("exp")]
        public int Exp { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("characters")]
        public object[] Characters { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("isPunched")]
        public bool IsPunched { get; set; }
    }
}
