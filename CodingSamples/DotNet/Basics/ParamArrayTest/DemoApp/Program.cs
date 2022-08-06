class Program
{
    /*
    private static double Average(double first, double second)
    {
        return (first + second) / 2;
    }

    private static double Average(double first, double second, double third)
    {
        return (first + second + third) / 3;
    }
    */

    private static double Average(double first, double second, params double[] remaining)
    {
        double total = first + second;
        foreach(double value in remaining)
        {
            total += value;
        }
        return total / (remaining.Length + 2);
    }

    //private static double AverageWithDeviation(double first, double second, ref double dev)
    private static double AverageWithDeviation(double first, double second, out double dev)
    {
        //out modifier is like ref modifier but accepts uninitialized argument
        //and initializes its value before the current method returns
        dev = first > second ? (first - second) / 2 : (second - first) / 2;
        return (first + second) / 2;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Average of two values = {0:0.000}", Average(23.4, 28.5));
        Console.WriteLine("Average of three values = {0:0.000}", Average(23.4, 28.5, 19.2));
        Console.WriteLine("Average of five values = {0:0.000}", Average(23.4, 28.5, 19.2, 33.8, 15.1));
        if(args.Length > 1)
        {
            double x = double.Parse(args[0]);
            double y = double.Parse(args[1]);
            //double d = 0;
            //double a = AverageWithDeviation(x, y, ref d);
            double a = AverageWithDeviation(x, y, out double d);
            Console.WriteLine("Average is {0:0.000} with a deviation of {1:0.00}", a, d);
        }
    }
}
