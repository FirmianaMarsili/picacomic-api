using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace picacomic_api.Http
{
    public class HttpWeb
    {
        private static HttpClient httpClient = new() {
            BaseAddress = new(Header.baseUrl),
            Timeout = new TimeSpan(0, 0, 3) };

        private static HttpClient httpClientDownload = new() { Timeout = new TimeSpan(0, 0, 6) };


        public static async Task<string> SendAsync(Header header)
        {
            try
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

                return responseString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return string.Empty;
            }
        }


        public static async Task<System.IO.Stream> DownloadAsync(string url)
        {

            try
            {                
                HttpResponseMessage response = await httpClientDownload.GetAsync(url);
                System.IO.Stream streamToReadFrom = await response.Content.ReadAsStreamAsync();
                return streamToReadFrom;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
