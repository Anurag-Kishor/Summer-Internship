using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }
    class Customer : ICustomer2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void Print1()
        {
            Console.WriteLine("Print 1");
        }

        public void Print2()
        {
            Console.WriteLine("Print 2");
        }
    }

}
