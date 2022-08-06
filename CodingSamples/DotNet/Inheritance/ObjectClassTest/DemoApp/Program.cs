//a type defined with partial modifier can include members
//through multiple source code files
partial class Interval
{
    public static Interval operator+(Interval lhs, Interval rhs)
    {
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }
}

class Program
{
    private static void Print(string label, object info)
    {
        Console.WriteLine("{0} = {1}", label, info);
    }

    public static void Main(string[] args)
    {
        Interval a = new Interval(6, 10);
        Interval b = new Interval(3, 5);
        Interval c = new Interval(5, 70);
        Interval d = b;
        Print("Interval a", a);
        Print("Interval b", b);
        Print("Interval c", c);
        Print("Interval d", d);
        Print("Total", a + b + c + d);
        Console.WriteLine("---------------------------");
        Console.WriteLine("a is identical to b: {0}", ReferenceEquals(a, b));
        Console.WriteLine("a is identical to c: {0}", ReferenceEquals(a, c));
        Console.WriteLine("d is identical to b: {0}", ReferenceEquals(d, b));
        Console.WriteLine("---------------------------");
        Console.WriteLine("a is equal to b: {0}", a.GetHashCode() == b.GetHashCode() && a.Equals(b));
        Console.WriteLine("a is equal to c: {0}", a.GetHashCode() == c.GetHashCode() && a.Equals(c));
        Console.WriteLine("d is equal to b: {0}", d.GetHashCode() == b.GetHashCode() && d.Equals(b));
        Console.WriteLine("---------------------------");
        Rectangle e;
        e.Length = 15;
        e.Breadth = 12;
        //conversion of a value type (Rectangle) to a compatible reference type (object)
        //is performed through auto-boxing (enclosing value-type data into an object on heap)
        Print("Rectangle e", e);
    }
}
