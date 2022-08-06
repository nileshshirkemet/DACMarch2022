namespace Banking;

//a class defined with static modifier can only contain 
//static members, it does not define a non-static constructor 
//and as such it cannot be used for activation or extension
public static class Banker
{
    private static long nid;

    //a static constructor is called when a class is used 
    //for the first time within the CLR
    static Banker()
    {
        nid = DateTime.Now.Ticks % 1000000;
    }

    public static Account OpenCurrentAccount()
    {
        var acc = new CurrentAccount(); //implicitly typed local (var = CurrentAccount)
        acc.Id = ++nid + 100000000;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        SavingsAccount acc = new(); //new SavingsAccount()
        acc.Id = ++nid + 200000000;
        return acc;
    }

    //An 'extension method' is a member of a 'static class' whose first
    //parameter is modified with 'this' keyword. Such a method can be
    //called as an 'instance method' of its 'first parameter type' in a scope
    //within which its class can be used without the namespace qualifier.
    public static void FreezeAccount(this Account acc)
    {
        acc.Id = -acc.Id;
    }
}
