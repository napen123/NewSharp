namespace NewSharp.Numerics
{
    public static class NumberParser
    {
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
