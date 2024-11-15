using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enum;

namespace ObjectOrientedPractics.Model
{

    public class PriorityOrder : Order
    {

        public DateTime DeliveryDate { get; set; }

        public OrderTime DeliveryTime { get; set; }

        public PriorityOrder(
            Address address,
            List<Item> items,
            DateTime deliveryDate,
            OrderTime deliveryTime
            ) : base(address, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        public PriorityOrder()
        {
        }

    }
}