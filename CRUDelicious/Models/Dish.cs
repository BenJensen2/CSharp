using System;
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Chef { get; set; }
        [Required]
        [Range(1,6,ErrorMessage = "Tastiness must be between 1 and 5")]
        // asp net dropdown options & validdations select and sect
        public int Tastiness { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Calories must be greater than 0")]
        public string Calories { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}