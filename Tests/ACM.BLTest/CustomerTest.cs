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
            string expected = "Tadesse, Abel";


            //--Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual); 

        }
        [TestMethod]
        public void FullNameLastNameEmpity()
        {
            //--Arrage
            Customer customer = new Customer
            {
                FirstName = "Abel"
            };
            string expected = "Abel";

            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StaticTest()
        {
            // -- Arrage
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.Instancecount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frado";
            Customer.Instancecount += 1;

            //-- Act
            //--Assert
            Assert.AreEqual(2, Customer.Instancecount);
        }
        [TestMethod]
        public void CheekEmail()
        {
            Customer customer = new Customer
            {
                EmailAdress = "123@test.com"
            };
            string expected = "123@test.com";

            //--Act
            string actual = customer.EmailAdress;
            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var Customer = new Customer
            {
                LastName = "Tadesse",
                EmailAdress = "Tadesse@123.com"
            };
            var expected = true;
            //-- Act
            var actual = Customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod  ]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var Customer = new Customer
            {
                
                EmailAdress = "Tadesse@123.com"
            };
            var expected = false;
            //-- Act
            var actual = Customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
