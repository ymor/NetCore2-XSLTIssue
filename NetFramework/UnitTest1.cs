using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transformation;

namespace NetFramework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNetFramework_InlineCalculation_ReturnsHelloWorld()
        {
            var result = Transformer.TransformInlineCalculation();
            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void TestNetFramework_ExternalCalculation_ReturnsHelloWorld()
        {
            var result = Transformer.TransformExternalCalculation();
            Assert.AreEqual("Hello World", result);
        }
    }
}
