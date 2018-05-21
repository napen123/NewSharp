using System.IO;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class StreamExtensionsTest
    {
        [TestMethod]
        public void ReadAllBytesTest()
        {
            using (var file = File.Open("test/hello.txt", FileMode.Open))
            {
                var data = file.ReadAllBytes();
                Assert.IsNotNull(data);

                var text = Encoding.UTF8.GetString(data);
                Assert.AreEqual("Hello, World!", text);
            }
        }
    }
}
