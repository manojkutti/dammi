using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory_Design;
namespace Factory_Design_Test
{
    [TestClass]
    public class MoneyBack
    {
        [TestMethod]
        public void TestMethod1()
        {

            MoneyBackFactory _factory;
            _factory = new MoneyBackFactory(5000, 0);

            var value = _factory.GetCreditCard();

            Assert.AreEqual("MoneyBack", value.CardType);
            Assert.AreEqual(5000, value.CreditLimit);
            Assert.AreEqual(0, value.AnnualCharge);

        }
    }
    }

