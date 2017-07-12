using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transformation;

namespace NetCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNetCore_InlineCalculation_ReturnsHelloWorld()
        {
            var result = Transformer.TransformInlineCalculation();
            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void TestNetCore_ExternalCalculation_ReturnsHelloWorld()
        {
            var result = Transformer.TransformExternalCalculation();
            Assert.AreEqual("Hello World", result);
        }
    }
}
