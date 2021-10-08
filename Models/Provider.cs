using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Provider
    {
        [Key]
        public int IdProvider { get; set; }

        public string ProviderName { get; set; }

        public string ProviderContactEmail { get; set; }

        public string ProviderContactPhone { get; set; } 
    }
}
