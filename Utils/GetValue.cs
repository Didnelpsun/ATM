using System;

namespace ATM
{
    partial class Utils
    {
        public static string GetID()
        {
            return ((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString();
        }
    }
}
