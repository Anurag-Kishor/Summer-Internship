using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        string _firstname;
        string _lastname;

        public Student() : this("No Firstname", "No lastname") { }

        public Student(string FirstName, string LastName)
        {
            this._firstname = FirstName;
            this._lastname = LastName;
        }

        public void PrintName()
        {
            Console.WriteLine("Full Name: {0} {1}", _firstname, _lastname);
        }

    }

    
}
