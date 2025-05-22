using System;
using System.Collections.Generic;
using System.Linq;
class Student
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
            List<Student> studentList = new()
            {
                new Student { Name = "A", Marks = 70 },
                new Student { Name = "B", Marks = 80 },
                new Student { Name = "C", Marks = 60 },
                new Student { Name = "D", Marks = 90 },
                new Student { Name = "E", Marks = 75 }
            };
            double avg = studentList.Average(s => s.Marks);
            int count = studentList.Count(s => s.Marks > avg);

            Console.WriteLine($"Average: {avg}");
            Console.WriteLine($"Students above average: {count}");
        }
    }
}







