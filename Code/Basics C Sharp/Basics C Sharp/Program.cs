using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        unsafe static void Main(string[] args)
        {

            Human onePerson;
            onePerson = new Student();
            testerPointeur oneTest;
            oneTest = new testerPointeur();

            Console.WriteLine(onePerson.getFirstName() + " " + onePerson.getLastName());

            int valueProf = 5;
            int valueStudent = 25;

            oneTest.setNumberProf(ref valueProf);

            oneTest.setNumberStudent(ref valueStudent);

            Console.WriteLine(*oneTest.getNumberProf() + *oneTest.getNumberStudent());

            onePerson.setFirstName("Thibault");
            onePerson.setLastName("Courtois");

            Console.WriteLine("Hello World Jean Jacques Sur le Cloud!");

            Console.WriteLine(onePerson.getFirstName() + " " + onePerson.getLastName());

            Console.WriteLine("Hello World Jean Jacques Sur le Cloud!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}