using System;
using System.Runtime.CompilerServices;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void ReverseTest()
        {
            Assert.AreEqual("!dlroW ,olleH", "Hello, World!".Reverse());
        }

        [TestMethod]
        public void IsWhitespaceTest()
        {
            Assert.AreEqual(false, (null as string).IsWhiteSpace());
            Assert.AreEqual(true, "         ".IsWhiteSpace());
            Assert.AreEqual(false, "Test!".IsWhiteSpace());
            Assert.AreEqual(false, "   Test! ".IsWhiteSpace());
        }

        [TestMethod]
        public void TrySubstringTest()
        {
            string result;

            Assert.IsTrue("Test".TrySubstring(2, out result));
            Assert.AreEqual("st", result);

            Assert.IsFalse((null as string).TrySubstring(1, out result));
            Assert.IsFalse("Test".TrySubstring(5, out result));

            Assert.IsTrue("Test".TrySubstring(1, 2, out result));
            Assert.AreEqual("es", result);
        }

        [TestMethod]
        public void ReverseBenchmark()
        {
            var @short = Benchmark.Measure(() => DoReverse("Yes"), 1000);
            var hello = Benchmark.Measure(() => DoReverse("Hello, World!"), 1000);
            var @long = Benchmark.Measure(() => DoReverse("This is a longer (yet not too long) string! (Better pad this out some more...)"), 1000);

            Console.WriteLine("1000 Iterations:");
            Console.WriteLine("Short: " + @short + "ms");
            Console.WriteLine("Hello: " + hello + "ms");
            Console.WriteLine("Long: " + @long + "ms");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void DoReverse(string str)
        {
            str.Reverse();
        }
    }
}
