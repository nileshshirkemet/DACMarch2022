namespace Payroll
{
    //SalesPerson is derived class of Employee (base class)
    class SalesPerson : Employee
    {
        //automatic property
        public double Sales { get; set; }

        public SalesPerson(int h, float r, double s) : base(h, r)
        {
            Sales = s;
        }

        //overriding virtual method of base class
        public override double Income()
        {
            double salary = base.Income();
            if(Sales >= 20000)
                salary += 0.05 * Sales;
            return salary;
        }
    }
}