using System.Text;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class IntPtrExtensionsTest
    {
        [TestMethod]
        public void IntoManagedStringTest()
        {
            var hello = new byte[] {72, 101, 108, 108, 111, 33, 0};

            {
                var ptr = Marshal.AllocHGlobal(7);
                Marshal.Copy(hello, 0, ptr, 7);

                Assert.AreEqual("Hello!", ptr.IntoManagedString(Encoding.UTF8));

                Marshal.FreeHGlobal(ptr);
            }

            {
                var ptr = Marshal.AllocHGlobal(6);
                Marshal.Copy(hello, 0, ptr, 6);

                Assert.AreEqual("Hello!", ptr.IntoManagedString(Encoding.UTF8, 6));

                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}
