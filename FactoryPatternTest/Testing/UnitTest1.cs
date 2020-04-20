using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNameTest()
        {
            //Arrange  
            TestingApp.Employee objEmployee = new TestingApp.Employee();
            String firstName = "Narasimha";
            String lastName = "Reddy";
            String expected = "Narasimha Reddy";
            String actual;
            //Act  
            actual = objEmployee.GetName(firstName, lastName);
            //Assert  
            Assert.AreEqual(expected, actual);
        }
    }
}
