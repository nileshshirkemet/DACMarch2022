using System.Runtime.CompilerServices;

var acc = new JointAccount();
acc.Deposit(5000);
Console.WriteLine("Joint account opened for Jack and Jill.");
Console.WriteLine("Initial Balance: {0}", acc.Balance);
Thread child = new Thread(() =>
{
    Console.WriteLine("Jack is withdrawing 3000 from the account...");
    if(acc.Withdraw(3000) == false)
        Console.WriteLine("Jack's withdrawal failed!");
});
child.Start();
Console.WriteLine("Jill is withdrawing 4000 from the account...");
if(acc.Withdraw(4000) == false)
    Console.WriteLine("Jill's withdrawal failed!");
child.Join(); //wait for child to exit
Console.WriteLine("Final Balance = {0}", acc.Balance);
Console.WriteLine("Jack is waiting to withdraw 3000...");
child = new Thread(() => 
{
    if(acc.WithdrawAfterDeposit(3000))
        Console.WriteLine("Jack's withdrawal succeeded and new balance is {0}", acc.Balance);
});
child.Start();
Console.Write("Jill deposits amount: ");
int amt = int.Parse(Console.ReadLine());
acc.Deposit(amt);

class JointAccount
{
    public int Balance { get; set; }

    public bool Withdraw(int amount)
    {
        bool success = false;
        Monitor.Enter(this); //Requires the calling thread to lock the
        //monitor assigned to the specified object. Only a single thread
        //can lock a given monitor at time while other threads must wait 
        //for this thread to unlock it.
        try
        {
            if(Balance >= amount)
            {
                Worker.DoWork(amount / 500);
                Balance -= amount;
                success = true;
            }
        }
        finally
        {
            //unlock the monitor assigned to the specified object
            Monitor.Exit(this); 
        }
        return success;
    }

    public void Deposit(int amount)
    {
        lock(this)
        {
            Worker.DoWork(amount / 500);
            Balance += amount;
            Monitor.Pulse(this); //signal the monitor assigned to the specified object
        }
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public bool WithdrawAfterDeposit(int amount)
    {
        //temporarily unlock the monitor assigned to the specified 
        //object and wait for this monitor to be signalled
        Monitor.Wait(this);
        return Withdraw(amount);
    }
}
