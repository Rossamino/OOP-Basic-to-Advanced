using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP1.Polymorphism;

namespace OOP1
{
    class Program
    {
        public static void Main(string[] args) {
            Person person = new Person();
            person.FirstName = "Alice";
            person.Walk();

            var destructor = new DestructorClass();
            destructor = null;
            GC.Collect();

            Console.ReadKey();
        }
    }
}

