using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picacomic.Http.Response
{
    public class Punch
    {
        [JsonProperty("res")]
        public Res Res { get; set; }        

        public bool PunchSuccess
        {
            get { return Res != null; }
        }
    }
    public class Res
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("punchInLastDay")]
        public DateTime PunchInLastDay { get; set; }        
    }


}
