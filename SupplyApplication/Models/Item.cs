using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Models
{
    public class Item
    {
        public Int32 Id { get; set; }
        public String ItemName { get; set; }
        public Double UnitPrice { get; set; }
        public Double DeliveryTime { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
