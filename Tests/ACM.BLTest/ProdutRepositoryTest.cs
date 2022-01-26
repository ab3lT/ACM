using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProdutRepositoryTest
    {
        [TestMethod]
        public void ProduvtRepositoryTest()
        {
            // --Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2) {
                ProductName = "product 1",
                ProductDescrtiption = "Description one",
                CurrentPrice = 100
            };
            // - Act
            var actual = productRepository.Retrive(2);

            // -- Assert
            Assert.AreEqual(expected.ProductDescrtiption, actual.ProductDescrtiption);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);


        }
    }
}
