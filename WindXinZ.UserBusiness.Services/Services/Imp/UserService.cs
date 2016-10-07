using System;
using System.Linq;
using RainHyacinth;
using RainHyacinth.Lite;
using RainHyacinth.Lite.Services.Imp;
using WindXinZ.Infrastructure.Common.Utils;
using WindXinZ.UserBusiness.BLL.Model;

namespace WindXinZ.UserBusiness.BLL.Services.Imp
{
    /// <summary>
    /// 用户服务实现类
    /// </summary>
    public class UserService : BaseService<UserModel>, IUserService
    {
        public UserService(Lazy<IRepository<UserModel>> repository) : base(repository)
        {
        }
        /// <summary>
        /// 空值错误码
        /// </summary>
        const string NullEntityCode = "601000";
        /// <summary>
        /// 验证性错误
        /// </summary>
        const string ValiadError = "601001";
        private static readonly object Lock = new object();
        public void AddUser(UserModel model)
        {
            if (null == model) throw new RainHyacinthException(NullEntityCode, "添加用户不能为空");
            if (!model.Name.IsMatch("^.{2,20}$"))
                throw new RainHyacinthException(ValiadError, "名字在2-20个字符之间");
            if (!model.IdCardNo.IsMatch(@"^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$|^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$"))
                throw new RainHyacinthException(ValiadError, "请输入15位或者18位身份证号码");
            if (!model.PhoneNo.IsMatch(@"^1(3[0-9]|4[57]|5[0-35-9]|7[01678]|8[0-9])\d{8}$"))
                throw new RainHyacinthException(ValiadError, "手机号码格式不对");
            if (!model.NickName.IsMatch("^.{2,20}$"))
                throw new RainHyacinthException(ValiadError, "昵称在2-20个字符之间");
            model.Password = EncryptPassword(model.Password);
            if (UserIsExist(model.UserName))
                throw new RainHyacinthException(ValiadError, $"用户名：{model.UserName}已被注册，请更换其他用户名试试");
            lock (Lock)
            {
                if (UserIsExist(model.UserName))
                    throw new RainHyacinthException(ValiadError, $"用户名：{model.UserName}已被注册，请更换其他用户名试试");
                Add(model);
            }
        }

        public string EncryptPassword(string password)
        {
            if (!password.IsMatch("^(?=.*?[a-zA-Z])(?=.*?[0-6])[!\"#$%&'()*+,\\-./:;<=>?@[\\]^_`{|}~A-Za-z0-9]{6,16}$"))
                throw new RainHyacinthException(ValiadError, "请输入6-16位密码，必须包含数字和字母");
            return (password + "!@#$").Md5();
        }

        public bool UserIsExist(string userName)
        {
            return Repository.Value.Table.Any(p => p.UserName == userName);
        }

        public void UpgradedUserToSuppliers(string userId)
        {
            var record = Repository.Value.Get(userId);
            record.UserType = record.UserType | UserTypeEnum.Suppliers;
            Repository.Value.Change(record);
        }

        public override UserModel Get(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
