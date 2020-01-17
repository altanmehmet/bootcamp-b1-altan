using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_core_bootcamp_b1_altan.Dtos
{
    public class EventAddDto
    {
        [Required, MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
        public string Address { get; set; }
        public bool IsFree { get; set; }
        public double Price { get; set; }
        public string Subject { get; set; }
        public string Desc { get; set; }


    }
    public class EventUpdateDto : EventAddDto
    {
        [Required]
        public Guid Id { get; set; }

    }
}
    
