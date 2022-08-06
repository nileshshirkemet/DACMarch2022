using System.Reflection;

class Program
{
    private static void Present(object info)
    {
        Type t = info.GetType();
        Console.WriteLine("<{0}>", t.Name);
        foreach(PropertyInfo p in t.GetProperties())
            Console.WriteLine("  <{0}>{1}</{0}>", p.Name, p.GetValue(info));
        Console.WriteLine("</{0}>", t.Name);
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Present(new Item("cpu", "intel"));
        Present(new Customer("Jack", 23000, 4));
    }
}
