using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HelloFunctionDelegate(string Message);
public delegate void TestDelegate();
public delegate double CalAreaPointer(int r);
namespace OOPS
{
    class Delegates
    {
        public static void FunctionDelegate()
        {
            List<Customer> listCustomers = new List<Customer>()
            {
                new Customer{ ID = 100, Name = "John"},
                new Customer{ ID = 101, Name = "Jack"},
                new Customer{ ID = 102, Name = "Jill"}
            };

            Func<Customer, string> selector = customer => "Name: " + customer.Name;
            IEnumerable<string> names = listCustomers.Select(selector);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void Delegate()
        {
            // HelloFunctionDelegate hfd = new HelloFunctionDelegate(Hello);
            // hfd("Hello");

            /*
            List<Employees> empList = new List<Employees>();
            empList.Add(new Employees() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employees() { ID = 102, Name = "John", Salary = 51000, Experience = 4 });
            empList.Add(new Employees() { ID = 103, Name = "Jack", Salary = 15000, Experience = 6 });
            empList.Add(new Employees() { ID = 104, Name = "Jill", Salary = 10000, Experience = 3 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            //Employees.PromoteEmployee(empList, isPromotable);

            Employees.PromoteEmployee(empList, emp => emp.Experience >= 5);*/


            /* ----- Multicast Delegate ----- */
            //TestDelegate t1;
            //t1 = new TestDelegate(Delegate1);
            //t1 += Delegate2;
            //t1 += Delegate3;

            //t1();

            //t1 -= Delegate2;
            //t1();

            /*---------------------------------------------------------------------------*/
            //CalAreaPointer calcPointer = new CalAreaPointer(delegate (int r)
            //{
            //    return 3.14 * r * r;
            //});

            //double area = calcPointer(5);

            /*---------------------------------------------------------------------------*/

            //CalAreaPointer cpointer = r => 3.12 * r * r;
            //var area = cpointer(5);

            /*---------------------------------------------------------------------------*/
            // USed when there is both input and output 

            //Func<double, double> cpointer = r => 3.14 * r * r;
            //var area = cpointer(5);


            /************************Action Delegate**************************************/
            // USed when there is nothing to return or output 
            //Action<string> MyAction = y => Console.WriteLine(y);
            //MyAction("Hello");

            /**********************Predicate Delegate************************************/
            /* Used to check some condition. Always returns a boolean*/
            Predicate<string> CheckGreaterThanFive = x => x.Length > 5;
            Console.WriteLine(CheckGreaterThanFive("helloworld");
        }

        public static bool Promote(Employees emp)
        {
            if (emp.Experience >= 5) return true;
            else return false;
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        public static void Delegate1()
        {
            Console.WriteLine("Delegate1");

        }
        public static void Delegate2()
        {
            Console.WriteLine("Delegate2 ");

        }
        public static void Delegate3()
        {
            Console.WriteLine("Delegate3");
        }
    }

    delegate bool IsPromotable(Employees empl);

    class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        
        public static void PromoteEmployee(List<Employees> empList, IsPromotable IsEligibleToPromote)
        {
            foreach (var e in empList)
            {
                if(IsEligibleToPromote(e))
                {
                    Console.WriteLine(e.Name + " promoted");
                }
      
            }
        }
    }
}
