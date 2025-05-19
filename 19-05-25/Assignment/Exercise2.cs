using System;
class Employee
{
    public int EmployeeID;
    public string Name;
    public decimal Salary;
}

class Program
{
    static void Main()
    {
       //Employee list
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee { EmployeeID = 1, Name = "Ramya", Salary = 100000 });
        employees.Add(new Employee { EmployeeID = 2, Name = "Sowmya", Salary = 80000 });
        employees.Add(new Employee { EmployeeID = 3, Name = "Vara", Salary = 78000 });
        employees.Add(new Employee { EmployeeID = 4, Name = "Baby", Salary = 89000 });
        employees.Add(new Employee { EmployeeID = 5, Name = "Reddy", Salary = 90000 });

        // highest salary
        Employee highestSalaryEmp = employees[0];
        foreach (var emp in employees)
        {
            if (emp.Salary > highestSalaryEmp.Salary)
            {
                highestSalaryEmp = emp;
            }
        }
        Console.WriteLine($"Employee with highest salary: {highestSalaryEmp.Name}, {highestSalaryEmp.Salary}");

        // Dictionary
        Dictionary<int, string> empDictionary = new Dictionary<int, string>();
        foreach (var emp in employees)
        {
            empDictionary.Add(emp.EmployeeID, emp.Name);
        }

        //dictionary contents
        Console.WriteLine("\nEmployee Dictionary (ID -> Name):");
        foreach (var pair in empDictionary)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
        }

        // Search for an employee by ID
        int searchID = 3; 
        if (empDictionary.ContainsKey(searchID))
        {
            Console.WriteLine($"\nEmployee found: {empDictionary[searchID]}");
        }
        else
        {
            Console.WriteLine($"\nEmployee with ID {searchID} not found.");
        }
    }
}
