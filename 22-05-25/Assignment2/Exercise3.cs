using System;
using System.Collections.Generic;

interface IAttendance
{
    void MarkAttendance();
}

abstract class Staff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public abstract double CalculateSalary();
}

class PermanentStaff : Staff, IAttendance
{
    public override double CalculateSalary()
    {
        // Fixed salary for example
        return 50000;
    }

    public void MarkAttendance()
    {
        Console.WriteLine(Name + " (Permanent Staff) marked present.");
    }
}

class ContractStaff : Staff, IAttendance
{
    public override double CalculateSalary()
    {
        // Fixed salary for example
        return 25000;
    }

    public void MarkAttendance()
    {
        Console.WriteLine(Name + " (Contract Staff) marked present.");
    }
}

class Program
{
    static void Main()
    {
        List<Staff> staffList = new List<Staff>();

        PermanentStaff pStaff = new PermanentStaff();
        pStaff.Id = 1;
        pStaff.Name = "Ramya";
        pStaff.Department = "HR";

        ContractStaff cStaff = new ContractStaff();
        cStaff.Id = 2;
        cStaff.Name = "Reddy";
        cStaff.Department = "IT";

        staffList.Add(pStaff);
        staffList.Add(cStaff);

        foreach (Staff staff in staffList)
        {
            Console.WriteLine("Name: " + staff.Name);
            Console.WriteLine("Salary: " + staff.CalculateSalary());

            IAttendance attendance = (IAttendance)staff;
            attendance.MarkAttendance();

            Console.WriteLine();
        }
    }
}
