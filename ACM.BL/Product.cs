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
        public string ProductName { get; set; }
        public int ProductId { get; private set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; } // ? just means this property can be null
         
       

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

       
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
    }
}
