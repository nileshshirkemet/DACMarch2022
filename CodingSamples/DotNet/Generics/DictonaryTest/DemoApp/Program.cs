//IDictionary<string, Interval> store = new Dictionary<string, Interval>();
//IDictionary<string, Interval> store = new SortedList<string, Interval>();
IDictionary<string, Interval> store = new SortedDictionary<string, Interval>();
store.Add("monday", new Interval(4, 31));
store.Add("tuesday", new Interval(6, 52));
store.Add("wednesday", new Interval(7, 43));
store.Add("thursday", new Interval(5, 14));
store.Add("friday", new Interval(3, 25));
if(args.Length > 1)
{
    string day = args[0].ToLower();
    //store[day] = float.Parse(args[1]);
    store[day] = (Interval)float.Parse(args[1]);
}
foreach(var pair in store)
    Console.WriteLine("{0, -15}{1}", pair.Key, pair.Value);
Console.Write("Key: ");
string key = Console.ReadLine();
if(store.TryGetValue(key, out Interval val))
    Console.WriteLine("Value = {0}", val);
else
    Console.WriteLine("No such Key!");

partial class Interval
{
    //public static implicit operator Interval(float data)
    public static explicit operator Interval(float data)
    {
        int t = (int)(60 * data);
        return new Interval(0, t);
    }
}
