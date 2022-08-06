using Finance;

class Program
{
    public static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        Type t = args.Length > 1 ? Type.GetType(args[1]) : typeof(PersonalLoan);
        //compile-time type-checking is disabled for an object declared with dynamic type
        //and a runtime-binding call-site is generated for invocation of its members
        dynamic policy = Activator.CreateInstance(t);
        int m = 10;
        for(int n = 1; n <= m; ++n)
        {
            float i = policy.Common(p, n) / 1200; //duck typing
            double emi = p * i / (1 - Math.Pow(1 + i, -12 * n));
            Console.WriteLine("{0, -6}{1, 12:0.00}", n, emi);
        }
    }
}
