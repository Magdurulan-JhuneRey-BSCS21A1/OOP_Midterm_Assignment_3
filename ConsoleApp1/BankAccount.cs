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

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
        }
    }

    public double GetBalance()
    {
        return _balance;
    }
}

