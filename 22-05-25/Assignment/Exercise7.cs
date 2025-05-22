using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evens = numbers.Where(n => n % 2 == 0).ToList();
var odds = numbers.Where(n => n % 2 != 0).ToList();

Console.WriteLine("Even Numbers: " + string.Join(", ", evens));
Console.WriteLine("Odd Numbers: " + string.Join(", ", odds));