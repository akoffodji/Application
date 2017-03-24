using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testInterface;
using Declaration;

namespace Application
{//blabla William
    class Program
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }

        unsafe static void Main(string[] args)
        {

            Human onePerson;
            onePerson = new Student("Jaelle","Yaba",1993,8,5);
            onePerson.objectName = "Special Student";
            Console.WriteLine(onePerson.objectName);
            testerPointeur oneTest;
            oneTest = new testerPointeur();
            Point p = new Point(17, 25);

#if (DEBUG)
            Console.WriteLine("En mode Debug");
            PrintPoint(p);
            Console.WriteLine("Modification de x et y");
            p.x = 1017;
            p.y = 1710;
            Console.WriteLine("My point: x = " + p.x + " y = " + p.y);
#endif
#if (RELEASE)
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
#endif
        }
    }
}