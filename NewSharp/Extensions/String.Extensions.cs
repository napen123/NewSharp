﻿using System;

namespace NewSharp.Extensions
{
    public static class StringExtensions
    {
        public static bool IsWhiteSpace(this string str)
        {
            if (str.Length == 0)
                return true;

            for (var i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                    return false;
            }

            return true;
        }

        #region Words

        public static string[] GetWords(this string str)
        {
            return str.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string ConcatWords(this string[] strs)
        {
            return String.Join(" ", strs);
        }

        #endregion

        #region Reverse

        public static unsafe string Reverse(this string str)
        {
            var length = str.Length;

            if (length == 0)
                return str;
            
            if (length >= 25)
                return ReverseLargeUnchecked(str);

            var ret = stackalloc char[length];

            fixed(char* s = str)
            {
                for (var i = 0; i < length; i++)
                    ret[length - i - 1] = s[i];
            }

            return new string(ret, 0, length);
        }

        public static unsafe string ReverseUnchecked(this string str)
        {
            var length = str.Length;
            
            if (length >= 25)
                return ReverseLargeUnchecked(str);

            var ret = stackalloc char[length];

            fixed (char* s = str)
            {
                for (var i = 0; i < length; i++)
                    ret[length - i - 1] = s[i];
            }

            return new string(ret, 0, length);
        }

        public static string ReverseLarge(this string str)
        {
            var length = str.Length;

            if (length == 0)
                return str;

            var c = str.ToCharArray();
            Array.Reverse(c, 0, length);

            return new string(c);
        }

        public static string ReverseLargeUnchecked(this string str)
        {
            var c = str.ToCharArray();
            Array.Reverse(c, 0, str.Length);

            return new string(c);
        }

        #endregion

        #region TrySubstring

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

        #endregion
    }
}
