using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testInterface;
using Declaration;
using MySql.Data.MySqlClient;

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


            MySqlConnection variableDeConnection = new MySqlConnection();

            variableDeConnection.ConnectionString = @"server=localhost;
                                          user id=root;
                                          persistsecurityinfo=True;
                                          database=sakila;password=jj0000";


            try
            {
                variableDeConnection.Open();
                Console.WriteLine("Connection reussie");
                try
                {
                    MySqlCommand variableDeCommande = new MySqlCommand(
                                                          @"select * from sakila.actor;",
                                                          variableDeConnection);



                    MySqlDataReader reader = variableDeCommande.ExecuteReader();
                    reader.Read();
                    Console.WriteLine(reader.GetString(1));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("command problem ");
                }
            }

            catch (Exception ex)
            {

                Console.WriteLine("can not open connection ! because of connection");
            }

            // Create the command
            //SqlCommand command = new SqlCommand("SELECT * FROM TableName WHERE FirstColumn = @firstColumnValue", conn);
            // Add the parameters.
            //command.Parameters.Add(new SqlParameter("firstColumnValue", 1));


            Human onePerson;
            onePerson = new Student("Jaelle","Yaba",1993,8,5);
            onePerson.objectName = "Special Student";
            onePerson.objectDescription = "Object Test";
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