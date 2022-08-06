class Program
{
    class Computation
    {
        public long Compute(int first, int last)
        {
            return Enumerable.Range(first, last - first + 1)
                            .Select(Worker.DoWork)
                            .Sum();
        }
    }

    private static void DoComputation(int limit)
    {
        Console.Write("Computing...");
        var w = new System.Diagnostics.Stopwatch();
        var c = new Computation();
        w.Start();
        long r = c.Compute(1, limit);
        w.Stop();
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0} computed in {1:0.000} seconds.", r, w.Elapsed.TotalSeconds);
    }

    public static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 10;
        DoComputation(n);        
    }
}
