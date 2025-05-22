using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

string sentence = "Hii Hello Good Morning, Good to see you";
var words = sentence.Split(' ');
var frequency = words
    .GroupBy(word => word)
    .Select(group => new { Word = group.Key, Count = group.Count() });

foreach (var item in frequency)
    Console.WriteLine($"{item.Word}: {item.Count}");

