using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId  { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public virtual Provider? Provider { get; set; }
        public int? ProviderId { get; set; }
    }
}
