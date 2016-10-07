using System.Reflection;
using RainHyacinth.Inject;

namespace WindXinZ.UserBusiness.BLL
{
    /// <summary>
    /// 用户业务层依赖注入
    /// </summary>
    public class WindXinZUserBusinessBLLDependencyInjectRegister : IDependencyInjectRegister
    {
        public void Register(IInjectContainerBuilder builder)
        {
            DependencyInjectRegisterUtil.RegisterIDependencyInject(Assembly.Load("WindXinZ.UserBusiness.BLL"), builder);
        }
    }
}
