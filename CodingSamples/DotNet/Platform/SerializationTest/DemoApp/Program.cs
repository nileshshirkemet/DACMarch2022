using Tourism;

//conditional compilation based on constants defined in DemoApp.csproj
#if USE_XML
ISiteStore store = new XmlSiteStore();
#else
ISiteStore store = new JsonSiteStore();
#endif

Site site = store.Load("CitiZoo");
if(args.Length > 0)
{
    string name = args[0].ToLower();
    Visitor visitor = site.GetVisitor(name);
    long ticket = visitor.Visit();
    Console.WriteLine("Welcome {0}, your ticket number is {1}", visitor.Id, ticket);
    store.Save(site);
}
else
{
    foreach(Visitor entry in site.Visitors)
        Console.WriteLine("{0}\t{1}\t{2}", entry.Id, entry.VisitCount, entry.LastVisit);
}

