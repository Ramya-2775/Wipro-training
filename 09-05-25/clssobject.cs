using System;
class student
{
    public int rollnumber;
    public string name;
    public int marks;

    //student details
    public void printdetails()
    {
        Console.WriteLine($"roll number:{rollnumber}");
        Console.WriteLine($"name:{name}");
        Console.WriteLine($"marks:{marks}");
    }

}
class program
{
    static void Main()
    {
        //creating an object odf student
        student student1 = new student();

        //Assigning values
        student1.rollnumber = 607;
        student1.name = "ramya";
        student1.marks = 86;

        //printing details
        student1.printdetails();
    }
}
