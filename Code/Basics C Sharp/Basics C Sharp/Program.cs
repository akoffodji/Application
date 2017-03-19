using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Human onePerson;
            onePerson = new Student();

            onePerson.setFirstName("Thibault");
            onePerson.setLastName("Courtois");

            Console.WriteLine("Hello World Jean Jacques Sur le Cloud!");

            Console.WriteLine(onePerson.getFirstName() + " " + onePerson.getLastName());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


    abstract class Human
    {
        private DateTime dateOfBirth;

        private string firstName;

        private string lastName;


        public Human()
        {
            dateOfBirth = new DateTime(1992,9,17);
            firstName = "Jean Jacques";
            lastName = "Akoffodji";
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public DateTime getDateOfBirth()
        {
            return dateOfBirth;
        }

        public void setFirstName(string value)
        {
            firstName = value;
        }

        public void setLastName(string value)
        {
            lastName = value;
        }

    }   

    class Student : Human
    {

        protected string classTaken;

        public string getClassTaken()
        {
            return classTaken;
        }

        private void setClassTaken(string value)
        {
            classTaken = value;
        }
    }

    class Employee : Human
    {

    }

    class Parent : Human
    {

    }

    class Professor : Employee
    {

    }
}
