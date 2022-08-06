class Program
{
    private static T Select<T>(int index, T first, T second) 
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

    private static T Select<T>(T first, T second) where T: IComparable<T>
    {
        //if(first.GetHashCode() > second.GetHashCode())
        if(first.CompareTo(second) > 0)
            return first;
        return second;
    }

    public static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            int s = int.Parse(args[0]);
            string ss = Select(s, "Monday", "Sunday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = Select(s, 45.6, 34.5);
            Console.WriteLine($"Selected double = {sd}");
            //double sm = Select(s, 123.4, "June");
        }
        else
        {
            string ss = Select("Monday", "Sunday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = Select(45.6, 34.5);
            Console.WriteLine($"Selected double = {sd}");
            Interval si = Select(new Interval(5, 40), new Interval(6, 30));
            Console.WriteLine($"Selected Interval = {si}");
        }
    }
}
