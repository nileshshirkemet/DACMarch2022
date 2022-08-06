namespace Banking;

//class defined with abstract modifier cannot be activated,
//it can only be used as a base type for other classes
public abstract class Account
{
    public long Id { get; internal set; }

    public double Balance { get; protected set; }

    //method declared with abstract modifier is pure and virtual,
    //it must be overridden by activatable derived classes
    public abstract void Deposit(double amount);

    public abstract void Withdraw(double amount);

    public bool Transfer(double amount, Account that)
    {
        if(ReferenceEquals(this, that))
            return false;
        this.Withdraw(amount);
        that.Deposit(amount);
        return true;
    }
}