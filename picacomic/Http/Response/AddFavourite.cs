

using Newtonsoft.Json;

namespace Picacomic.Http.Response
{
    /// <summary>
    /// 添加收藏
    /// </summary>
   public  class AddFavourite
    {
        /// <summary>
        /// 收藏or取消
        /// un_favourite
        /// favourite
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 取消收藏
        /// </summary>
        public bool Undo 
        {
            get => Action == "un_favourite";
        }
    }
}
