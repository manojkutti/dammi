using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory_Design;
namespace Factory_Design_Test
{
    [TestClass]
    public class Titanium
    {
        [TestMethod]
        public void TestMethod1()
        {
            TitaniumFactory _factory;
            _factory = new TitaniumFactory(500000, 1000);

            var value = _factory.GetCreditCard();

            Assert.AreEqual("Titanium", value.CardType);
            Assert.AreEqual(500000, value.CreditLimit);
            Assert.AreEqual(1000, value.AnnualCharge);
        }
    }
}
