using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupplyApplication.Models
{
    public class PurchaseOrder
    {
        public Int32 Id { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }

}
