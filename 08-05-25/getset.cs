using System;
using System.Collections.Generic;
class student
{
    public int ID { get; set; }
    public string Name { get; set; }
}
class program
{
    static void Main()
    {
        List<student> students = new List<student>
        {
            new student { ID = 1, Name = "Ramya" },
            new student { ID = 2, Name = "prasad" }
        };

        //Add another student
        students.Add(new student { ID = 3, Name = "Reddy" });

        foreach (var student in students)
        {
            Console.WriteLine($"ID {student.ID}, name {student.Name}");
        }
    }
}