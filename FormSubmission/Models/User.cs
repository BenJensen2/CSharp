using System.ComponentModel.DataAnnotations;
using System;

namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4, ErrorMessage = "Must be more than 3 Characters")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Must be more than 3 Characters")]
        public string LastName { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Must be greater than 1 years old")]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}