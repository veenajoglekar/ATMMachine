using System;
using System.Collections.Generic;
using System.Text;

namespace ATMMachine
{
    public class ATM : Bank
    {
        
        public sealed override void WithdrawAmount()
        {
            Console.WriteLine("Withdrawn from ATM ");
        }
        public sealed override void CheckBalance()
        {
            Console.WriteLine("check balance from ATM");

        }
    }

    public class Transaction : ATM, IAccountInfo
    {
        public int TransactionID;
        public string AccountType;
        private ulong CardNumber;  // ulong range : 0 to 18,446,744,073,709,551,615
                                  // credit card has 12 digits which cannot be stored in an int

        // WithdrawAmount and CheckBalance cannot be overridden here as they are sealed methods
        public void getDetails()
        {
            Console.WriteLine("Get All account details");
        }
    }

    interface IAccountInfo {
        public void getDetails();
    }

}
