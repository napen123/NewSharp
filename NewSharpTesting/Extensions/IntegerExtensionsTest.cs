using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class IntegerExtensionsTest
    {
        [TestMethod]
        public void HasFlag()
        {
            const int flagA = 1;
            const int flagB = 2;

            {
                const int a = flagA;

                Assert.IsTrue(a.HasFlag(flagA));
                Assert.IsFalse(a.HasFlag(flagB));
            }

            {
                const int b = flagB;

                Assert.IsFalse(b.HasFlag(flagA));
                Assert.IsTrue(b.HasFlag(flagB));
            }

            {
                const int ab = flagA | flagB;

                Assert.IsTrue(ab.HasFlag(flagA));
                Assert.IsTrue(ab.HasFlag(flagB));
            }
        }
    }
}
