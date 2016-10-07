using System;
using RainHyacinth.Lite.Imp;

namespace WindXinZ.UserBusiness.BLL.Model
{
    /// <summary>
    /// 用户模型
    /// </summary>
    public class UserModel : RainLite
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public SexEnum Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCardNo { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string HeadPic { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public UserTypeEnum UserType { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNo { get; set; }


    }
    /// <summary>
    /// 性别
    /// </summary>
    public enum SexEnum
    {
        /// <summary>
        /// 男性
        /// </summary>
        Man = 1,
        /// <summary>
        /// 女性
        /// </summary>
        Women = 2,
        /// <summary>
        /// 未知
        /// </summary>
        UnKnow = 3
    }
    /// <summary>
    /// 用户类型
    /// </summary>
    [Flags]
    public enum UserTypeEnum
    {
        /// <summary>
        /// 会员
        /// </summary>
        Member = 1,
        /// <summary>
        /// 供货商
        /// </summary>
        Suppliers = 2
    }
}
