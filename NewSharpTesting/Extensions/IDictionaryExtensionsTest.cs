using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp.Extensions;

namespace NewSharpTesting.Extensions
{
    [TestClass]
    public class IDictionaryExtensionsTest
    {
        [TestMethod]
        public void GetOrAddTest()
        {
            {
                const string key = "key";

                var dict = new Dictionary<string, int>();
                Assert.AreEqual(5, dict.GetOrAdd(key, 5));

                dict[key] = 25;
                Assert.AreEqual(25, dict.GetOrAdd(key, 0));

                dict.Remove(key);
                Assert.AreEqual(default, dict.GetOrAdd(key, default));
            }

            {
                const int key = 1;

                var dict = new Dictionary<int, string>();
                Assert.AreEqual("Hello", dict.GetOrAdd(key, "Hello"));

                dict[key] = "Bye";
                Assert.AreEqual("Bye", dict.GetOrAddLazy(key, () => "???"));
            }
        }

        [TestMethod]
        public void GetOrAddDefaultTest()
        {
            {
                const string key = "key";

                var dict = new Dictionary<string, int>();
                Assert.AreEqual(default, dict.GetOrAddDefault(key));

                dict[key] = 5;
                Assert.AreEqual(5, dict.GetOrAddDefault(key));

                dict.Remove(key);
                Assert.AreEqual(default, dict.GetOrAddDefault(key));
            }

            {
                const int key = 1;

                var dict = new Dictionary<int, string>();
                Assert.AreEqual(default, dict.GetOrAddDefault(key));

                dict[key] = "Bye";
                Assert.AreEqual("Bye", dict.GetOrAddDefault(key));

                dict.Remove(key);
                Assert.AreEqual(default, dict.GetOrAddDefault(key));
            }
        }
    }
}