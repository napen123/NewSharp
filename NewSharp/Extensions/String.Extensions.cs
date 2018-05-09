using System;

namespace NewSharp.Extensions
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            
            return new string(arr);
        }

        public static bool IsWhiteSpace(this string str)
        {
            if (str == null)
                return false;

            if (str.Length == 0)
                return true;

            for (var i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                    return false;
            }

            return true;
        }

        public static bool TrySubstring(this string str, int start, out string result)
        {
            if (str == null)
            {
                result = null;

                return false;
            }

            try
            {
                result = str.Substring(start);
                
                return true;
            }
            catch
            {
                result = null;

                return false;
            }
        }

        public static bool TrySubstring(this string str, int start, int length, out string result)
        {
            if (str == null)
            {
                result = null;

                return false;
            }

            try
            {
                result = str.Substring(start, length);

                return true;
            }
            catch
            {
                result = null;

                return false;
            }
        }
    }
}
