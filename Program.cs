using System;
using System.IO;
using Newtonsoft.Json.Linq;
using picacomic_api.Http;
namespace picacomic_api
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {         
            string msg_login = await Http.HttpWeb.SendAsync(PicacomicUrl.Login(
                username:"",
                password: ""));
            if (!string.IsNullOrEmpty(msg_login))
            {
                Console.WriteLine(msg_login);
                JObject jd = JObject.Parse(msg_login);
                if ((int)jd["code"] == 200 && (string)jd["message"] == "success")
                {

                    Console.WriteLine("登录成功");
                    Header.authorization = (string)jd["data"]["token"];  //登录成功以后将token保存

                    string msg_profile = await HttpWeb.SendAsync(PicacomicUrl.Profile());
                    Console.WriteLine(msg_profile);
                    if (string.IsNullOrEmpty(msg_profile))
                    {
                        JObject jd_profile = JObject.Parse(msg_profile);
                        if (!(bool)jd_profile["isPunched"]) // 判断是否已经签到
                        {
                            _ = await HttpWeb.SendAsync(PicacomicUrl.Punch()); //进行签到
                        }
                    }
                    
                }
            }
            



            Console.ReadLine();
        }
    }
}
