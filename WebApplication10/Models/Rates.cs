using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class Rates
    {
        [Key]
        public int Id { get; set; }
        public float RUB { get; set; }
        public float EUR { get; set; }
        public float GBP { get; set; }
        public float JPY { get; set; }
        public float USD { get; set; }
    }
    
    public class Date
    {
        [Key]
        public int Id { get; set; }
        public string firstDate { get; set; }
        public string lastDate { get; set; }
    }
}
