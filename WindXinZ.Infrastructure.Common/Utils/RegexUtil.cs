using System.Text.RegularExpressions;

namespace WindXinZ.Infrastructure.Common.Utils
{
    /// <summary>
    /// 正则帮助类
    /// </summary>
    public static class RegexUtil
    {
        /// <summary>
        /// 正则匹配
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static bool IsMatch(this string input, string pattern, RegexOptions options)
        {
            return Regex.IsMatch(input, pattern, options);
        }
        public static bool IsMatch(this string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }
    }
}
