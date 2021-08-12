using System;

namespace ATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.WithdrawAmount();
            ATM a = new ATM();
            a.WithdrawAmount();
            Account ac = new Account();
            ac.GetDetails();

        }
    }

    //Parent Class
    public class Bank
    {
        public string BankName;
        public int Amount; // cash in bank 
        // Encapsulation: hide unnecessary data from child class
        private string BranchName;
        private string IFSCCode;


        public string getIFSCCode()
        {
            return IFSCCode;
        }

        public void DepositAmount() { }
        public virtual void WithdrawAmount()
        {
            Console.WriteLine("Withdrawn from bank");
        }
        public virtual void CheckBalance()
        {
            Console.WriteLine("check balance from bank");
        }

    }

    public sealed class Account : Bank
    {
          public void GetDetails()
        {
            Console.WriteLine("IFSC code is : {0}", getIFSCCode());
        }
    }
    // Due to Account  being a sealed class it cannot be inherited by any other class



}
