global using System; //global using is applicable to all source files in current project

class Program
{
	//accepting a value type by reference (address)
	private static void Advise(ref Investment m)
	{
		m.AllowRisk(m.TotalAmount() < 500000);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine("Welcome Investor.");
		double p = double.Parse(args[0]);
		int n = int.Parse(args[1]);
		Investment inv = new Investment(p, n);
		Console.WriteLine("Future value in riskless investment: {0:0.00}", inv.FutureValue());
		inv.AllowRisk(true);
		Console.WriteLine("Future value in riskful investment : {0:0.00}", inv.FutureValue());
		Advise(ref inv); //passing value type by reference
		Console.WriteLine("Future value in smart investment : {0:0.00}", inv.FutureValue());
	}
}
