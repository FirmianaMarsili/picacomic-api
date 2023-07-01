using Picacomic;
using Picacomic.Http.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//兼容旧版本的GitHub Action
namespace picacomic
{
    [Obsolete("应该使用Picacomic.PicAcgReq")]
    public  class PicacomicUrl
    {        
        public static async Task<picacomic.Http.Response.Login> Login(string email, string password)
        {                     
            var login = await Picacomic.PicAcgReq.Login(email, password);
            picacomic.Http.Response.Login obsoleteLogin = new picacomic.Http.Response.Login();
            obsoleteLogin.Authorization = login.Authorization;
            return obsoleteLogin;
        }
        public static async Task<picacomic.Http.Response.Profile> Profile(string id = "")
        {    
            var profile = await Picacomic.PicAcgReq.Profile(id);
            picacomic.Http.Response.Profile obsoleteProfile = new picacomic.Http.Response.Profile();
            obsoleteProfile.User = profile.User;
            return obsoleteProfile;
        }

        public static async Task<picacomic.Http.Response.Punch> Punch()
        {
            var punch = await Picacomic.PicAcgReq.Punch();
            picacomic.Http.Response.Punch obsoletePunch = new Http.Response.Punch();
            obsoletePunch.Res = punch.Res;
            return obsoletePunch;
        }

    }
    [Obsolete("应该使用Picacomic.Header")]
    public class Header
    {
        public static void SetAuthorization(string token)
        {
            Picacomic.Header.SetAuthorization(token);
        }
    }
}
