using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class SavingsAccount : BankAccount
    {

        public SavingsAccount(int accountNumber, double initialBalance, double interestRate)
            : base(accountNumber, initialBalance, .075)
        {

        }

    }

}
