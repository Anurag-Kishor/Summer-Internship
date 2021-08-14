using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Generics
    {
        public static void GenericTest()
        {
            bool Equal = Calculator.AreEqual<int>(5, 10);

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }

    public class Calculator { 
        public static bool AreEqual<T>(T n1, T n2)
        {
            return n1.Equals(n2);
        }
    }

}
