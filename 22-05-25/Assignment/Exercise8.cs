using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Dictionary<int, decimal> salaries = new()
{
    { 101, 50000 },
    { 102, 60000 },
    { 103, 70000 },
    { 104, 80000 }
};

Console.Write("Enter Employee ID: ");
int empId = int.Parse(Console.ReadLine());

if (salaries.TryGetValue(empId, out var salary))
    Console.WriteLine($"Salary: {salary}");
else
    Console.WriteLine("Employee not found.");



