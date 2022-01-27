using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Address
    {
        public Address()
        {
                
        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string State { get; set; }

        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        
        /// <summary>
        /// Validate the adddress data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;
            if (PostalCode == null) isValid = false;
            return isValid;
        }




    }
}
