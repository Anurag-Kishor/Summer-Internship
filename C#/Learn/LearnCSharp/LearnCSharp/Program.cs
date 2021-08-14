using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LearnCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;
            myTimer.Start();*/


            Console.ReadLine();
        }

        /*---------------------------------------------------------------------------------------------------------------------*/

        private static void CSharpMethods()
        {
            int i = 5;
            Method1(i); //wont change value of i to 10
            Method2(ref i); //will change value of i to 20 as passing by reference

            Console.WriteLine(i);

            int sum = 0, product = 0;
            Method3(10, 20, out sum, out product);      //returns sum and product

            int[] num = new int[3] { 1, 2, 3 };
            Method4(num); //prints number of elements in array. 
            Method4();      //params keyword allow passing 0 arguements too
        }
        public static void Method1(int j)       //pass by value;
        {
            j = 10;
        }
        public static void Method2(ref int j)       //pass by refderence;
        {
            j = 20;
        }
        public static void Method3(int first, int second, out int Sum, out int Product)    //used to return multiple values
        {
            Sum = first + second;
            Product = first * second;       //returns sum and product
        }
        public static void Method4(params int[] Numbers)    //parameter arrays
        {
            Console.WriteLine("{0} elements in array", Numbers.Length);
        }

        /*---------------------------------------------------------------------------------------------------------------------*/

        private static void TypeConversions()
        {
            int i = 100;
            float f = i;    //Implicit conversion as float is bigger than int

            f = 123.45F;
            //int j = f;     //Throws error as information is lost in this conversion

            //int j = (int)f;     //Explicit conversion. Converts float to int.
            int j = Convert.ToInt32(f);     //Works same as above but will throw exception if size of value overflows size of int.
            Console.WriteLine(f);

            string strNumber = "100";
            i = int.Parse(strNumber);
            Console.WriteLine(i);

            strNumber = "100abcde";         //int.Parse will throw exception as string contains alphabets and not just int
            bool check = int.TryParse(strNumber, out i);   //returns a boolean to check if conversion is possible or not.

            if (check)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            Console.WriteLine(i);


        }
        private static void NullableType()
        {
            int? x = null;
            // int y = 0;
            //if(x == null)
            //{
            //    Console.WriteLine("x doesn't have a value");
            //}
            //else
            //{
            //    // y = x.Value;
            //    y = (int)x; 
            //}

            int y = x ?? 0;         //NULL Collapse operator, if x is not null then store its value in y, else store 0 in y.
            Console.WriteLine(y);
        }

        /*---------------------------------------------------------------------------------------------------------------------*/

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        /*---------------------------------------------------------------------------------------------------------------------*/

        private static void ArraysAndLists()
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "RObet Yeat";
            b1.Title = " Microsoft";
            b1.ISBN = "0-000-00000-0";
            */


            /*
            //ArrayList are dynamically sized
            // sorting, remove items

            //Drawback - allows all types into one list. Here, Car and Book
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }*/

            /*
            //Solution to above problem - USE LISTS with specific types.

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);

            }
            */

            //DICTIONARY - Key, value pair


            //Collection Initializer
            /*
            List<Car> myCars = new List<Car> {
                new Car() { Make = "OldsMobile", Model = "Cutlas Supreme", VIN = "E5", StickerPrice = 55000, Year = 2010},
                new Car() { Make = "Nissan", Model = "Altima", VIN = "F6", StickerPrice = 35000, Year = 1970},
                new Car() { Make="BMW", Model="745Li", VIN ="C3", StickerPrice = 75000, Year = 2002},
                new Car() { Make = "Ford", Model = "Escape", VIN = "A1", StickerPrice = 25000, Year = 2011},
                new Car() { Make = "BMW", Model = "55i", VIN = "D4", StickerPrice = 57000, Year = 2015}
            };
            */
            //LINQ query
            /*
             var bmws = from car in myCars
                       where car.Make == "BMW"
                       select car;
            */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            //LINQ Method
            //var bmws = myCars.Where(p => p.Make == "BMW");

            //var orderedCars = myCars.First(p => p.Make == "BMW");


            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.Make);
            }*/

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 1990));

            //myCars.ForEach(p => Console.WriteLine("{0} {1} {2:C}", p.VIN, p.Make, p.StickerPrice));
            //Console.WriteLine(myCars.Exists(p => p.Make == "BMW"));
            //Console.WriteLine("{0:C}",myCars.Sum(p => p.StickerPrice));

            //Console.WriteLine(myCars.GetType());

            /*
            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year > 1990
                          select new { car.Make, car.Model };

            Console.WriteLine(newCars.GetType());
            */
        }

        /*---------------------------------------------------------------------------------------------------------------------*/

        private static void DateAndTime()
        {
            DateTime myvalue = DateTime.Now;
            Console.WriteLine(myvalue.ToString());
            Console.WriteLine(myvalue.ToShortDateString());
            Console.WriteLine(myvalue.ToShortTimeString());
            Console.WriteLine(myvalue.ToLongDateString());
            Console.WriteLine(myvalue.ToLongTimeString());

            Console.WriteLine(myvalue.AddDays(3).ToLongDateString());


            DateTime mybirthday = new DateTime(1999, 11, 04);
            Console.WriteLine(mybirthday.ToLongDateString());

            DateTime datetime = DateTime.Parse("11/04/1999");
            TimeSpan myAge = DateTime.Now.Subtract(datetime);
            Console.WriteLine(myAge.TotalHours);
            Console.ReadLine();
        }

    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal StickerPrice { get; set; }

        public int Year { get; set; }


    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
