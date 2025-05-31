using System;
using System.Collections.Generic;
using System.Linq;

/*class Program
{
    static void Main()
    {
        
        Dictionary<string, List<int>> gradebook = new Dictionary<string, List<int>>();

        
        gradebook["Ramya"] = new List<int> { 85, 90, 78 };
        gradebook["Sowmya"] = new List<int> { 92, 88, 95 };
        gradebook["Reddy"] = new List<int> { 70, 68, 65 };
        gradebook["Diana"] = new List<int> { 95, 98, 92 };
        gradebook["Ravi"] = new List<int> { 80, 75, 70 };
        gradebook["Raju"] = new List<int> { 60, 55, 50 };

        Console.WriteLine("Student Grades Summary:\n");

        
        foreach (var student in gradebook)
        {
            var name = student.Key;
            var marks = student.Value;
            var avg = marks.Average();
            var max = marks.Max();
            var min = marks.Min();

            Console.WriteLine($"{name}: Avg = {avg:0.00}, Max = {max}, Min = {min}");
        }

        Console.WriteLine("\nTop 3 Scorers:");
        var top3 = gradebook
            .Select(s => new { Name = s.Key, Avg = s.Value.Average() })
            .OrderByDescending(s => s.Avg)
            .Take(3);

        foreach (var student in top3)
        {
            Console.WriteLine($"{student.Name}: {student.Avg:0.00}");
        }
    }
}*/

