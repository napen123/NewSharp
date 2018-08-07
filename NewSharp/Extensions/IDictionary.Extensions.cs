using System.Collections.Generic;

namespace NewSharp.Extensions
{
    public static class IDictionaryExtensions
    {
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue newValue)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            dict.Add(key, newValue);

            return newValue;
        }

        public static TValue GetOrAddDefault<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            dict.Add(key, default);

            return default;
        }
    }
}