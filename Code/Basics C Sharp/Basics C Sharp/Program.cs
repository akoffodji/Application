using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
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
}