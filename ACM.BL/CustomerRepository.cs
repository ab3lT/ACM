using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
       /// <summary>
       /// Retrive one custoimer
       /// </summary>
       public Customer Retrive(int customerId)
        {
            // create the instance of the customer class
            // Pass in the reqired id
            Customer customer = new Customer(customerId);
           
            // code that retrives the defined customer

            //Temprary hard=coded values to return
            // a popular customer
            if (customerId == 1)
            {
                customer.EmailAdress = "abc@gmail.com";
                customer.FirstName = "abc";
                customer.LastName = "123";
            }
            return customer;
        }

        ///<summary>
        ///Saves the current customer
        ///</summary
        ///<returns></returns>
        public bool Save(Customer customer)
        {
            // code that saves the passed in cusotmer
            return true;
        }
    }
}
