using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class IDictionaryExtensionsTest
    {
        [TestMethod]
        public void GetOrAddDefaultTest()
        {
            const string key = "key";

            var dict = new Dictionary<string, int>();
            Assert.AreEqual(default, dict.GetOrAddDefault(key));

            dict[key] = 5;
            Assert.AreEqual(5, dict.GetOrAddDefault(key));

            dict.Remove(key);
            Assert.AreEqual(default, dict.GetOrAddDefault(key));
        }
    }
}