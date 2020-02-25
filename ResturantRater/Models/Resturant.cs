using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturantRater.Models
{
    public class Resturant
    {
        [Key]
        public int Id { get; set; }            //this is the primary key, it will always be the first on top.
        
        [Required]
        public string Style { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [Range(0d, 5d)]
        public double Rating { get; set; }
        
        [Required]
        [Range(1, 5)]
        public int DollarSigns { get; set; }
    }
}