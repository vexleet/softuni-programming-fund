using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup_08
{
    class Student
    {
        public string Name;
        public List<string> Comments = new List<string>();
        public List<DateTime> Attendance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            string input = Console.ReadLine();
            string[] inputToArray = input.Split(' ', ',').ToArray();

            while(input != "end of dates")
            {
                Student currentStudent = new Student();
                string currentName = inputToArray[0];

                currentStudent.Name = currentName;
                currentStudent.Attendance = new List<DateTime>();
                for (int i = 1; i < inputToArray.Length; i++)
                {
                    currentStudent.Attendance.Add(DateTime.ParseExact(inputToArray[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (allStudents.Any(x => x.Name == currentName))
                {
                    Student existingStudent = allStudents.First(x => x.Name == currentName);

                    for (int i = 0; i < currentStudent.Attendance.Count(); i++)
                    {
                        existingStudent.Attendance.Add(currentStudent.Attendance[i]);
                    }
                }
                else
                {
                    allStudents.Add(currentStudent);
                }
                input = Console.ReadLine();
                inputToArray = input.Split(' ', ',').ToArray();
            }

            input = Console.ReadLine();
            inputToArray = input.Split('-').ToArray();

            while (input != "end of comments")
            { 
                string currentName = inputToArray[0];
                string comment = inputToArray[1];

                for (int i = 0; i < allStudents.Count(); i++)
                {
                    if(allStudents[i].Name == currentName)
                    {
                        allStudents[i].Comments.Add(comment);
                    }
                }

                input = Console.ReadLine();
                inputToArray = input.Split('-').ToArray();
            }

            foreach (var student in allStudents.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Attendance.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
