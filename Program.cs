using System;
using System.IO;
using Newtonsoft.Json.Linq;
using picacg;
namespace picacomic_api
{
    class Program
    {        
        static async System.Threading.Tasks.Task Main(string[] args)
        {
           
            var login = await PicacomicUrl.Login("username","password");//
            if (login != null)
            {
                Header.SetAuthorization(login.Authorization);
            }            

            Console.ReadLine();
        }
    }
}
