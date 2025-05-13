using System;
using System.Linq;
public class employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
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
        employee[] employees = new employee[10];
        int i = 0;
        foreach(employee employee in employeearray)
        {
            if(employee.Age>12 && employee.Age<20)
            {
                employees[i] = employee;    
                System.Console.WriteLine(employee.Name);
                i++;
            }
        }
}}