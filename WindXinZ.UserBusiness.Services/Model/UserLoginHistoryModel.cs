using RainHyacinth.Lite.Imp;

namespace WindXinZ.UserBusiness.BLL.Model
{
    /// <summary>
    /// 用户登录历史记录
    /// </summary>
    public class UserLoginHistoryModel : RainLite
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 上一次登录时间
        /// </summary>
        public long LastLoginTime { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public long LoginTime { get; set; }
    }
}
