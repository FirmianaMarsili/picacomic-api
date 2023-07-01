using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Request
{
    /// <summary>
    /// 登陆
    /// </summary>
    public struct LoginReq : RequestFormat
    {
        [JsonProperty("email")]
        public string Email { get; set;  }
        [JsonProperty("password")]
        public string Password { get; set;   }
    }
}
