using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{

    class Student
    {
        public Student(string firstName,string secondName, double grade)
        {
            FirstName = firstName;
            LastName = secondName;
            Grade = grade;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> listOfAllStudent = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] currStudent = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstName=currStudent[0];
                string secondName=currStudent[1];
                double grade = double.Parse(currStudent[2]);

                Student newStudent = new Student(firstName, secondName, grade);
                listOfAllStudent.Add(newStudent);

            }

            List<Student> orderedStudents = listOfAllStudent.OrderByDescending(grade => grade.Grade).ToList();
            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
           
        }
    }
}
