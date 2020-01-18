using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_core_bootcamp_b1_altan.Models
{
    public class Book
{
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        public string Publisher { get; set; }
        [Required]
        public DateTime ReleasedAt { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
