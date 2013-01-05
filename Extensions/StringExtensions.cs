using System;
using System.Collections.Generic;

namespace dewitcher.Extensions
{
    /// <summary>
    /// Useful string extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if the string starts with a given string
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="__expression"></param>
        /// <returns></returns>
        public static bool _StartsWith(this string __str, string __expression)
        {
            string str = "";
            for (int i = 0; i < (__expression.Length); i++)
            {
                str += __str[i];
                if (str == __expression) return true;
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
            for (int i = ((__str.Length - 1) - (__expression.Length - 1)); i == (__str.Length - 1); i++)
            {
                str += __str[i];
                if (str == __expression) return true;
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
            return __str[__null_based_index];
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
                string str = string.Empty;
                for (int i = 0; i < __null_based_index; i++) str += __str[i];
                for (int i = __null_based_index + 1; i < __str.Length; i++) str += __str[i];
                return str;
            }
            else return __str;
        }
        /// <summary>
        /// Returns a part of a string
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="start">start-index</param>
        /// <param name="end">end-index</param>
        /// <returns></returns>
        public static string _Substring(this string __str, int start, int end = -1)
        {
            if (end != -1)
            {
                if (start < end && end <= __str.Length - 1)
                {
                    string str = string.Empty;
                    for (int i = start; i < end; i++) str += __str[i];
                    return str;
                }
                else return __str;
            }
            else
            {
                if (start < __str.Length - 1)
                {
                    string str = string.Empty;
                    for (int i = start; i < str.Length; i++) str += __str[i];
                    return str;
                }
                else return __str;
            }
        }
        /// <summary>
        /// Substring Backup
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string _Substring_Test(this string __str, int start, int end = -1)
        {
            if (end != -1)
            {
                if (start < end && end < __str.Length)
                {
                    string str = string.Empty;
                    for (int i = start; i < end; ++i) str += __str[i];
                    return str;
                }
                else return __str;
            }
            else
            {
                if (start < __str.Length)
                {
                    string str = string.Empty;
                    for (int i = start; i < str.Length - 1; ++i) str += __str[i];
                    return str;
                }
                else return __str;
            }
        }
    }
}
