using System.Collections.Generic;

namespace NewSharp.Extensions
{
    public static class StackExtensions
    {
        public static bool TryPeek<T>(this Stack<T> stack, out T? item)
            where T: class
        {
            try
            {
                item = stack.Peek();

                return true;
            }
            catch
            {
                item = default;

                return false;
            }
        }

        public static bool TryPop<T>(this Stack<T> stack, out T? item)
            where T: class
        {
            try
            {
                item = stack.Pop();

                return true;
            }
            catch
            {
                item = default;

                return false;
            }
        }
    }
}
