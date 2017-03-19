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
            Console.WriteLine("Hello World Jean Jacques Sur le Cloud!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


    abstract class Human
    {
        protected DateTime dateOfBirth;

        protected string firstName;

        protected string lastName;

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

        private void setFirstName(string value)
        {
            firstName = value;
        }

        private void setLastName(string value)
        {
            lastName = value;
        }

    }   
    
}
