namespace ClassLibrary2
{
    public class BankAccount
    {
        private int _accountNumber;
        private double _balance;
        private double _interestRate;

        public BankAccount(int accountNumber, double initialBalance, double interestRate)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance;
            _interestRate = interestRate;
        }
        public BankAccount(int accountNumber, double initialBalance)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance;
        }

        public void Deposit(double amount)
        {
                _balance += amount;
        }

        public void Withdraw(double amount)
        {
                _balance -= amount;
 
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void CalculateInterest()
        {
            _balance += _balance * _interestRate;
        }

        public void Withdraw(int amount, bool isOtherBank)
        {
            double penalty = isOtherBank ? 20 : 0;
                _balance -= (amount + penalty);
        }
    }

}
