using System;
using System.Linq;
public class employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    class program
    {
        static void Main(string[] args)
        {
            employee[] employeearray =
            {
            new employee { Id = 1, Name = "ramya", Age = 10 },
            new employee { Id = 2, Name = "sowmya", Age = 15 },
            new employee { Id = 3, Name = "reddy", Age = 29},
            new employee { Id = 4, Name = "vara", Age = 11 },
            new employee { Id = 5, Name = "prasad", Age = 16 },
            new employee { Id = 6, Name = "anil", Age = 19 },

        };
         

            //use linq id to find teenagers
            employee[] teenageremployees = employeearray.Where(s => s.Age > 12 && s.Age < 19).ToArray();
            

            //use linq to find first employee whose name is reddy
            employee redddy= employeearray.Where( s => s.Name == "reddy").FirstOrDefault();

            //use linq to find employee id
            employee employee4 = employeearray.Where(s => s.Id == 4).FirstOrDefault();

        }
    }
}
