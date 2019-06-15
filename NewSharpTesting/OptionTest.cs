using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp;

namespace NewSharpTesting
{
    [TestClass]
    public class OptionTest
    {
        [TestMethod]
        public void IsSomeNoneTest()
        {
            var some = Option.Some(25);
            Assert.IsTrue(some.IsSome);
            Assert.AreEqual(25, some.ExpectUnsafe());

            switch (some)
            {
                case var s when s.IsSome:
                    Assert.AreEqual(25, some.ExpectUnsafe());
                    break;
                default:
                    Assert.Fail();
                    break;
            }

            var none = Option.None<int>();
            Assert.IsTrue(none.IsNone);

            switch (none)
            {
                case var n when n.IsNone:
                    break;
                default:
                    Assert.Fail();
                    break;
            }
        }
    }
}
