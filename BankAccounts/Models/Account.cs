namespace BankAccounts.Models
{
    public class Account
    {
        public int Balance {get; set;}
        public void DepositWithdraw(Account account, int amount)
        {
            account.Balance += amount;
        }
    }
}