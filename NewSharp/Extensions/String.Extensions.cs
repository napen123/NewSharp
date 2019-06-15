using System;

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

        #region TryParse

        public static Option<sbyte> TryParseInt8(this string str)
        {
            return sbyte.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<sbyte>();
        }

        public static Option<short> TryParseInt16(this string str)
        {
            return short.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<short>();
        }

        public static Option<int> TryParseInt32(this string str)
        {
            return int.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<int>();
        }

        public static Option<long> TryParseInt64(this string str)
        {
            return long.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<long>();
        }

        public static Option<byte> TryParseUInt8(this string str)
        {
            return byte.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<byte>();
        }

        public static Option<ushort> TryParseUInt16(this string str)
        {
            return ushort.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<ushort>();
        }

        public static Option<uint> TryParseUInt32(this string str)
        {
            return uint.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<uint>();
        }

        public static Option<ulong> TryParseUInt64(this string str)
        {
            return ulong.TryParse(str, out var i)
                ? Option.Some(i)
                : Option.None<ulong>();
        }

        #endregion
    }
}
