using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        [Required]
        public string Wedder1 { get; set; }
        [Required]
        public string Wedder2 { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Address { get; set; }
        public User Planner { get; set; }
        public List<RSVP> GuestList { get; set; }
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;
    }
}