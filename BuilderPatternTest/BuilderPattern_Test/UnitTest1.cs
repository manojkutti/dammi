using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderPattern;
namespace BuilderPattern_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var build = new HeroBuilder();
            var value = new VehicleCreator(build);
            value.CreateVehicle();
            var a = value.GetVehicle();

            Assert.AreEqual("Hero", a.Model);
            Assert.AreEqual("4 Stroke", a.Engine);
            Assert.AreEqual("Plastic", a.Body);
            Assert.AreEqual("120 km/hr", a.Transmission);
            Assert.AreEqual("Seat Cover", a.Accessories[0]);
            Assert.AreEqual("Rear Mirror", a.Accessories[1]);




        }
        [TestMethod]
        public void TestMethod2()
        {
            var build = new HondaBuilder();
            var value = new VehicleCreator(build);
            value.CreateVehicle();
            var a = value.GetVehicle();

            Assert.AreEqual("Honda", a.Model);
            Assert.AreEqual("4 Stroke", a.Engine);
            Assert.AreEqual("Plastic", a.Body);
            Assert.AreEqual("125 Km/hr", a.Transmission);
            Assert.AreEqual("Seat Cover", a.Accessories[0]);
            Assert.AreEqual("Rear Mirror", a.Accessories[1]);
            Assert.AreEqual("Helmet", a.Accessories[2]);

        }
    }
}
