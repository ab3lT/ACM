using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        ///<summary>
        ///Retrive one order.
        /// </summary>
        public Order Retrive(int OrderId)
        {
            //code that retrives the defined order
            return new Order();
        }
        public bool Save()
        {
            // vode that saves the defined product
            return true;
        }
        public bool Validate()
        {
            bool isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
       

}
