 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
       
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }

        
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                         
                    }
                    fullName += FirstName ;
                }
                return fullName;
            }
        }
        public static int Instancecount { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid= false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;
            return isValid;
        }
        
        /// <summary>
        /// Retrive one customer.
        /// </summary>
       
        /// <summary>
        /// Retrive all customer.
        /// </summary>
        public List<Customer> Retrieve()
        {
            // code that retrives the definded customer.
            return new List<Customer>();
        }
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
     
    }
}
