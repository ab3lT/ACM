using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arraange
            Customer customer = new Customer
            {
                FirstName = "Abel",
                LastName = "Tadesse"
            };
            string expected = "Abel, Tadesse";


            //--Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual); 

        }
    }
}
