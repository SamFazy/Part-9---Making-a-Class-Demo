using System;
using System.Collections.Generic;
using System.Text;

namespace Part_9___Making_a_Class_Demo
{
    class Student
    {
        private static Random generator = new Random();
        private string _firstName;
        private string _lastName;
        private string _email;

        private int _studentNumber;

        public Student(string firstName, string lastName)
        {
            // Instance variables/fields initialized here
            _firstName = firstName;
            _lastName = lastName;

            _studentNumber = generator.Next(100 ,1000);
            GenerateEmail();
        }

        public string FirstName
        {
            get
            {
                return _firstName;
                GenerateEmail();
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
                GenerateEmail();
            }
            set
            {
                _lastName = value.ToLower();
            }
        }

        public int StudentNumber
        {
            get
            {
                return _studentNumber;
            }
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

        private void GenerateEmail()
        {
            // first 3 letters of first name, first 3 letters of last name, student number, @ICS4U.ca
            _email = _firstName.Substring(0, 3) + _lastName.Substring(0, 3) + _studentNumber + "@ICS4U.ca";

        }

        public string Email
        {
            get
            {
                return _email;
            }
        }

    }
}
