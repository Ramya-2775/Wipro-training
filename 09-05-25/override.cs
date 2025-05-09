using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");


    }
}
class manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is suspervising");
    }
}
class program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Work();

        manager manager = new manager();
        manager.Work();

        Employee polyemp = new manager();
        polyemp.Work();

    }
}