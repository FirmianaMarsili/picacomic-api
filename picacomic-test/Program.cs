using Newtonsoft.Json.Linq;
using System;
using picacomic;
using System.Threading.Tasks;
using System.Linq;

namespace Picacomic
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //登录
            var login = await PicAcgReq.Login("username","password");
            //设置token
            Header.SetAuthorization(login.Authorization);
            //获取热词
            Console.WriteLine( string.Join('\n', PicAcgReq.GetKeywords().Result.Keyword));

            Console.ReadLine();
        }        
    }
}
