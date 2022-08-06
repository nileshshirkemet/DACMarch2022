int t = args.Length > 0 ? int.Parse(args[0]) : 126;
List<Interval> store = new List<Interval>();
store.Add(new Interval(4, 31));
store.Add(new Interval(6, 52));
store.Add(new Interval(7, 43));
store.Add(new Interval(5, 14));
store.Add(new Interval(3, 25));
store.Add(new Interval(0, t));
foreach(var i in store)
    Console.WriteLine(i);
Console.WriteLine("Third Interval = {0}", store[2]);
