using System;
using System.Collections.Generic;
using System.Linq;


var duplicates = nums.GroupBy(n => n)
                     .Where(g => g.Count() > 1)
                     .Select(g => g.Key);

Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));

