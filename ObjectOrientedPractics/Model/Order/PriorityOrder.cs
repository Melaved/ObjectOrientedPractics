
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enum;


namespace ObjectOrientedPractics.Model.Orders
{

    public class PriorityOrder : Order
    {
 
        public DateTime DeliveryDate { get; set; }

 
        public OrderTime DeliveryTime { get; set; }

        public PriorityOrder(
            Address address,
            List<Item> items,
            DateTime deliveryDate,
            OrderTime deliveryTime, double discountAmount
            ) : base(address, items, discountAmount)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now;
            DeliveryTime = OrderTime.f9t11;
        }

    }
}
