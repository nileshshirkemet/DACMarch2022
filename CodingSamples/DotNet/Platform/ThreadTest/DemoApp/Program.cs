class Program
{
    [ThreadStatic] //each thread will have a separate value for the static field
    private static string client;

    private static void HandleJob(int jno)
    {
        Console.WriteLine("Thread<{0}> has accepted job<{1}> for {2}", Thread.CurrentThread.ManagedThreadId, jno, client);
        Worker.DoWork(10 * jno);
        Console.WriteLine("Thread<{0}> has finished job<{1}> for {2}", Thread.CurrentThread.ManagedThreadId, jno, client);
    }   

    public static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 1;
        Thread child = new Thread(() => 
        {
            client = "Jack";
            HandleJob(n);
        });
        child.IsBackground = n > 5; //CLR does not wait for a back-ground thread to exit
        child.Start();
        client = "Jill";
        HandleJob(2);
    }
}