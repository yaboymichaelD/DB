using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        private int AccountID;
        private double balance;
        private char Type;
        private bool isBlocked;

        public Account()
        {
            this.AccountID = 0;
            this.balance = 0;
            this.Type = 'N';
            this.isBlocked = false;
        }

        public Account(int accountID, double balance, char type, bool isBlocked)
        {
            AccountID = accountID;
            this.balance = balance;
            Type = type;
            this.isBlocked = isBlocked;
        }

        public int getAccountID()
        {
            return AccountID;
        }

        public double getBalance()
        {
            return balance;
        }

        public char getType()
        {
            return Type;
        }
        public bool returnBlockState()
        {
            return isBlocked;
        }

    }
}
