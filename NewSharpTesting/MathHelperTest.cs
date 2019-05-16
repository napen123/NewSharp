using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NewSharp;

namespace NewSharpTesting
{
    [TestClass]
    public class MathHelperTest
    {
        [TestMethod]
        public void AbsTest()
        {
            Assert.AreEqual(0f, MathHelper.Abs(0f));
            Assert.AreEqual(5.75f, MathHelper.Abs(5.75f));
            Assert.AreEqual(2.37f, MathHelper.Abs(-2.37f));
        }

        [TestMethod]
        public void RadiansToDegreesTest()
        {
            const double delta = 0.0001f;
            
            var half = MathHelper.RadiansToDegrees(Math.PI);
            var full = MathHelper.RadiansToDegrees(2.0 * Math.PI);
            var arbitrary = MathHelper.RadiansToDegrees(8.939);
            
            Assert.AreEqual(180, half, delta);
            Assert.AreEqual(360, full, delta);
            Assert.AreEqual(512.167, arbitrary, delta);
        }

        [TestMethod]
        public void DegreesToRadiansTest()
        {
            const double delta = 0.0001f;

            var half = MathHelper.DegreesToRadians(180);
            var full = MathHelper.DegreesToRadians(360);
            var arbitrary = MathHelper.DegreesToRadians(500);

            Assert.AreEqual(Math.PI, half, delta);
            Assert.AreEqual(MathHelper.Tau, full, delta);
            Assert.AreEqual(8.7266, arbitrary, delta);
        }

        [TestMethod]
        public void IntegerSumTest()
        {
            Assert.AreEqual(0, MathHelper.Sum(0));
            Assert.AreEqual(1, MathHelper.Sum(1));
            Assert.AreEqual(5050, MathHelper.Sum(100));
        }

        [TestMethod]
        public void FloatSumTest()
        {
            const double delta = 0.00000000000001f;
            
            float[] floats = {1f, 5f, 9.5f, 27.11f};
            Assert.AreEqual(42.61f, MathHelper.KahanSum(floats), delta);
            Assert.AreEqual(42.61f, MathHelper.NeumaierSum(floats), delta);

            double[] doubles = { 27.11, 1.0, 9.5, 5.0 };
            Assert.AreEqual(42.61, MathHelper.KahanSum(doubles), delta);
            Assert.AreEqual(42.61, MathHelper.NeumaierSum(doubles), delta);
        }
    }
}
