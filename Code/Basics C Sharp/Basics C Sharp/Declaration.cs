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



namespace Declaration
{

    interface IObject
    {
        string objectName
        {
            set; get;
        }
        string objectDescription
        {
            set; get;
        }
    }

    class Object : IObject
    {
        // Attributs
        private string _objectName;
        private string _objectDescription;

        // Contructeurs
        public Object(string name, string description)
        {
            _objectName = name;
            _objectDescription = description;
        }

        // Implementations des méthodes
        public string objectName
        {
            get
            {
                return _objectName;
            }

            set
            {
                _objectName = value;
            }
        }

        public string objectDescription
        {
            get
            {
                return _objectDescription;
            }

            set
            {
                _objectDescription = value;
            }
        }
    }

    interface IHuman
    {
        string firstName
        {
            set; get;
        }
        string lastName
        {
            set; get;
        }
        DateTime dateOfBirth
        {
            set; get;
        }
    }

    class Human : Object, IHuman
    {

        public Human():base("Human", "Description of class Human")
        {
            _firstName = "Random First Name";
            _lastName = "Random Last Name";
            _dateOfBirth = new DateTime(1717, 7, 17);
        }

        public Human(string firstName, string lastName, int year, int month, int day) :base("Human","Description of class Human")
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = new DateTime(year, month, day);
        }

        public string firstName
        {
            set
            {
                _firstName = value;
            }

            get
            {
                return _firstName;
            }

        }

        public string lastName
        {
            set
            {
                _lastName = value;
            }

            get
            {
                return _lastName;
            }

        }

        public DateTime dateOfBirth
        {
            set
            {
                _dateOfBirth = value;
            }

            get
            {
                return _dateOfBirth;
            }

        }

        private string _firstName;

        private string _lastName;

        private DateTime _dateOfBirth;

    }

    interface IStudent
    {
        string classTaken
        {
            set; get;
        }
    }

    class Student : Human, IStudent
    {
        public Student(string firstName, string lastName, int year, int month, int day) :base(firstName, lastName, year, month, day)
        {
            base.objectName = "Student";
            base.objectDescription = "Any human being enrolled to the school.";
            _classTaken = "Mathematique";
        }

        public Student() : base()
        {
            base.objectName = "Student";
            base.objectDescription = "Any human being enrolled to the school.";
            _classTaken = "Mathematique";
        }

        public string classTaken
        {
            set
            {
                _classTaken = value;
            }

            get
            {
                return _classTaken;
            }

        }

        private string _classTaken;
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
