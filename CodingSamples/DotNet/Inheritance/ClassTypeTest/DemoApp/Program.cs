using Payroll;

//C# supports top-level statements (in an Exe type project) which are
//inserted by the compiler into the Main method of auto-generated Program class
 
Employee jack = new Employee();
jack.Hours = 186;
jack.Rate = 52;
Console.WriteLine("Jack's Income is {0:0.00}, Tax is {1:0.00} and Bonus is {2:0.00}", jack.Income(), Tax(jack), Bonus(jack));
SalesPerson jill = new SalesPerson(186, 52, 48000);
Console.WriteLine("Jill's Income is {0:0.00}, Tax is {1:0.00} and Bonus is {2:0.00}", jill.Income(), Tax(jill), Bonus(jill));
Appraise(jack);
Console.WriteLine("Jack's Appraised Income: {0:0.00}", jack.Income());
if(args.Length > 0)
{
    int d = int.Parse(args[0]);
    Employee? you = Recruit(d);
    if(you != null)
        Console.WriteLine("Your Initial Income: {0:0.00}", you.Income());
    else
        Console.WriteLine("You will not be recruited!");
}
Console.WriteLine("Number of Employees = {0}", Employee.CountInstances());


//local function (method defined in a method cannot be overloaded)
double Tax(Employee emp)
{
    double i = emp.Income();
    return i > 10000 ? 0.15 * (i - 10000) : 0;
}

double Bonus(Employee emp)
{
    if(emp is SalesPerson)
        return 0;
    return 0.1 * emp.Income();
}

void Appraise(Employee emp)
{
    emp.Rate *= 0.05f * (emp.Hours - 160);    
}

//returning a nullable reference type
//only allowed if Nullable feature is enabled (see DemoApp.csproj)
Employee? Recruit(int days)
{
    if(days >= 15)
        return new Employee(8 * days, 50);
    return null;
}
