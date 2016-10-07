using RainHyacinth.Inject;
using RainHyacinth.Lite.Services;
using WindXinZ.UserBusiness.BLL.Model;

namespace WindXinZ.UserBusiness.BLL.Services
{
    /// <summary>
    /// 用户服务接口
    /// </summary>
    public interface IUserService : IBaseService<UserModel>, IUintOfWorkDependencyInject
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="model"></param>
        void AddUser(UserModel model);
        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string EncryptPassword(string password);
        /// <summary>
        /// 根据用户名查找用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        bool UserIsExist(string userName);
        /// <summary>
        /// 升级用户成供货商
        /// </summary>
        /// <param name="userId"></param>
        void UpgradedUserToSuppliers(string userId);
    }


}
