namespace Banking;

//class defined with sealed modifier cannot be used as a base class,
//it can only be used for activation
sealed class CurrentAccount : Account, IFinable
{
    public override void Deposit(double amount)
    {
        Balance += amount;
    }

    public override void Withdraw(double amount)
    {
        Balance -= amount;
    }

    //explicit interface implementation
    bool IFinable.Withdraw(double penalty)
    {
        if(Balance < 25000)
        {
            Balance -= penalty;
            return true;
        }
        return false;
    }
}
