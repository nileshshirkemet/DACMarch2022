namespace Banking;

sealed class SavingsAccount : Account, IProfitable
{
    const double MinBal = 5000;

    internal SavingsAccount()
    {
        Balance = MinBal;
    }

    public override void Deposit(double amount)
    {
        Balance += amount;
    }

    public override void Withdraw(double amount)
    {
        if(Balance - amount < MinBal)
            throw new InsufficientFundsException();
        Balance -= amount;
    }

    public double AddInterest(int months)
    {
        double interest = Balance * months * IProfitable.MinRate / 1200;
        Balance += interest;
        return interest;
    }
}