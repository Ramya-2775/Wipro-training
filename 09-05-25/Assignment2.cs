using System;

public class Vehicle
{
    public string Make;
    public string Model;

    //method to display details
    public void DisplayVehicle()
    {
        Console.WriteLine($"Make : {Make}");
        Console.WriteLine($"Model:{Model}");
    }
}
//child class
public class Car : Vehicle
{
    public string Fueltype;
    //method to dog details
    public void displayCar()
    {
        Console.WriteLine($"fueltype:{Fueltype}");
    }
}
class program
{
    static void Main()
    {
        //creating an object of dog class
        Car myCar = new Car();
        myCar.Make = "Suzuki";
        myCar.Model = "Brezza";
        myCar.Fueltype = "Petrol";

        //disply details
        myCar.DisplayVehicle();

        //display specific details
        myCar.displayCar();
    }
}