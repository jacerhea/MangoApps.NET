using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MangoApps.Client.Test
{
    [TestClass]
    public class Base64EncoderTest
    { 
        [TestMethod]
        public void TestEncoding()
        {
            var result = Encoder.ToBase64String("seahawks");
            Assert.AreEqual("c2VhaGF3a3MK", result);
        }
    }
}
