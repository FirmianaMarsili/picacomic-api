using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace picacg
{
    /// <summary>   
    /// 
    /// Api
    /// 
    /// 特别注意的是 如果返回的json里只有code = 200,message = "success"  说明此次后台未进行正确处理 ，大致原因有 method错误，param出错，格式不对、未urlencode、错误的urlencode等等，header错误等等   
    /// 
    /// 哔咔一般都是以40的数量为一页   例：1-40张图片为一页，1-40章节为一页。 如果有特殊情况，可以查看返回数据中的 limit 字段，此为限制每页的最大数量
    /// 
    /// </summary>

    public class PicacomicUrl
    {
        #region Function-Ex

        /// <summary>
        /// 排序规则
        /// </summary>
        public enum sort
        {
            /// <summary>
            /// 默认
            /// </summary>
            ua,
            /// <summary>
            ///  新到旧
            /// </summary>
            dd,
            /// <summary>
            /// 旧到新
            /// </summary>
            da,
            /// <summary>
            /// 爱心最多
            /// </summary>
            ld,
            /// <summary>
            /// 绅士指数最多
            /// </summary>
            vd
        }

        /// <summary>
        /// 性别
        /// </summary>
        public enum gender
        {
            m,
            f,
            bot
        }

        /// <summary>
        /// 排行榜分类
        /// </summary>
        public enum tt
        {
            H24,
            D7,
            D30
        }


        private static string UrlEncode(string str)
        {
            StringBuilder sb = new();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c > 127)
                {
                    byte[] byStr = Encoding.UTF8.GetBytes(str[i].ToString());
                    for (int j = 0; j < byStr.Length; j++)
                    {
                        sb.Append(@"%" + Convert.ToString(byStr[j], 16));
                    }
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        #endregion


        #region  IP

        /// <summary>
        /// 获取线路ip
        /// WebClient.DownloadString(url);            
        /// {"status":"ok","addresses":["104.20.180.50","104.20.181.50"],"waka":"https://ad-channel.wikawika.xyz","adKeyword":"wikawika"}
        /// </summary>      
        public static string GetChannelIp()
        {
            string url = "http://68.183.234.72/init";
            return url;
        }
        #endregion




        #region USER

        /// <summary>
        /// 登录
        /// </summary>
        public static Header Login(string username, string password)
        {
            JObject jd = new()
            {
                ["email"] = username,
                ["password"] = password
            };
            Header header = new(
                url: "auth/sign-in",
                method: HttpMethod.POST,
                param: jd.ToString());
            return header;
        }

        /// <summary>
        /// 注册
        /// </summary>       
        /// <param name="birthday">yyyy/mm/dd</param>       
        /// 
        /// <param name="question1">问题1</param>
        /// <param name="answer1">答案1</param>       
        /// <returns></returns>
        public static Header Register(
            string username,
            string password,
            string name,
            string birthday, //yyyy/mm/dd
            gender gender,   // m,f,bot
            string question1,
            string answer1,
            string question2,
            string answer2,
            string question3,
            string answer3)
        {
            JObject jd = new()
            {
                ["email"] = username,
                ["password"] = password,
                ["name"] = name,
                ["birthday"] = birthday,
                ["gender"] = gender.ToString(),
                ["answer1"] = answer1,
                ["answer2"] = answer2,
                ["answer3"] = answer3,
                ["question1"] = question1,
                ["question2"] = question2,
                ["question3"] = question3
            };


            Header header = new(
                url: "auth/register",
                method: HttpMethod.POST,
                param: jd.ToString());
            return header;
        }


        /// <summary>
        /// 个人资料
        /// </summary>
        /// <param name="id">传入_id时则查询对应_id,不传时则查询自己</param>
        public static Header Profile(string id = "")
        {
            string url = $"users/{(id == "" ? "" : id + "/")}profile";
            Header header = new(url: url);
            return header;
        }


        /// <summary>
        /// 签到
        /// </summary>
        public static Header Punch()
        {
            Header header = new(
                url: "users/punch-in",
                method: HttpMethod.POST);
            return header;
        }

        /// <summary>
        /// 聊天室
        /// </summary>
        /// <returns></returns>
        public static Header GetChat()
        {
            Header header = new(url: "chat");
            return header;
        }

        /// <summary>
        /// 我的评论
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Header GetMyComments(int page = 1)
        {
            Header header = new($"users/my-comments?page={page.ToString()}");
            return header;
        }


        #endregion


        #region Book 

        /// <summary>
        /// 同下，可在初始时保存其中的ImageServer，不过应该与下面函数里fileServer有同样的效果
        /// </summary>
        /// <returns></returns>
        public static Header GetImageKey()
        {
            Header header = new(url: "init?platform=android");
            return header;
        }

        /// <summary>
        /// 获取app主页上几大目录
        /// </summary>
        /// <returns></returns>
        public static Header GetCategory()
        {
            Header header = new(url: "categories");
            return header;
        }

        /// <summary>
        /// 获取收藏
        /// </summary>
        /// <param name="page"></param>        
        public static Header Favourite(sort sort, int page = 1)
        {
            Header header = new(url: $"users/favourite?s={sort.ToString()}&page={page.ToString()}");
            return header;
        }

        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public static Header AddFavourite(string bookId)
        {
            Header header = new(
                url: $"comics/{bookId}/favourite",
                method: HttpMethod.POST);
            return header;
        }


        /// <summary>
        /// 分类搜索
        /// </summary>
        /// <param name="page"></param>
        /// <param name="categories">本子标签</param>
        /// <param name="sort">排序  </param>
        /// <returns></returns>
        public static Header CategoriesSearch(string categories, sort sort, int page = 1)
        {
            Header header = new(url: $"comics?page={page.ToString()}&c={UrlEncode(categories)}&s={sort.ToString()}");
            return header;
        }

        /// <summary>
        /// 高级搜索
        /// </summary>
        /// <param name="categories">上同</param>
        /// <param name="keyword">上同</param>
        /// <param name="page">上同</param>
        /// <param name="sort">上同</param>
        /// <returns></returns>
        public static Header AdvancedSearch(string categories, sort sort, string keyword = "", int page = 1)
        {
            JObject jd = new()
            {
                ["categories"] = UrlEncode(categories),
                ["keyword"] = UrlEncode(keyword),
                ["sort"] = sort.ToString()
            };
            Header header = new(
                url: $"comics/advanced-search?page={page}",
                method: HttpMethod.POST,
                param: jd.ToString());

            return header;
        }

        /// <summary>
        /// 普通搜索
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Header Search(string keyword, int page = 1)
        {
            Header header = new(url: $"comics/search?page={page.ToString()}&q={UrlEncode(keyword)}");
            return header;
        }

        /// <summary>
        /// 排行榜
        /// </summary>
        /// <param name="day"> H24  D7  D30</param>
        /// <returns></returns>
        public static Header Rank(tt tt)
        {
            Header header = new(url: $"comics/leaderboard?tt={tt.ToString()}&ct=VC");
            return header;
        }

        /// <summary>
        /// 通过bookId查找一本书
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public static Header GetComicsBook(string bookId)
        {
            Header header = new(url: $"comics/{bookId}");
            return header;
        }

        /// <summary>
        /// 看了這本子的人也在看
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public static Header Recommendation(string bookId)
        {
            Header header = new(url: $"comics/{bookId}/recommendation");
            return header;
        }

        /// <summary>
        /// 获取本子的章节信息
        /// docs里的_id order 需要记住
        /// 下面的函数需要使用
        /// 
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Header GetComicsBookEps(string bookId, int page = 1)
        {
            Header header = new(url: $"comics/{bookId}/eps?page={page.ToString()}");
            return header;
        }


        /// <summary>
        /// 获取本子里某一章节里某一页的所有图片信息
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="epsId">查看上面那个函数 </param>
        /// <returns></returns>
        public static Header GetComicsBookOrder(string bookId, int epsId, int page = 1)
        {
            Header header = new(url: $"comics/{bookId}/order/{epsId.ToString()}/pages?page={page.ToString()}");
            return header;
        }

        /// <summary>
        /// 获取热词
        /// </summary>
        /// <returns></returns>
        public static Header GetKeywords()
        {
            Header header = new(url: "keywords");
            return header;
        }

        /// <summary>
        /// 随机一个本子
        /// </summary>
        /// <returns></returns>
        public static Header GetRandom()
        {
            Header header = new(url: "comics/random");
            return header;
        }

        /// <summary>
        /// 本子神推荐
        /// </summary>
        /// <returns></returns>
        public static Header GetCollections()
        {
            Header header = new(url: "collections");
            return header;
        }

        /// <summary>
        /// 大家都在看
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Header EverybodyLoves(int page = 1)
        {
            Header header = new(url: $"comics?page={page.ToString()}&c=%E5%A4%A7%E5%AE%B6%E9%83%BD%E5%9C%A8%E7%9C%8B&s=ld");
            return header;
        }


        /// <summary>
        /// 下载一个图片
        /// 图片信息里包含里此两个参数
        /// </summary>
        /// <param name="fileServer"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string DownloadBook(string fileServer, string path)
        {

            //使用HttpClient WebClient HttpWebRequest 都可以，不需要设置header
            return $"{fileServer}/static/{path}";
        }

        /// <summary>
        /// 获取某个本子的评论
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Header GetComments(string bookId = "5822a6e3ad7ede654696e482" /*此为哔咔留言板默认的ID*/, int page = 1)
        {
            Header header = new(url: $"comics/{bookId}/comments?page={page.ToString()}");
            return header;
        }

        /// <summary>
        /// 查看子评论
        /// </summary>
        /// <param name="comentId"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Header GetCommentsChildren(string comentId, int page = 1)
        {
            Header header = new(url: $"comments/{comentId}/childrens?page={page.ToString()}");
            return header;
        }

        /// <summary>
        /// 点赞某个评论
        /// 对已经点赞过的发送会取消点赞
        /// 可通过评论里isLiked字段进行判断
        /// 返回的数据里["data"]["action"]也会告诉是点赞还是取消
        /// 
        /// </summary>
        /// <param name="comentId"></param>
        /// <returns></returns>
        public static Header LikeComment(string comentId)
        {
            Header header = new(
                url: $"comments/{comentId}/like",
                method: HttpMethod.POST);
            return header;
        }


        /// <summary>
        /// 发送评论
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="content">评论内容</param>
        /// <returns></returns>
        public static Header SendComment(string content, string bookId = "5822a6e3ad7ede654696e482" /*此为哔咔留言板默认的ID*/)
        {
            JObject jd = new()
            {
                ["content"] = content
            };

            Header header = new(
                url: $"comics/{bookId}/comments",
                method: HttpMethod.POST,
                param: jd.ToString());
            return header;
        }

        /// <summary>
        /// 发送子评论
        /// </summary>
        /// <param name="comentId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static Header SendCommentChild(string comentId, string content)
        {
            JObject jd = new()
            {
                ["content"] = content
            };

            Header header = new(
                url: $"comments/{comentId}",
                method: HttpMethod.POST,
                param: jd.ToString());
            return header;
        }

        #endregion

    }
}
