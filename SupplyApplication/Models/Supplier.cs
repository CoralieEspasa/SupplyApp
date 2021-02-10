using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SupplyApplication.Models
{
    public class Supplier
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String SIRET { get; set; }
        public String Address { get; set; }
        public String PostalCode { get; set; }
        public String Location{ get; set; }
        public String Country { get; set; }
        public Double QualityNote { get; set; }
        public Double LogisticNote { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
