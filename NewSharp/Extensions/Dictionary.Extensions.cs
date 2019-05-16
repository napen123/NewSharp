using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace NewSharp.Extensions
{
    public static class DictionaryExtensions
    {
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue newValue)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            dict.Add(key, newValue);

            return newValue;
        }

        public static TValue GetOrAddLazy<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, Func<TValue> newValue)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            var calculatedValue = newValue();
            dict.Add(key, calculatedValue);

            return calculatedValue;
        }

        public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue newValue)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            dict.Add(key, newValue);

            return newValue;
        }

        public static TValue GetOrAddLazy<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, Func<TValue> newValue)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            var calculatedValue = newValue();
            dict.Add(key, calculatedValue);

            return calculatedValue;
        }

        public static TValue GetOrAddDefault<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            dict.Add(key, default);

            return default;
        }

        public static TValue GetOrAddDefault<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
        {
            if (dict.TryGetValue(key, out var value))
                return value;

            dict.Add(key, default);

            return default;
        }

        public static TValue GetOrAddDefault<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> dict, TKey key)
        {
            return dict.GetOrAdd(key, default(TValue));
        }
    }
}