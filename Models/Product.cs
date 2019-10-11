using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kafer_house.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        
        [Required]
        public string name { get; set; }
        
        
        public string code { get; set; }

        [Required]
        public double price { get; set; }


     
    }
}