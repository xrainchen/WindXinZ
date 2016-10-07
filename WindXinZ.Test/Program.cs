

using System;
using RainHyacinth.Kernel.Imp;
using WindXinZ.UserBusiness.BLL.Model;
using WindXinZ.UserBusiness.BLL.Services;

namespace WindXinZ.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            KernelManager.Instance.InitLoad();
            var rainWorkContext = new RainWorkContext(new object());
            KernelManager.Instance.Begin_Request(rainWorkContext);
            var userService = KernelManager.Instance.DependencyInjectHub.Resolve<IUserService>();
            userService.AddUser(new UserModel()
            {
                Name = "rain",
                Sex = SexEnum.Man,
                Age = 10,
                IdCardNo = "350122199007144133",
                Password = "123456a",
                UserName = "xrainchen",
                NickName = "RHyacinth",
                HeadPic = "http://www.baidu.com/xsfsfs.jpg",
                UserType = UserTypeEnum.Member,
                PhoneNo = "18059147746"

            });
            KernelManager.Instance.End_Request(rainWorkContext);
            Console.WriteLine("ok");
            Console.Read();

        }
    }
}
