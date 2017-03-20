using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testInterface
{
    interface IPoint
    {
        // Property signatures:
        int x
        {
            get;
            set;
        }

        int y
        {
            get;
            set;
        }
    }

    class Point : IPoint
    {
        // Fields:
        private int _x;
        private int _y;

        // Constructor:
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Property implementation:
        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }
}



namespace Application
{

    abstract class Object
    {
        
    }


    abstract class Human : Object
    {
        private DateTime dateOfBirth;

        private string firstName;

        private string lastName;


        public Human()
        {
            dateOfBirth = new DateTime(1992, 9, 17);
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

        public void setClassTaken(string value)
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

    unsafe class testerPointeur
    {
        private int* numberStudent;
        private int* numberProf;

        public testerPointeur()
        {
            int a = 8;
            numberProf = &a;
            numberStudent = &a;
        }

        public int* getNumberStudent()
        {
            return numberStudent;
        }

        public int* getNumberProf()
        {
            return numberProf;
        }

        public void setNumberStudent(ref int value)
        {
            fixed (int* ptr = &value)
            {
                numberStudent = ptr;
            }
        }

        public void setNumberProf(ref int value)
        {
            fixed (int* ptr = &value)
            {
                numberProf = ptr;
            }
        }
    }
}
