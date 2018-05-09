using System;
using System.Collections.Generic;

using NewSharp.Extensions;

namespace NewSharp.Sorting
{
    public static class HeapSort
    {
        public static void Sort<T>(IList<T> list)
            where T : IComparable<T>
        {
            if(list == null)
                throw new ArgumentNullException(nameof(list));

            var count = list.Count;

            if (count == 0 || count == 1)
                return;

            for (var i = count / 2 - 1; i >= 0; i--)
                Heapify(list, count, i);

            for (var i = count - 1; i >= 0; i--)
            {
                list.SwapUnchecked(0, i);
                Heapify(list, i, 0);
            }
        }

        public static bool TrySort<T>(IList<T> list)
            where T : IComparable<T>
        {
            if (list == null)
                return false;

            var count = list.Count;

            if (count == 0 || count == 1)
                return true;

            for (var i = count / 2 - 1; i >= 0; i--)
                Heapify(list, count, i);

            for (var i = count - 1; i >= 0; i--)
            {
                list.SwapUnchecked(0, i);
                Heapify(list, i, 0);
            }

            return true;
        }

        private static void Heapify<T>(IList<T> list, int count, int node)
            where T : IComparable<T>
        {
            while (true)
            {
                var largest = node;
                var left = 2 * node + 1;
                var right = 2 * node + 2;

                if (left < count && list[left].CompareTo(list[largest]) > 0)
                    largest = left;

                if (right < count && list[right].CompareTo(list[largest]) > 0)
                    largest = right;

                if (largest != node)
                {
                    list.SwapUnchecked(node, largest);
                    node = largest;

                    continue;
                }

                break;
            }
        }
    }
}
