using System;
using System.Collections.Generic;

namespace Part_9___Making_a_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Student person = new Student("Robert", "Ross");
            Console.WriteLine(person.FirstName);
            person.FirstName = "Bob";
            Console.WriteLine(person.FirstName);

            Console.WriteLine("");

            Console.WriteLine(person.LastName);
            person.LastName = "Jimmy";
            Console.WriteLine(person.LastName);

            Console.WriteLine("");

            Console.WriteLine(person.StudentNumber);
            Console.WriteLine(person);

            Console.WriteLine("");

            Console.WriteLine(person.Email);

            Console.WriteLine("");

            List<Student> students = new List<Student>();
            

            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Please Enter You First Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Please Enter Your Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("");

                students.Add(new Student(firstName, lastName));
            }

            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine("");

        }
    }
}
