using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm
{
    [TestClass]
    public class Math2Test
    {
        [TestMethod]
        [DataRow(0u, "00000000000000000000000000000000")]
        [DataRow(1u, "00000000000000000000000000000001")]
        [DataRow(2u, "00000000000000000000000000000010")]
        [DataRow(255u, "00000000000000000000000011111111")]
        [DataRow(256u, "00000000000000000000000100000000")]
        [DataRow(65535u, "00000000000000001111111111111111")]
        [DataRow(65536u, "00000000000000010000000000000000")]
        [DataRow(uint.MaxValue, "11111111111111111111111111111111")]
        public void Convert2(uint base10, string base2)
        {
            Assert.AreEqual(base2, Math2.Convert2(base10));
        }
    }
}
