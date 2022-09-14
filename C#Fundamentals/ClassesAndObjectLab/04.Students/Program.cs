using System;
using System.Collections.Generic;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] splitStudentParameters = command.Split(' ');


                string firstName = splitStudentParameters[0];
                string lastName = splitStudentParameters[1];
                string age = splitStudentParameters[2];
                string homeTown = splitStudentParameters[3];
                bool doesStudentExist = DoesStudentExist(students, firstName, lastName);



                if (doesStudentExist)
                {
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);
                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;    
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;

                    //Ne go prisvoqvame zashttoto sa referanceType i stoinostite se promenqt v vsichki listove kydeto se sydyrjva obecta


                }
                else
                {

                    Student newStudent = new Student(firstName, lastName, age, homeTown);

                    students.Add(newStudent);
                }
                command = Console.ReadLine();
            }

            string cityToFilter = Console.ReadLine();

            //foreach (var student in students)
            //{
            //    if (cityToFilter==student.HomeTown)
            //    {
            //        Console.WriteLine($"{ student.FirstName} { student.LastName} is { student.Age } years old.");
            //    }
            //}
            List<Student> filteredStudentList = students.FindAll(student => student.HomeTown == cityToFilter);
            foreach (var student in filteredStudentList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

       static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
                return null;
        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }

            }
            return false;
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, string age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
    }
}
