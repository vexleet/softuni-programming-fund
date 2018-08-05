using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades_04
{
    class Student
    {
        public string name;
        public List<double> grades = new List<double>();
        public double average;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            List<Student> excellentStudents = new List<Student>();

            for (int i = 0; i < students; i++)
            {
                string[] currentStudent = Console.ReadLine().Split().ToArray();
                Student next = new Student();
                next.name = currentStudent[0];

                for (int j = 1; j < currentStudent.Length; j++)
                {
                    next.grades.Add(Convert.ToDouble(currentStudent[j]));
                }

                next.average = next.grades.Average();

                if(next.average >= 5.00)
                {
                    excellentStudents.Add(next);
                }
            }

            excellentStudents = excellentStudents.OrderBy(x => x.name).ThenByDescending(x => x.average).ToList();

            foreach (var item in excellentStudents)
            {
                Console.WriteLine($"{item.name} -> {item.average:f2}");
            }
        }
    }


}
