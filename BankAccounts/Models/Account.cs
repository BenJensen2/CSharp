using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class Account
    {
        [Key]
        public int AccountID {get; set;}
        public int Balance {get; set;}
        // prop+Tab gives auto getter & setter public
        // public int MyProperty { get; set; }
        public User Owner {get; set;}

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        // public Account(User newUser)
        // {
        //     Balance = 0;
        //     Owner = newUser;
        // }
        public void DepositWithdraw(Account account, int amount)
        {
            account.Balance += amount;
        }
    }
}