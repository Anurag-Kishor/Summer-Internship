using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InSem1
    {
        internal static void InSem1Solution()
        {
            // Q1();
            //Q3();
            //Q4();
            //Q5();
            Q6();
            Console.ReadLine();
        }

        private static void Q6()
        {
            Point p = new Point(5, 10);
            p.Deconstruct();
        }
        private static void Q5()
        {
            AnArray();
        }
        private static void Q4()
        {
            KnowVar kv = new KnowVar();
            kv.MyMethod(5, 15);
        }
        private static void Q3()
        {
            checked
            {
                try
                {
                    int i = Int32.MaxValue;
                    int y = i + 1;

                    Console.WriteLine(y);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private static void Q2()
        {
            string s = "hello world";
            s.Replace('o', 'i');
            s.Replace("r", string.Empty);
            Console.WriteLine(s);
            //Output: Hello World. Replace returns a new string and does not directly modify the string s.
        }

        private static void Q1()
        {
            int a = 10, b = 20;
            int sum = Calculator.AddNums(a, b);
            /* fill in the blank below*/
            string output = "The ouput of " + a + " and " + b + " is " + sum;
            Console.WriteLine(output);
        }

        private static void AnArray()
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(false);
            arr.Add(new DateTime(2019, 01, 01));
            arr.Add("sample string");

        }
    }


    class Point
    {
        public Point(float x, float y)
        {
            this._x = x;
            this._y = y;
        }
        private readonly float _x;
        private readonly float _y;

        public float x{
            get
            {
                return this._x;
            }
        }

        public float y
        {
            get
            {
                return this._y;
            }
        }
        public void Deconstruct()
        {
            Console.WriteLine(x + " " + y);
        }

    }

    class Calculator
    {
        public static int AddNums(int a, int b)
        {
            return a + b;
        }
    }

    class KnowVar
    {
        int _m = 10;
        public void MyMethod(int i, int j = 10)
        {
            var k = i + j;
            var sum = "The sum";
            int n;
            string mul;
            n = i * j;
            mul = "The multiplication";
            var ob = new KnowVar();
            KnowVar ob2 = null;


        }
    }

}