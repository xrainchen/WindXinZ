using RainHyacinth.Lite;
using RainHyacinth.Lite.Imp;
using WindXinZ.UserBusiness.BLL.Model;

namespace WindXinZ.UserBusiness.BLL.Map
{
    /// <summary>
    /// 用户登录历史记录
    /// </summary>
    public class UserLoginHistoryMap : RainLiteMap<UserLoginHistoryModel>, IRainLiteMap
    {
        public UserLoginHistoryMap() : base()
        {
            Property(p => p.UserId).HasMaxLength(32);
            Property(p => p.UserName).HasMaxLength(32);
        }
    }
}
