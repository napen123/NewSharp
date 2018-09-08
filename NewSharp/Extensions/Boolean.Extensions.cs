using System.Runtime.CompilerServices;

namespace NewSharp.Extensions
{
    public static class BooleanExtensions
    {
        #region Integer Conversions

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(this bool b)
        {
            return b ? (sbyte) 1 : (sbyte) 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToShort(this bool b)
        {
            return b ? (short) 1 : (short) 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt(this bool b)
        {
            return b ? 1 : 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToLong(this bool b)
        {
            return b ? 1L : 0L;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(this bool b)
        {
            return b ? (byte) 1 : (byte) 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUShort(this bool b)
        {
            return b ? (ushort) 1 : (ushort) 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt(this bool b)
        {
            return b ? 1u : 0u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToULong(this bool b)
        {
            return b ? 1UL : 0UL;
        }

        #endregion
    }
}
