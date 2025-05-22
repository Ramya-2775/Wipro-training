using System;
using System.Collections.Generic;
using System.Linq;
Class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}
namespace students
{
    class program
    {
        static void Main(string[] args)
        {
            List<Student> students = new()
            {
                new Student { Name = "A", Marks = 75 },
                new Student { Name = "B", Marks = 85 },
                new Student { Name = "C", Marks = 95 },
                new Student { Name = "D", Marks = 65 },
                new Student { Name = "E", Marks = 90 },
                new Student { Name = "F", Marks = 70 }

            };
            var topStudents = students.OrderByDescending(s => s.Marks).Take(3);
            foreach (var s in topStudents)
                Console.WriteLine($"{s.Name}: {s.Marks}");


        }
    }
}








