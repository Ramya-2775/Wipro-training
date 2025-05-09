using System;

namespace ConsoleApp1
{
class program
{
    static void Main()
    {
            Employee emp1 = new Employee(1, "ramya", "HR", 30000);


            emp1.printdetails();
            emp1.updatesalary(40000);
            Console.WriteLine("Annual salary:" + emp1.annualsalary());
    }
}
}