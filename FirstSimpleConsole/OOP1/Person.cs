using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Polymorphism {

    class Person {

        #region Data or Fields without Encapsulation

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        /// <summary>
        /// False : Female
        /// </summary>
        public bool Gender;

        #endregion

        #region Logic or Metods or Functions or Behaviors

        public void Walk() {
            Console.WriteLine(FirstName + " is walking.");
        }

        public void Eat() {
            Console.WriteLine(FirstName + " is eating.");
        }

        #endregion

        #region Destructor
        ~Person() {
            //destructor
            Console.WriteLine("Destructor is called.");
        }
        #endregion
    }
}
