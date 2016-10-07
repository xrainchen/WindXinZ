using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WindXinZ.Infrastructure.Common.Utils
{
    /// <summary>
    /// MD5加密算法
    /// </summary>
    public static class Md5Util
    {
        /// <summary>
        /// Md5算法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md5(this string str)
        {
            return Encoding.UTF8.GetBytes(str).Md5();
        }
        /// <summary>
        /// Md5算法
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding">编码方式</param>
        /// <returns></returns>
        public static string Md5(this string str, Encoding encoding)
        {
            return encoding.GetBytes(str).Md5();
        }
        /// <summary>
        /// Md5算法
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string Md5(this byte[] bytes)
        {
            var md5 = new MD5CryptoServiceProvider();
            var targetData = md5.ComputeHash(bytes);
            return targetData.Aggregate<byte, string>(null, (current, t) => current + t.ToString("x"));
        }
    }
}
