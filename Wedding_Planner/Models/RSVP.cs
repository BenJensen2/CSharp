using System;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class RSVP
    {
        [Key]
        public int RSVPId { get; set; }

        // Foreign Keys
        public int WeddingId { get; set; }
        public int UserId { get; set; }
        // public string Status { get; set; }

        // Navigational Must use .include
        //  -   Only need for easy querying
        public User Guest { get; set; }
        public Wedding Wedding { get; set; }
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;    
    }
}