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

        public Task<long> ComputeAsync(int first, int last)
        {
            //The operation passed to Run will be invoked by a pooled thread
            //allowing the calling thread to resume execution and acquire the
            //result of invocation from the returned task once it is completed
            //by the pooled thread.
            return Task<long>.Run(() => Compute(first, last));
        }
    }

    private static Task DoComputation(int limit)
    {
        Console.Write("Computing...");
        var w = new System.Diagnostics.Stopwatch();
        var c = new Computation();
        w.Start();
        return c.ComputeAsync(1, limit)
                .ContinueWith(t => 
                {
                    long r = t.Result;
                    w.Stop();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Result = {0} computed in {1:0.000} seconds.", r, w.Elapsed.TotalSeconds);
                });
    }

    public static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 10;
        var job = DoComputation(n);
        while(!job.IsCompleted)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }        
    }
}
