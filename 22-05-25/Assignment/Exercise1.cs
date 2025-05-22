using System;

List<string> students = new List<string> { "Ramya", "Sowmya", "Reddy", "Diana", "King" };

// Display original list
Console.WriteLine("Original List:");
foreach (var name in students)
    Console.WriteLine(name);

// Sort and display
students.Sort();
Console.WriteLine("\nSorted List:");
foreach (var name in students)
    Console.WriteLine(name);
