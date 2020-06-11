using System.ComponentModel.DataAnnotations;
namespace Dojo_Survey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Your Name")]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Language { get; set; }
        [MinLength(20)]
        public string Comment { get; set; }
    }
}