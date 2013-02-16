using System;
using System.Collections.Generic;

namespace dewitcher.Extensions
{
    /// <summary>
    /// Useful string extensions
    /// </summary>
    public static class StringExtensions
    {
        public static string rot13(this string str)
        {
            return Crypto.ROT13.encrypt(str);
        }
        public static string rot47(this string str)
        {
            return Crypto.ROT13.encrypt(str);
        }
        public static string md5(this string str)
        {
            return Crypto.MD5.hash(str);
        }
        /// <summary>
        /// Checks if the string starts with a given string
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="__expression"></param>
        /// <returns></returns>
        public static bool _StartsWith(this string __str, string __expression)
        {
            string str = "";
            if (__expression.Length <= __str.Length)
            {
                for (int i = 0; i < (__expression.Length); i++)
                {
                    str += __str[i];
                    if (str == __expression) return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Checks if the string ends with a given string
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="__expression"></param>
        /// <returns></returns>
        public static bool _EndsWith(this string __str, string __expression)
        {
            string str = "";
            if (__expression.Length <= __str.Length)
            {
                for (int i = ((__str.Length - 1) - (__expression.Length - 1)); i == (__str.Length - 1); i++)
                {
                    str += __str[i];
                    if (str == __expression) return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Returns the char at position string[index]
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="__null_based_index"></param>
        /// <returns></returns>
        public static char _GetCharAt(this string __str, int __null_based_index)
        {
            if (__null_based_index >= 0 && __null_based_index < __str.Length)
                return __str[__null_based_index];
            else
            {
                Core.Bluescreen.Init("string._GetCharAt", "__null_based_index must be greater then -1 and lower then __str.Length!");
                return char.MinValue;
            }
        }
        /// <summary>
        /// Removes the char at position string[index]
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="__null_based_index"></param>
        /// <returns></returns>
        public static string _RemoveCharAt(this string __str, int __null_based_index)
        {
            if (__null_based_index < __str.Length)
            {
                string str = "";
                for (int i = 0; i < __null_based_index; i++) str += __str[i];
                for (int i = __null_based_index + 1; i < __str.Length; i++) str += __str[i];
                return str;
            }
            else
            {
                Core.Bluescreen.Init("string._GetCharAt", "__null_based_index must be greater then -1 and lower then __str.Length!");
                return __str;
            }
        }
    }
}
