using System;

namespace NewSharp.Extensions
{
    public static class EnumExtensions
    {
        public static T Parse<T>(string value, bool ignoreCase = false)
        {
            return (T) Enum.Parse(typeof(T), value, ignoreCase);
        }

        public static T ParseChecked<T>(string str, bool ignoreCase = false)
        {
            var type = typeof(T);

            if (!type.IsEnum)
                throw new ArgumentException("The provided type was not an enum.");

            return (T) Enum.Parse(type, str, ignoreCase);
        }

        public static bool TryParse<T>(string str, out T value)
        {
            var type = typeof(T);

            if (!type.IsEnum)
            {
                value = default(T);

                return false;
            }

            value = (T)Enum.Parse(type, str, false);

            return true;
        }

        public static bool TryParse<T>(string str, bool ignoreCase, out T value)
        {
            var type = typeof(T);

            if (!type.IsEnum)
            {
                value = default(T);

                return false;
            }

            value = (T) Enum.Parse(type, str, ignoreCase);

            return true;
        }
    }
}
