using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeInventory.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Replacement Value")]
        public decimal ReplacementValue { get; set; }
        public  Category Category { get; set; }
        public Room Location { get; set; }
        public bool Removed { get; set; }
    }
}
