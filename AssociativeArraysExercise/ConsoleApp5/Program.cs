using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,List<string>> Courses = new Dictionary<string,List<string>>();

             string input = Console.ReadLine();

            while (input!="end")
            {
                string[] studentInfo=input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = studentInfo[0];
                string studentName = studentInfo[1];


                if (!Courses.ContainsKey(courseName))
                {
                    Courses.Add(courseName, new List<string>());
                    Courses[courseName].Add(studentName);
                }
                else
                {
                    Courses[courseName].Add(studentName);
                }
                    input   = Console.ReadLine();   

            }
            
           

                foreach (var course in Courses)
                {
                    Console.WriteLine($"{course.Key}: {course.Value.Count}");
                    foreach (var student in course.Value)
                    {
                        Console.WriteLine($"-- {student}");
                    }
                }





        }
    }
}
