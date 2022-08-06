float SafeScheme(int n)
{
    return n < 3 ? 0.05f : 0.07f;
}

if(args.Length == 0)
{
    Console.Write("Each Payment Value: ");
    double p = double.Parse(Console.ReadLine());
    Console.Write("Number of Payments: ");
    int n = int.Parse(Console.ReadLine());
    var inv = new Investment(p, n);
    Console.WriteLine("Future value of no-risk investment: {0:0.00}", inv.FutureValue(SafeScheme));
    Console.WriteLine("Future value of high-risk investment: {0:0.00}", inv.FutureValue(y => 0.09f + 0.005f * y));
}
else
{
    Action<string> greet = person => Console.WriteLine($"Hi {person}");
    greet += person => Console.WriteLine($"Bye {person}");
    greet(args[0]); //implicitly calling Invoke
}

