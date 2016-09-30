using System;

namespace WindXinZ.UserBusiness.Services.Model
{
    /// <summary>
    /// 用户模型
    /// </summary>
    public class UserModel
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
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
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
