using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.Extensions
{
    public static class NumericExtensions
    {
        public static uint MsToHz(this int ms)
        {
            return (uint)(1000 / ms);
        }
        public static uint MsToHz(this uint ms)
        {
            return (uint)(1000 / ms);
        }
    }
}
