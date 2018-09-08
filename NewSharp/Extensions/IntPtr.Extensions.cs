using System;
using System.Text;

namespace NewSharp.Extensions
{
    public static class IntPtrExtensions
    {
        public static unsafe string ToManagedString(this IntPtr ptr, Encoding encoding)
        {
            if (ptr == IntPtr.Zero)
                return null;

            var p = (byte*) ptr;
            var b = (byte*) ptr;

            while (*b != 0)
                b++;

            return encoding.GetString(p, (int) (b - p));
        }

        public static unsafe string ToManagedString(this IntPtr ptr, Encoding encoding, int strLength)
        {
            if (ptr == IntPtr.Zero)
                return null;

            var p = (byte*) ptr;
            var b = (byte*) ptr + strLength;

            return encoding.GetString(p, (int) (b - p));
        }
    }
}
