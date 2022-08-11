using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Student
    {
        public Student(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
    
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public
            override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.".ToString();
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

           string input = Console.ReadLine();
            while (input!="End")
            {
                string[] studentInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                    
                string name = studentInfo[0];
                string iD = studentInfo[1];
                int age = int.Parse(studentInfo[2]);


                if (students.Any(student=>student.ID==iD))
                {

               Student currStudent = students.FirstOrDefault(student=>student.ID==iD);
                    currStudent.Name = name;
                    currStudent.Age = age;
                    continue;
                }

                Student newStudent = new Student(name, iD, age);
                students.Add(newStudent);


                input = Console.ReadLine();
            }

            List<Student> orderedStudentsByAge = students
                .OrderBy(student => student.Age)
                .ToList();

            foreach (Student student in orderedStudentsByAge)
            {
            Console.WriteLine(student);

            }

            
        }
    }
}
