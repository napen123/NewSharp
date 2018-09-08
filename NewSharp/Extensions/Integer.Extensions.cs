using System.Runtime.CompilerServices;

namespace NewSharp.Extensions
{
    public static class IntegerExtensions
    {
        #region HasFlag

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this sbyte i, sbyte flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this short i, short flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this int i, int flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this long i, long flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this byte i, byte flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this ushort i, ushort flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this uint i, uint flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this ulong i, ulong flag)
        {
            return (i & flag) != 0;
        }

        #endregion

        #region Conversions

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this sbyte i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this short i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this int i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this long i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this byte i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this ushort i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this uint i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this ulong i)
        {
            return i != 0;
        }

        #endregion
    }
}
