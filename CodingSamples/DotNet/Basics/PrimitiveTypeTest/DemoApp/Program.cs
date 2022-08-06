using System;

class Program
{
	private static double Invest(double payment, int count, bool risky = false)
	{
		float i = risky ? 0.08f : 0.06f;
		return (payment / i) * (Math.Pow(1 + i, count) - 1);		 
	}

	public static void Main(string[] args)
	{
		Console.WriteLine("Welcome Investor.");
		double p = double.Parse(args[0]);
		int n = int.Parse(args[1]);
		Console.WriteLine("Future value in riskless investment: {0:0.00}", Invest(p, n));
		Console.WriteLine("Future value in riskful investment : {0:0.00}", Invest(p, n, true));
	}
}
