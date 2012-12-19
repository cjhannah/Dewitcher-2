using System;
using System.Collections.Generic;

namespace dewitcher
{
    public static class StringExtensions
    {
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
        public static char _GetCharAt(this string __str, int __null_based_index)
        {
            return __str[__null_based_index];
        }
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
        public static string _Substring(this string __str, int start, int? end = null)
        {
            if (end != null)
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
