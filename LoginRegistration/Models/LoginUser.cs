using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    [NotMapped]
    // Just for validations
    public class LoginUser
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        public string LoginEmail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string LoginPassword { get; set; }
    }
}