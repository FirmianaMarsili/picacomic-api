using picacomic.Http.Response;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace picacomic
{
    /// <summary>
    /// 只是对HttpClient的一个简单的封装
    /// </summary>
    public class HttpWeb
    {
        private static HttpClient httpClient = new()
        {
            BaseAddress = new(Header.baseUrl),
            Timeout = new TimeSpan(0, 0, 5)
        };

        private static HttpClient httpClientDownload = new() { Timeout = new TimeSpan(0, 0, 10) };


        public static async Task <T> SendAsync<T>(Header header)
        {
            string url = header.GetUrl();
            var dic = header.GetHeader();
            foreach (var item in dic)
            {
                if (httpClient.DefaultRequestHeaders.Contains(item.Key))
                {
                    httpClient.DefaultRequestHeaders.Remove(item.Key);
                }
                httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);
            }
            HttpResponseMessage response;
            if (header.MethodIsPost)
            {
                var content = new StringContent(header.GetParam(), Encoding.UTF8, "application/json");
                content.Headers.ContentType.CharSet = "UTF-8";
                response = await httpClient.PostAsync(url, content);
            }
            else
            {
                response = await httpClient.GetAsync(url);
            }
            var responseString = await response.Content.ReadAsStringAsync();
            var Data = ResponseBase<T>.FromJson(responseString);
            if (Data.Success)
            {
                return Data.Data;
            }
            else
            {
                throw new Exception($"URL: {header.GetUrl()} \n 错误信息：{Data.Message} \n {Data.Detail}");
            }            
        }       
    }
}
