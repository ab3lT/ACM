using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetruveValid()
        {
            // --Arrange
            var cusomerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                EmailAdress = "abc@gmail.com",
                FirstName = "abc",
                LastName = "123"

            };
            // - Act
            var actual = cusomerRepository.Retrive(1);

            // -- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            


        }
    }
}
