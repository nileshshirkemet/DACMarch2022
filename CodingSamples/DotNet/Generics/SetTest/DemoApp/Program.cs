int t = args.Length > 0 ? int.Parse(args[0]) : 126;
//ISet<Interval> store = new HashSet<Interval>();
//ISet<Interval> store = new SortedSet<Interval>();
ISet<Interval> store = new SortedSet<Interval>(new IntervalComparison());
store.Add(new Interval(4, 31));
store.Add(new Interval(6, 52));
store.Add(new Interval(7, 43));
store.Add(new Interval(5, 14));
store.Add(new Interval(3, 25));
store.Add(new Interval(0, t));
foreach(var i in store)
    Console.WriteLine(i);

class IntervalComparison : IComparer<Interval>
{
    public int Compare(Interval x, Interval y)
    {
        return x.Seconds - y.Seconds;
    }
}
