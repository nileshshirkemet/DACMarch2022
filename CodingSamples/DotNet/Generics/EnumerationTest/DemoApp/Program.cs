SimpleStack<string> a = new SimpleStack<string>();
a.Push("Monday");
a.Push("Tuesday");
a.Push("Wednesday");
a.Push("Thursday");
a.Push("Friday");
for(var e = a.GetEnumerator(); e.MoveNext();)
    Console.WriteLine(e.Current);
Console.WriteLine("---------------------");
SimpleStack<double> b = new SimpleStack<double>();
b.Push(32.1);
b.Push(45.2);
b.Push(54.3);
b.Push(68.4);
b.Push(27.5);
b.Push(19.6);
b[2] = 73.4; //setting value of node 2 step below the top using the indexer property
foreach(double d in b)
    Console.WriteLine(d);


