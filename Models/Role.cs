using System;
using System.ComponentModel.DataAnnotations;

namespace kafer_house.Models
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    
    }
}