class Program
{
    private static object Select(int index, object first, object second)
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

    public static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            int s = int.Parse(args[0]);
            string ss = (string)Select(s, "Monday", "Sunday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = (double)Select(s, 45.6, 34.5);
            Console.WriteLine($"Selected double = {sd}");
            double sm = (double)Select(s, 123.4, "June");
        }
    }
}
