using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models
{
    public class Dish
    {
        [Required]
        public string ChefName;
        [Required]
        public string Name;
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Calories must be greater than 0")]
        public string Calories;
        [Required]
        [Range(1,6)]
        public int Tastiness;
        [Required]
        public string Description;
    }
}