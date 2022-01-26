using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; set; }
        public string ProductName{ get; set; }
        public string ProductDescrtiption { get; set; }
        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
        /// <summary>
        /// Retrive one customer.
        /// </summary>
        //public Product Retrieve(string ProduceId)
        //{
        //    // code that retrives the definded produce.
        //    return new Product();
        //}
        ///// <summary>
        ///// Retrive all produce.
        ///// </summary>
        public List<Product> products()
        {
            // code that retrives the definded customer.
            return new List<Product>();
        }
        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        //public bool Save()
        //{
        //    // vode that saves the defined product
        //    return true;
        //}
    }
}
