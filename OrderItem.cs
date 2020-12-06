using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        } 
        public OrderItem(int orderItemId) 
        {
            OrderItemId = orderItemId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        
        public bool Validate()
        {
            var isValid = true;
            
            if (OrderDate == null) isValid = false; //validate the order date

            return isValid;

        }
        public Order Retrieve(int orderId)
        {
            return new Order(); //code the contain the Retrevied order
        }
        public bool save()
        {
            return true; //code that saves the defined order
        }
    }
}
