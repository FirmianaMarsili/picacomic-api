using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Picacomic.Http.Request;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Picacomic

{

    /// <summary>
    /// 图片的质量
    /// </summary>
    public enum ImageQuality
    {
        original,
        low,
        medium,
        high
    }

    /// <summary>
    /// 构建所有在访问里需要的header
    /// </summary>
    public class Header
    {



        internal static readonly string baseUrl = "https://picaapi.picacomic.com/";

        private readonly string api_key = "C69BAF41DA5ABD1FFEDC6D2FEA56B";

        private readonly string version = "2.2.1.2.3.4";

        private readonly string build_version = "45";

        private readonly string accept = "application/vnd.picacomic.com.v1+json";

        private readonly string nonce = System.Guid.NewGuid().ToString().Replace("-", string.Empty);

        private readonly string platform = "android";

        private readonly string app_uuid = "defaultUuid";

        private readonly string user_agent = "okhttp/3.8.1";


        private ImageQuality image_quality = ImageQuality.original;


        private string host = "picaapi.picacomic.com";

        /// <summary>
        /// 线路
        /// </summary>
        private string channel = "1";

        /// <summary>
        /// 此次连接发起的时间点，超过一定时间这次请求会被任务无效，Timezone 'Asia/Shanghai'
        /// </summary>
        private string Timestamp
        {
            get
            {
                TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                return Convert.ToInt64(ts.TotalSeconds).ToString();
            }
        }

        /// <summary>
        /// 登录成功后所返回的token，长时间后会失效
        /// 需要重新登录
        /// 除登录以外都需要传入此token
        /// 有效期好像是一周的样子
        /// </summary>
        public static string Authorization { get; private set; }


        private string _url;

        /// <summary>
        /// 请求接口的完整连接
        /// </summary>
        public string Url
        {
            get => _url;
            init => _url = baseUrl + value;
        }

        private HttpMethod _method;
        /// <summary>
        /// 当前请求的方式
        /// </summary>
        public HttpMethod Method { 
            get => _method;
            init => _method = value;
        }
        /// <summary>
        /// 如果是POST的时候，需要在Content处，显示设置charset
        /// </summary>
        public bool MethodIsPost => Method == HttpMethod.Post;

        /// <summary>
        /// POST时需要设置为"application/json; charset=UTF-8"
        /// 因HttpClient规则所限，此值可以不用理会，已在所有Post时添加
        /// 原因参考于"https://github.com/dotnet/runtime/issues/17036#issuecomment-212023809"
        /// </summary>
        private string content_type;

        private string connection;

        private string accept_encoding;


        private string _param;
        /// <summary>
        /// POST DATA
        /// </summary>
        public string Param
        {
            get => _param;
            init => _param = value;
        }



        public Header(string url)
        {
            Url = url;
            Method = HttpMethod.Get;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param">可为null</param>
        public Header(string url, RequestFormat param)
        {
            Url = url;
            Method = HttpMethod.Post;
            Param = param != null ? param.Format() : "";
        }



        public Header(string url, HttpMethod _method, ImageQuality _imageQuality = ImageQuality.original, string _host = null, string _authorization = null, string _content_type = null, string _connection = null, string _accept_encoding = null, RequestFormat _param = null)
        {
            Url = url;
            Method = _method;
            image_quality = _imageQuality;
            host = _host;            
            content_type = _content_type;
            connection = _connection;
            accept_encoding = _accept_encoding;
            Param = _param == null ? "" : _param.Format();
        }

        /// <summary>
        /// 设置token
        /// Token有时限，在数据返回无效token时就需要重新登录
        /// </summary>
        /// <param name="token"></param>
        public static void SetAuthorization(string token)
        {
            Authorization = token;
        }

        internal Dictionary<string, string> GetHeader()
        {
            string time = Timestamp;
            string _nonce = nonce;
            Dictionary<string, string> dic = new()
            {
                ["api-key"] = api_key,
                ["accept"] = accept,
                ["signature"] = GetSignature(time, _nonce),
                ["app-channel"] = channel,
                ["time"] = time,
                ["app-version"] = version,
                ["app-build-version"] = build_version,

                ["nonce"] = _nonce,
                ["app-platform"] = platform,
                ["app-uuid"] = app_uuid,
                ["user-Agent"] = user_agent,
                ["Host"] = host,
                ["image-quality"] = image_quality.ToString(),
            };
            if (!string.IsNullOrEmpty(Authorization))
                dic["authorization"] = Authorization;


            //这几个其实应该已经用不到
            if (!string.IsNullOrEmpty(content_type))
                dic["Content-Type"] = content_type;
            if (!string.IsNullOrEmpty(accept_encoding))
                dic["Accept-Encoding"] = accept_encoding;
            if (!string.IsNullOrEmpty(connection))
                dic["Connection"] = connection;
            return dic;
        }


        private string Signature_data(string[] headers)
        {
            string encodeStr =
                headers[1] +
                headers[2] +
                headers[3] +
                headers[4] +
                headers[5];
            return encodeStr;
        }

        private string GetSignature(string time, string nonce)
        {
            string[] data = new string[] {
               baseUrl,
               Url.Replace(baseUrl,string.Empty),
               time,
               nonce,
               Method.ToString(),
               api_key,
               version,
               build_version
            };
            string src_data = Signature_data(data);
            string src_key = Signature_key();

            string signature = HMAC256(src_data, src_key);

            return signature;


        }
     
        /// <summary>
        /// 这个key在当前版本中是固定的。所以可以直接返回的
        /// </summary>
        /// <returns></returns>
        private string Signature_key()
        {
            return "~d}$Q7$eIni=V)9\\RK/P.RM4;9[7|@/CA}b~OW!3?EV`:<>M7pddUBL5n|0/*Cn";

            //下面是key的生成过程

            char[] sign = "~*}$#,$-\").=$)\",,#/-.'%(;$[,|@/&(#\"~%*!-?*\"-:*!!*,$\"%.&'*|%/*,*".ToCharArray();
            List<string> array = new List<string>();
            for (int i = 0; i < sign.Length; i++)
            {
                array.Add(sign[i].ToString());
            }

            array[1] = ((char)100).ToString();
            string temp = Encode(14161, 2);
            int index = 0;
            for (int i = 4; i < 6; i++)
            {
                array[i] = temp[index++].ToString();
            }
            temp = Encode(1768835429, 4);
            index = 0;
            for (int i = 7; i < 11; i++)
            {
                array[i] = temp[index++].ToString();
            }
            array[12] = ((char)86).ToString();
            array[19] = ((char)80).ToString();

            index = 0;
            for (int i = 21; i < 24; i++)
            {
                array[i] = ("RM4"[index++]).ToString();
            }
            index = 0;
            for (int i = 31; i < 35; i++)
            {
                array[i] = ("CA}b"[index++]).ToString();
            }
            temp = Encode(22351, 2);
            index = 0;
            for (int i = 36; i < 38; i++)
            {
                array[i] = temp[index++].ToString();
            }
            index = 0;
            for (int i = 41; i < 44; i++)
            {
                array[i] = ("EV`"[index++]).ToString();
            }
            index = 0;
            for (int i = 45; i < 57; i++)
            {
                array[i] = ("<>M7pddUBL5n"[index++]).ToString();
            }
            temp = Encode(28227, 2);
            index = 0;
            for (int i = 61; i < 63; i++)
            {
                array[i] = temp[index++].ToString();
            }
            index = 0;
            for (int i = 14; i < 18; i++)
            {
                array[i] = (@"9\RK"[index++]).ToString();
            }
            array[25] = ((char)57).ToString();
            array[27] = ((char)55).ToString();
            array[39] = ((char)51).ToString();
            array[58] = ((char)48).ToString();

            temp = string.Join("", array);



            return temp;
        }

        private string HMAC256(string data, string secret)
        {

            var encoding = System.Text.Encoding.UTF8;
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] dataBytes = encoding.GetBytes(data.ToLower());
            using (var hmacsha256 = new System.Security.Cryptography.HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(dataBytes);
                StringBuilder sb = new StringBuilder();
                return Convert.ToHexString(hashmessage).ToLower();
            }
        }

        private string Encode(long num, int count, bool little = true)
        {
            List<byte> array = new List<byte>();
            long n = num;
            do
            {

                array.Insert(little ? array.Count : 0, (byte)(n % 256));


                n /= 256;
            } while (n >= 256);
            array.Insert(little ? array.Count : 0, (byte)n);

            if (array.Count > count)
            {
                if (little)
                {
                    for (int i = 0; i < array.Count - count; i++)
                    {
                        array.RemoveAt(array.Count - 1);
                    }
                }
                else
                {
                    for (int i = 0; i < array.Count - count; i++)
                    {
                        array.RemoveAt(0);
                    }
                }
            }
            else
            {
                if (little)
                {
                    for (int i = 0; i < count - array.Count; i++)
                    {
                        array.Insert(array.Count - 1, 0x00);
                    }
                }
                else
                {
                    for (int i = 0; i < count - array.Count; i++)
                    {
                        array.Insert(0, 0x00);
                    }
                }
            }

            return System.Text.Encoding.UTF8.GetString(array.ToArray());
        }
    }
}
