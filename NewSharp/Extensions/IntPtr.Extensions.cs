using System;
using System.Text;

namespace NewSharp.Extensions
{
    public static class IntPtrExtensions
    {
        public static unsafe string IntoString(this IntPtr ptr, Encoding encoding)
        {
            if (ptr == IntPtr.Zero)
                return null;

            var p = (byte*) ptr;
            var b = (byte*) ptr;

            while (*b != 0)
                b++;

            return encoding.GetString(p, (int) (b - p));
        }

        public static unsafe string IntoString(this IntPtr ptr, Encoding encoding, int length)
        {
            if (ptr == IntPtr.Zero)
                return null;

            var p = (byte*) ptr;
            var b = ((byte*) ptr) + length;

            return encoding.GetString(p, (int) (b - p));
        }
    }
}
