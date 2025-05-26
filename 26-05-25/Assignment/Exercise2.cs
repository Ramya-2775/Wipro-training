using System;
using System.Collections.Generic;
using System.Linq;

/*namespace StudentRankList
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public char Grade { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student { Name = "Ramya", Marks = 95, Grade = 'A' },
                new Student { Name = "Sowmya", Marks = 88, Grade = 'B' },
                new Student { Name = "Reddy", Marks = 92, Grade = 'A' },
                new Student { Name = "David", Marks = 85, Grade = 'B' },
                new Student { Name = "catherine", Marks = 76, Grade = 'C' },
                new Student { Name = "Frank", Marks = 90, Grade = 'A' },
                new Student { Name = "Grace", Marks = 78, Grade = 'C' },
                new Student { Name = "Henry", Marks = 80, Grade = 'B' },
                new Student { Name = "Ivy", Marks = 84, Grade = 'B' },
                new Student { Name = "Jack", Marks = 70, Grade = 'D' }
            };

            var sorted = students.OrderByDescending(s => s.Marks);
            var grouped = students.GroupBy(s => s.Grade);
            var top3 = sorted.Take(3);

            Console.WriteLine("Top 3 Students:");
            foreach (var student in top3)
                Console.WriteLine($"{student.Name} - {student.Marks} Marks");
        }
    }
}
 */