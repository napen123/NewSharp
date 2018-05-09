using System;
using System.Collections.Generic;

namespace NewSharp.Extensions
{
    public static class IListExtensions
    {
        public static bool AllElementsEqual<T>(this IList<T> a, IList<T> b)
            where T: IComparable<T>
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a));

            if (b == null)
                throw new ArgumentNullException(nameof(b));

            var count = a.Count;

            if (count != b.Count)
                return false;

            for (var i = 0; i < count; i++)
            {
                if (a[i].CompareTo(b[i]) != 0)
                    return false;
            }

            return true;
        }

        public static bool AllElementsEqualUnchecked<T>(this IList<T> a, IList<T> b)
            where T : IComparable<T>
        {
            var count = a.Count;

            if (count != b.Count)
                return false;

            for (var i = 0; i < count; i++)
            {
                if (a[i].CompareTo(b[i]) != 0)
                    return false;
            }

            return true;
        }

        public static void Swap<T>(this IList<T> list, int a, int b)
        {
            if(list == null)
                throw new ArgumentNullException(nameof(list));

            var count = list.Count;

            if (a >= count)
                throw new ArgumentException("Index out of range.", nameof(a));

            if (b >= count)
                throw new ArgumentException("Index out of range.", nameof(b));

            if (a == b)
                return;

            var tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }

        public static bool TrySwap<T>(this IList<T> list, int a, int b)
        {
            if (list == null)
                return false;

            var count = list.Count;

            if (a >= count)
                return false;

            if (b >= count)
                return false;

            if (a == b)
                return true;

            var tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;

            return true;
        }

        public static void SwapUnchecked<T>(this IList<T> list, int a, int b)
        {
            if (a == b)
                return;

            var tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }

        public static void Swap<T>(this IList<T> list, T a, T b)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            var aIndex = list.IndexOf(a);

            if (aIndex == -1)
                throw new ArgumentException("Provided item does not exist in list.", nameof(a));

            var bIndex = list.IndexOf(b);

            if (bIndex == -1)
                throw new ArgumentException("Provided item does not exist in list.", nameof(b));

            if (aIndex == bIndex)
                return;

            var tmp = list[aIndex];
            list[aIndex] = list[bIndex];
            list[bIndex] = tmp;
        }

        public static bool TrySwap<T>(this IList<T> list, T a, T b)
        {
            if (list == null)
                return false;

            var aIndex = list.IndexOf(a);

            if (aIndex == -1)
                return false;

            var bIndex = list.IndexOf(b);

            if (bIndex == -1)
                return false;

            if (aIndex == bIndex)
                return true;

            var tmp = list[aIndex];
            list[aIndex] = list[bIndex];
            list[bIndex] = tmp;

            return true;
        }

        public static void SwapUnchecked<T>(this IList<T> list, T a, T b)
        {
            var aIndex = list.IndexOf(a);
            var bIndex = list.IndexOf(b);

            if (aIndex == bIndex)
                return;

            var tmp = list[aIndex];
            list[aIndex] = list[bIndex];
            list[bIndex] = tmp;
        }
    }
}
