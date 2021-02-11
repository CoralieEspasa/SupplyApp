using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Models
{
    public class OrderLine
    {
        public Int32 Id { get; set; }
        public Int32 Quantity { get; set; }
        public Double Remise { get; set; }
        public Int32 ItemReference { get; set; }
        public String ItemName { get; set; }
        public Double UnitPrice { get; set; }
        public Double DeliveryTime { get; set; }
        public DateTime DeliveryDate { get; set;}
        public Double Amount
        {
            get
            {
                return (Quantity * UnitPrice) / 1 + Remise;
            }
        }
        public Int32 PurchaseOrderId { get; set; }
        

    }
}
