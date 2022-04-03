using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order(int orderId)
        {
            OrderId = OrderId;
        }
        public Order()
        {

        }
        public int OrderId { get; private set; }
        public string OrderName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int Quantity { get; set; }

       
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

      
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null || string.IsNullOrWhiteSpace(OrderName))
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
