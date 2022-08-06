using Taxation;

try
{
    string m = args[0].ToLower();
    int n = int.Parse(args[1]);
    DoAudit(m, n);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void DoAudit(string name, int count)
{
    //auto-boxing for converting struct (value) type to interface (reference) type
    ITaxPayer emp = name == "jack" ? new Engineer(count) : new Programmer(count);
    var a = new Auditor();
    try
    {
        Console.WriteLine("Total Payment: {0:0.00}", a.Audit(emp, name));
    }
    finally
    {
        a.Dispose();
    }
}

class Auditor
{
    public Auditor()
    {
        Console.WriteLine("Acquiring resources...");
    }

    public double Audit(ITaxPayer person, string id)
    {
        if(id.Length < 4)
            throw new ArgumentException("Invalid ID");
        return person.IncomeTax() + 500;
    }

    public void Dispose()
    {
        Console.WriteLine("Releasing resources...");
    }
}

