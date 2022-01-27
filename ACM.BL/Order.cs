using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate  { get; set; }
        public int OrderId { get; set; }
        ///<summary>
        ///Retrive one order.
        /// </summary>
       
        public bool Validate()
        {
            bool isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
       

}
