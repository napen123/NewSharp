using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Sorting;
using NewSharp.Extensions;

namespace NewSharpTesting.Sorting
{
    [TestClass]
    public class HeapSortTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            var arr = new[] {73, 54, 14, 94, 41, 12, 56, 21, 44};

            HeapSort.Sort(arr);
            Assert.IsTrue(new[] {12, 14, 21, 41, 44, 54, 56, 73, 94}.AllElementsEqualUnchecked(arr));
        }
    }
}
