using System;
namespace picacomic
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
