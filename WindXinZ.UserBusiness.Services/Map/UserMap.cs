using RainHyacinth.Lite;
using RainHyacinth.Lite.Imp;
using WindXinZ.UserBusiness.BLL.Model;

namespace WindXinZ.UserBusiness.BLL.Map
{
    /// <summary>
    /// 用户表映射
    /// </summary>
    public class UserMap : RainLiteMap<UserModel>, IRainLiteMap
    {
        public UserMap() : base()
        {
            Property(p => p.Name).HasMaxLength(32);
            Property(p => p.IdCardNo).HasMaxLength(32);
            Property(p => p.Password).HasMaxLength(64);
            Property(p => p.UserName).HasMaxLength(32);
            Property(p => p.NickName).HasMaxLength(32);
            Property(p => p.HeadPic).HasMaxLength(32);
            Property(p => p.PhoneNo).HasMaxLength(32);
        }
    }
}
