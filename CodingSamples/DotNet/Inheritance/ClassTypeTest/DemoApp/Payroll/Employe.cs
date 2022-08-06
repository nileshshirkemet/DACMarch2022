namespace Payroll 
{
    class Employee
    {
        private int hours;
        private float rate;
        private static int count;

        public Employee(int h, float r)
        {
            hours = h;
            rate = r;
            ++count;
        }

        public Employee() : this(0, 0) {}

        //property provides get/set methods which can be called
        //using field access syntax
        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        //overridable method
        public virtual double Income()
        {
            double salary = hours * rate;
            int ot = hours - 180;
            if(ot > 0)
                salary += 50 * ot;
            return salary;
        }

        public static int CountInstances()
        {
            return count;
        }
    }
}