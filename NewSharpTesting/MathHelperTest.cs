using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewSharp;

namespace NewSharpTesting
{
    [TestClass]
    public class MathHelperTest
    {
        [TestMethod]
        public void RadiansToDegreesTest()
        {
            const double delta = 0.0001f;

            var half = MathHelper.RadiansToDegrees(Math.PI);
            var full = MathHelper.RadiansToDegrees(2 * Math.PI);
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
    }
}
