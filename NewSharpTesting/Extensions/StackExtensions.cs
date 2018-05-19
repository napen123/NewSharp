using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class StackExtensions
    {
        [TestMethod]
        public void TryPeekTest()
        {
            var stack = new Stack<string>(1);
            stack.Push("Hello!");

            {
                Assert.IsTrue(stack.TryPeek(out var message));
                Assert.AreEqual("Hello!", message);
            }

            stack.Pop();

            {
                Assert.IsFalse(stack.TryPeek(out var message));
                Assert.IsNull(message);
            }
        }

        [TestMethod]
        public void TryPopTest()
        {
            var stack = new Stack<string>(1);
            stack.Push("Hello!");

            {
                Assert.IsTrue(stack.TryPop(out var message));
                Assert.AreEqual("Hello!", message);
            }
            
            {
                Assert.IsFalse(stack.TryPop(out var message));
                Assert.IsNull(message);
            }
        }
    }
}
