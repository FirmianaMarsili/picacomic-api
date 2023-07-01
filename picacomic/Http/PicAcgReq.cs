using Newtonsoft.Json.Linq;
using Picacomic.Http.Request;
using Picacomic.Http.Response;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Picacomic
{
    /// <summary>   
    /// 哔咔一般都是以40为基准   例：1-40张图片为一页，1-40章节为一页。 如果有特殊情况，可以查看返回数据中的 limit 字段，此为限制每页的最大数量
    /// </summary>
    public partial class PicAcgReq
    {
        #region Function-Ex

        /// <summary>
        /// 排序规则
        /// </summary>
        public enum Sort
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
        public enum Gender
        {
            m,
            f,
            bot
        }

        /// <summary>
        /// 排行榜分类
        /// </summary>
        public enum TT
        {
            /// <summary>
            /// 今日
            /// </summary>
            H24,  //
            /// <summary>
            /// 本周
            /// </summary>
            D7,
            /// <summary>
            /// 本月
            /// </summary>
            D30
        }


        /// <summary>
        /// 如果注册账号或者登陆时，账号是邮箱格式，这里应该特别处理一下@
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
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
        public static async Task<Login> Login(string email, string password)
        {
            LoginReq req = new LoginReq()
            {
                Email = email,
                Password = password
            };
            Header header = new Header("auth/sign-in", req);
            return await HttpWeb.SendAsync<Login>(header);
        }
        //yyyy/mm/dd

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="email">账号</param>
        /// <param name="password">密码</param>
        /// <param name="name">昵称</param>
        /// <param name="birthday">生日  格式为：//yyyy/MM/dd</param>
        /// <param name="gender">性别</param>
        /// <param name="question1">问题1</param>
        /// <param name="answer1">答案1</param>
        /// <param name="question2"></param>
        /// <param name="answer2"></param>
        /// <param name="question3"></param>
        /// <param name="answer3"></param>
        /// <returns></returns>
        public static async Task<Register> Register(string email, string password, string name, DateTimeOffset birthday, Gender gender, string question1, string answer1, string question2, string answer2, string question3, string answer3)
        {
            RegisterReq req = new RegisterReq()
            {
                Email = email,
                Password = password,
                Name = name,
                Birthday = birthday.ToString("yyyy/MM/dd"),
                Gender = gender.ToString(),
                Question1 = question1,
                Answer1 = answer1,
                Question2 = question2,
                Answer2 = answer2,
                Question3 = question3,
                Answer3 = answer3,
            };
            Header header = new Header("auth/register", req);
            return await HttpWeb.SendAsync<Register>(header);
        }


        /// <summary>
        /// 个人资料
        /// </summary>
        /// <param name="id">传入_id时则查询对应_id,不传时则查询自己</param>
        public static async Task<Profile> Profile(string id = "")
        {
            string url = $"users/{(id == "" ? "" : id + "/")}profile";
            Header header = new Header(url);
            return await HttpWeb.SendAsync<Profile>(header);
        }


        /// <summary>
        /// 签到
        /// </summary>
        public static async Task<Punch> Punch()
        {
            Header header = new Header("users/punch-in", null);
            return await HttpWeb.SendAsync<Punch>(header);
        }

        /// <summary>
        /// 聊天室
        /// </summary>
        /// <returns></returns>
        public static async Task<Chat> GetChat()
        {
            Header header = new Header("chat");
            return await HttpWeb.SendAsync<Chat>(header);
        }

        /// <summary>
        /// 我的评论
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static async Task<MyComments> GetMyComments(int page = 1)
        {
            Header header = new Header($"users/my-comments?page={page.ToString()}");
            return await HttpWeb.SendAsync<MyComments>(header);
        }


        #endregion


        #region Book 

        /// <summary>
        /// 获取App基本信息
        /// </summary>
        /// <returns></returns>
        public static async Task<Platform> GetPlatform()
        {
            Header header = new Header("init?platform=android");
            return await HttpWeb.SendAsync<Platform>(header);
        }

        /// <summary>
        /// 获取app主页上几大分类
        /// </summary>
        /// <returns></returns>
        public static async Task<Category> GetCategory()
        {
            Header header = new Header("categories");
            return await HttpWeb.SendAsync<Category>(header);
        }

        /// <summary>
        /// 通过分类搜索
        /// </summary>
        /// <param name="page"></param>
        /// <param name="categories">本子分类</param>
        /// <param name="sort">排序  </param>
        /// <returns></returns>
        public static async Task<CategoriesSearch> CategoriesSearch(string categories, int page = 1, Sort sort = Sort.ua)
        {
            Header header = new Header($"comics?page={page.ToString()}&c={UrlEncode(categories)}&s={sort.ToString()}");
            return await HttpWeb.SendAsync<CategoriesSearch>(header);
        }

        /// <summary>
        /// 关键词搜索
        /// </summary>
        /// <param name="keyword">关键字或者标签</param>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public static async Task<AdvancedSearch> AdvancedSearch(string keyword, int page = 1, Sort sort = Sort.ua)
        {
            AdvancedSearchReq req = new AdvancedSearchReq()
            {
                Keyword = keyword,
                Sort = sort.ToString()
            };
            Header header = new Header($"comics/advanced-search?page={page}", req);
            return await HttpWeb.SendAsync<AdvancedSearch>(header);
        }

        /// <summary>
        /// 普通搜索
        /// 一般app在不切换排序时是使用的这个接口
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static async Task<Search> Search(string keyword, int page = 1)
        {
            Header header = new Header($"comics/search?page={page.ToString()}&q={UrlEncode(keyword)}");
            return await HttpWeb.SendAsync<Search>(header);
        }

        /// <summary>
        /// 获取收藏
        /// </summary>
        /// <param name="page"></param>        
        public static async Task<Favourite> Favourite(Sort sort = Sort.ua, int page = 1)
        {
            Header header = new Header($"users/favourite?s={sort.ToString()}&page={page.ToString()}");
            return await HttpWeb.SendAsync<Favourite>(header);
        }

        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public static async Task<AddFavourite> AddFavourite(string bookId)
        {
            Header header = new Header($"comics/{bookId}/favourite", null);
            return await HttpWeb.SendAsync<AddFavourite>(header);
        }        

        /// <summary>
        /// 排行榜
        /// </summary>
        /// <param name="day"> H24  D7  D30</param>
        /// <returns></returns>
        public static async Task<Rank> Rank(TT tt)
        {
            Header header = new Header($"comics/leaderboard?tt={tt.ToString()}&ct=VC");
            return await HttpWeb.SendAsync<Rank>(header);
        }

        /// <summary>
        /// 通过bookId查找一本书
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public static async Task<ComicsBook> GetComicsBook(string bookId)
        {
            Header header = new Header($"comics/{bookId}");
            return await HttpWeb.SendAsync<ComicsBook>(header);
        }

        /// <summary>
        /// 看了這本子的人也在看
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public static async Task<Recommendation> Recommendation(string bookId)
        {
            Header header = new Header($"comics/{bookId}/recommendation");
            return await HttpWeb.SendAsync<Recommendation>(header);
        }

        /// <summary>
        /// 获取本子的章节信息
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static async Task<ComicsBookEps> GetComicsBookEps(string bookId, int page = 1)
        {
            Header header = new Header($"comics/{bookId}/eps?page={page.ToString()}");
            return await HttpWeb.SendAsync<ComicsBookEps>(header);
        }


        /// <summary>
        /// 获取本子里某一章节里某一页的所有图片信息
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="epsId">查看上面那个函数 </param>
        /// <returns></returns>
        public static async Task<ComicsBookOrder> GetComicsBookOrder(string bookId, int epsId, int page = 1)
        {
            Header header = new Header($"comics/{bookId}/order/{epsId.ToString()}/pages?page={page.ToString()}");
            return await HttpWeb.SendAsync<ComicsBookOrder>(header);
        }

        /// <summary>
        /// 获取热词
        /// </summary>
        /// <returns></returns>
        public static async Task<Keywords> GetKeywords()
        {
            Header header = new Header("keywords");
            return await HttpWeb.SendAsync<Keywords>(header);
        }

        /// <summary>
        /// 随机一个本子
        /// </summary>
        /// <returns></returns>
        public static async Task<Http.Response.Random> GetRandom()
        {
            Header header = new Header("comics/random");
            return await HttpWeb.SendAsync<Http.Response.Random>(header);
        }

        /// <summary>
        /// 本子神推荐
        /// </summary>
        /// <returns></returns>
        public static async Task<Collections> GetCollections()
        {
            Header header = new Header("collections");
            return await HttpWeb.SendAsync<Collections>(header);
        }

        /// <summary>
        /// 大家都在看
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static async Task<EverybodyLoves> EverybodyLoves(int page = 1)
        {
            Header header = new Header($"comics?page={page.ToString()}&c=%E5%A4%A7%E5%AE%B6%E9%83%BD%E5%9C%A8%E7%9C%8B&s=ld");
            return await HttpWeb.SendAsync<EverybodyLoves>(header);
        }

        /// <summary>
        /// 获取某个本子的评论
        /// </summary>
        /// <param name="bookId">5822a6e3ad7ede654696e482 此为哔咔留言板默认的ID</param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static async Task<Comments> GetComments(string bookId = "5822a6e3ad7ede654696e482", int page = 1)
        {
            Header header = new Header($"comics/{bookId}/comments?page={page.ToString()}");
            return await HttpWeb.SendAsync<Comments>(header);
        }

        /// <summary>
        /// 查看子评论
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static async Task<CommentsChildren> GetCommentsChildren(string commentId, int page = 1)
        {
            Header header = new Header($"comments/{commentId}/childrens?page={page.ToString()}");
            return await HttpWeb.SendAsync<CommentsChildren>(header);
        }

        /// <summary>
        /// 点赞某个评论
        /// 对已经点赞过的发送会取消点赞
        /// 可通过评论里isLiked字段进行判断
        /// 返回的数据里["data"]["action"]也会告诉是点赞还是取消        
        /// </summary>
        /// <param name="commentId"></param>
        /// <returns></returns>
        public static async Task<LikeComment> LikeComment(string commentId)
        {
            Header header = new Header($"comments/{commentId}/like", null);
            return await HttpWeb.SendAsync<LikeComment>(header);
        }


        /// <summary>
        /// 发送评论
        /// </summary>
        /// <param name="bookId">5822a6e3ad7ede654696e482 此为哔咔留言板默认的ID</param>
        /// <param name="content">评论内容</param>
        /// <returns></returns>
        public static async Task<SendComment> SendComment(string content, string bookId = "5822a6e3ad7ede654696e482")
        {
            SendCommentReq req = new SendCommentReq()
            {
                Content = content
            };
            Header header = new Header($"comics/{bookId}/comments", req);
            return await HttpWeb.SendAsync<SendComment>(header);
        }

        /// <summary>
        /// 发送子评论
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async Task<SendComment> SendCommentChild(string commentId, string content)
        {
            SendCommentReq child = new SendCommentReq()
            {
                Content = content
            };
            Header header = new Header($"comments/{commentId}", child);
            return await HttpWeb.SendAsync<SendComment>(header);
        }

        #endregion

        /// <summary>
        /// 拼接出图片下载地址
        /// </summary>
        /// <param name="fileServer"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFilePath(string fileServer, string path)
        {
            //使用HttpClient WebClient HttpWebRequest 都可以，不需要设置header
            return $"{fileServer}/static/{path}";
        }

    }
}
