using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrive one product
        /// </summary>
        public Product Retrive(int productId)
        {
            /// create the instance of the customer class
            /// pass in the reqired id
            Product product = new Product(productId);
            // code that retrives the defined customer

            //temorery hard coded values to return
            // A popular product
            if (productId == 2)
            {
                product.ProductName = "product 1";
                product.ProductDescrtiption = "Description one";
                product.CurrentPrice = 100;
            }
            return product;
        }
        ///<summary>
        ///Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            //code that saves the passed product
            return true;
        }
    }
}
