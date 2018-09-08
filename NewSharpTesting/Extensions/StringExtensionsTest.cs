using System;

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
            const int iter = 100_000;

            {
                var @short = Benchmark.Measure(() => "Yes".Reverse(), iter);
                var hello = Benchmark.Measure(() => "Hello, World!".Reverse(), iter);
                var @long = Benchmark.Measure(() => "This is a longer (yet not too long) string! (Better pad this out some more...)".ReverseLarge(), iter);

                Console.WriteLine("1000 Iterations (Checked):");
                Console.WriteLine("Short: " + @short + "ms");
                Console.WriteLine("Hello: " + hello + "ms");
                Console.WriteLine("Long: " + @long + "ms");
            }

            Console.WriteLine();

            {
                var @short = Benchmark.Measure(() => "Yes".ReverseUnchecked(), iter);
                var hello = Benchmark.Measure(() => "Hello, World!".ReverseUnchecked(), iter);
                var @long = Benchmark.Measure(() => "This is a longer (yet not too long) string! (Better pad this out some more...)".ReverseLargeUnchecked(), iter);

                Console.WriteLine("1000 Iterations (Unchecked):");
                Console.WriteLine("Short: " + @short + "ms");
                Console.WriteLine("Hello: " + hello + "ms");
                Console.WriteLine("Long: " + @long + "ms");
            }
        }
    }
}
