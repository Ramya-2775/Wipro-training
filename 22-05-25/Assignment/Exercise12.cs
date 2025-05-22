using System;
using System.Collections.Generic;
using System.Linq;

List<string> names = new() { "Ali", "Eshwar", "Ishita", "Ramya", "Uma", "Sowmya", "Ashok" };

var vowels = new[] { 'A', 'E', 'I', 'O', 'U' };
var vowelNames = names.Where(n => vowels.Contains(char.ToUpper(n[0])));

Console.WriteLine("Names starting with a vowel:");
foreach (var name in vowelNames)
    Console.WriteLine(name);
