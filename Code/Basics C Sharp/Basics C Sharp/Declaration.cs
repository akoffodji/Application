using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testInterface;


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

    
}



namespace Declaration
{

    interface IObject
    {
        int objectId
        {
            get;
        }
        bool dataBaseSaving
        {
            get;
        }
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
        private int _objectId;
        private bool _dataBaseSaving;

        // Contructeurs
        public Object(string name, string description)
        {
            _objectName = name;
            _objectDescription = description;
        }

        // Implementations des méthodes
        public int objectId
        {
            get { return _objectId; }
        }
        public bool dataBaseSaving
        {
            get { return _dataBaseSaving; }
        }
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
            _phoneNumber = "111111111";
            _fatherName = "Father Name";
            _motherName = "Mother Name";
            _cityzenchip = "Benin";
            _scholarYear = "2017-2018";
    }

        public Human(string firstName, string lastName, int year, int month, int day) :base("Human","Description of class Human")
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = new DateTime(year, month, day);
            _phoneNumber = "111111111";
            _fatherName = "Father Name";
            _motherName = "Mother Name";
            _cityzenchip = "Benin";
            _scholarYear = "2017-2018";
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

        public string phoneNumber
        {
            set { _phoneNumber = value; }
            get { return _phoneNumber; }
        }

        public string fatherName
        {
            set { _fatherName = value; }
            get { return _fatherName; }
        }

        public string motherName
        {
            set { _motherName = value; }
            get { return _motherName; }
        }

        public string cityzenchip
        {
            set { _cityzenchip = value; }
            get { return _cityzenchip; }
        }

        public string scholarYear
        {
            set { _scholarYear = value; }
            get { return _scholarYear; }
        }

        private string _firstName;

        private string _lastName;

        private DateTime _dateOfBirth;

        private string _phoneNumber;

        private string _fatherName;

        private string _motherName;

        private string _cityzenchip;

        private string _scholarYear;
    }

    interface IStudent
    {
        string classTaken
        {
            set; get;
        }
    }

    class Student : Human, IStudent, IPoint
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
        private int _x;
        private int _y;


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
