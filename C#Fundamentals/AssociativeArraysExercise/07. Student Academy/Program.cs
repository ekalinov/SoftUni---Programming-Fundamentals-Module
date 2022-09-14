using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> Students = new Dictionary<string, List<double>>();




            for (int i = 0; i < input; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (DOesStudentExist(Students, studentName))
                {
                    Students[studentName].Add(studentGrade);
                }
                else
                {
                    Students.Add(studentName, new List<double>());
                    Students[studentName].Add(studentGrade);
                }

            }

            PrintAboveAverageStudents(Students);



        }

        private static bool DOesStudentExist(Dictionary<string, List<double>> students, string studentName)
        {
            if (students.ContainsKey(studentName))
            {
                return true;
            }
            
            return false;
        }

        private static void PrintAboveAverageStudents(Dictionary<string, List<double>> students)
        {
            foreach (var student in students)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }

        }
    }
}
