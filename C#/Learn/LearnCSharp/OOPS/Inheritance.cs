using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Employee
    {
        public string FirstName;
        public string LastName;

        public virtual void PrintFullName()
        {
            Console.WriteLine("Base Class");
            Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
        }
    }

    class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        public override void PrintFullName()
        {
            Console.WriteLine("Full Time Employee Class");
            Console.WriteLine("Employee Name: {0} {1}\nSalary: {2}\n", FirstName, LastName, YearlySalary);
        }
    }

    class PartTimeEmployee : Employee
    {
        public float HourlySalary;

        public override void PrintFullName()
        {
            Console.WriteLine("Part Time Employee Class");
            base.PrintFullName();                               
            Console.WriteLine("Salary: {0}", HourlySalary);
        }
    }

    class TemporaryEmployee : Employee {

        public override void PrintFullName()
        {
            Console.WriteLine("Temporary Time Employee Class");
        }
    }

}
