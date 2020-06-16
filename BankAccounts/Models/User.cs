 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2,ErrorMessage = "First Name must be at least 2 Characters in length")]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(2,ErrorMessage = "Last Name must be at least 2 Characters in length")]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Password must be at least 8 Characters in length")]
        public string Password { get; set; }
        
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        public List<Account> OwnedAccounts {get; set;}

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;
    }
}