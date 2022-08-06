using Banking;

Account[] bank = new Account[5];
bank[0] = Banker.OpenSavingsAccount();
bank[0].Deposit(5000);
bank[1] = Banker.OpenCurrentAccount();
bank[1].Deposit(20000);
bank[2] = Banker.OpenSavingsAccount();
bank[2].Deposit(25000);
bank[3] = Banker.OpenCurrentAccount();
bank[3].Deposit(40000);
bank[4] = Banker.OpenSavingsAccount();
bank[4].Deposit(45000);
PayAnnualInterest(bank);
//IFinable f = bank[1] as IFinable;
//f.Withdraw(1000);
foreach(Account acc in bank)
    Console.WriteLine("{0}\t{1:0.00}", acc.Id, acc.Balance);

void PayAnnualInterest(Account[] accounts)
{
    foreach(Account acc in accounts)
    {
        IProfitable p = acc as IProfitable; //side casting
        p?.AddInterest(12); //if(p != null) p.AddInterest(12);
    }
}