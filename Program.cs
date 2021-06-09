using System;
using System.IO;
using Newtonsoft.Json.Linq;
using picacg;
namespace picacomic_api
{
    class Program
    {
        public static string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2MGMwOTFlOWQ2MmEyYzc3Mjg3YTBiYjEiLCJlbWFpbCI6InF3ZXJ0cmZ4ZGQiLCJyb2xlIjoibWVtYmVyIiwibmFtZSI6Im1tLjJkIiwidmVyc2lvbiI6IjIuMi4xLjIuMy40IiwiYnVpbGRWZXJzaW9uIjoiNDUiLCJwbGF0Zm9ybSI6ImFuZHJvaWQiLCJpYXQiOjE2MjMyMzMxNjYsImV4cCI6MTYyMzgzNzk2Nn0.hOoJX8ONhpVSVlDimsdtKDw9fwmakKF3muFgfbq_3tM";
        public static string token_a = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI1Y2Y4OTgxM2FhZTFjYjI4ODM1Y2RjNTUiLCJlbWFpbCI6ImE2MjE0MDE2Iiwicm9sZSI6Im1lbWJlciIsIm5hbWUiOiJtaWtvdCIsInZlcnNpb24iOiIyLjIuMS4yLjMuNCIsImJ1aWxkVmVyc2lvbiI6IjQ1IiwicGxhdGZvcm0iOiJhbmRyb2lkIiwiaWF0IjoxNjIzMjMzNDQ2LCJleHAiOjE2MjM4MzgyNDZ9.X9Xm8elvwwMby0yXNepox2Xfl5Js63jD9eQLR3FYi-U";
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Header.SetAuthorization(token_a);
            var login = await PicacomicUrl.GetPlatform();
            if (login != null)
            {
                ;
            }
            



            Console.ReadLine();
        }
    }
}
