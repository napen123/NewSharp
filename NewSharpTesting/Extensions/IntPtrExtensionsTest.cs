using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class IntPtrExtensionsTest
    {
        [TestMethod]
        public void ToUtf8StringTest()
        {
            {
                var ptr = Marshal.AllocHGlobal(7);
                Marshal.Copy(new byte[] {72, 101, 108, 108, 111, 33, 0}, 0, ptr, 7);

                Assert.AreEqual("Hello!", ptr.ToUtf8String());

                Marshal.FreeHGlobal(ptr);
            }

            {
                var ptr = Marshal.AllocHGlobal(6);
                Marshal.Copy(new byte[] { 72, 101, 108, 108, 111, 33 }, 0, ptr, 6);

                Assert.AreEqual("Hello!", ptr.ToUtf8String(6));

                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}
