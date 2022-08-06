var shop = new Shop();
if(args[0] == "items")
{
    shop.GetItems()
        .Where(i => i.Brand == args[1]) //standard query operators
        .Select(i => i.Name)
        .Capitalize()
        .PrintEachWith(Console.WriteLine);
}
else if(args[0] == "customers")
{
    decimal min = decimal.Parse(args[1]);
    var customers = shop.GetCustomers();
    var selection = from c in customers //C# query syntax
                    where c.Purchase >= min
                    orderby c.Id descending
                    select new //create an instance of an anonymous type with specified properties
                    {
                        Name = c.Id.ToUpper(),
                        Stars = new string('*', c.Rating)
                    };
    foreach(var entry in selection)
        Console.WriteLine($"{entry.Stars}\t{entry.Name}");
}
