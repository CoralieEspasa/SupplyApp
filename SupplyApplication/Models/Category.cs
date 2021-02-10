using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupplyApplication.Models
{
    public class Category
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
