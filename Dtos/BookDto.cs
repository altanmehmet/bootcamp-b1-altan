using System;
using System.ComponentModel.DataAnnotations;

namespace net_core_bootcamp_b1_altan.Dtos
{
    public class BookAddDto
{
    [Required, MaxLength(200)]
    public string Name { get; set; }
    [Required]
    public string Author { get; set; }
    public string Publisher { get; set; }
    [Required]
    public DateTime ReleasedAt { get; set; }
    [Required]
    public double Price { get; set; }
}
    public class BookUpdateDto : BookAddDto
    {
        public Guid Id { get; set; }
    }
    public class BookGetDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public string Name { get; set; }
        
        public string Author { get; set; }
        public string Publisher { get; set; }
        
        public DateTime ReleasedAt { get; set; }
       
        public double Price { get; set; }
    }
}
