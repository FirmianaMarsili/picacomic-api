using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic.Http.Request
{
    public interface RequestFormat
    {
        public string Format()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
