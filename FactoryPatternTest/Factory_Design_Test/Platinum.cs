using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory_Design;
namespace Factory_Design_Test
{
    [TestClass]
    public class Platinum
    {
        [TestMethod]
        public void TestMethod1()
        {
            PlatinumFactory _factory;
            _factory = new PlatinumFactory(100000, 500);

            var value = _factory.GetCreditCard();

            Assert.AreEqual("Platinum", value.CardType);
            Assert.AreEqual(100000, value.CreditLimit);
            Assert.AreEqual(500, value.AnnualCharge);
        }
    }
}
