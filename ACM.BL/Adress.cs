using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Adress
    {
        public Adress()
        {
            
        }
        public Adress(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public enum AddressType
        {
            Work, 
            Home
        }

        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;
            return isValid;
        }
    }
}
