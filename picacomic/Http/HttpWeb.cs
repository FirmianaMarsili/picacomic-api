using Picacomic.Http.Response;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic
{
    /// <summary>
    /// 只是对HttpClient的一个简单的封装
    /// </summary>
    internal class HttpWeb
    {
        private static HttpClient httpClient = new()
        {
            BaseAddress = new(Header.baseUrl),
            Timeout = new TimeSpan(0, 0, 5)
        };


        internal static async Task<T> SendAsync<T>(Header header)
        {
            string url = header.Url;
            var dic = header.GetHeader();
            HttpRequestMessage request = new HttpRequestMessage(header.Method, url);
            foreach (var h in dic)
            {
                request.Headers.Add(h.Key, h.Value);
            }
            if (header.MethodIsPost)
            {
                var content = new StringContent(header.Param, Encoding.UTF8, "application/json");
                content.Headers.ContentType.CharSet = "UTF-8";
                request.Content = content;                
            }            
            var response = await httpClient.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();           
            var Data = ResponseBase<T>.FromJson(responseString);
            if (Data.Success)
                return Data.Data;
            else
                throw new Exception($"URL: {header.Url} \n 错误信息：{Data.Message} \n {Data.Detail}");
        }
    }
}
