using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public double RatePerDay { get; set; }

    public virtual double CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}

class Car : Vehicle
{
    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days) + 200; // Car surcharge
    }
}

class Bike : Vehicle
{
    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days) + 50; // Bike surcharge
    }
}

class Truck : Vehicle
{
    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days) + 500; // Truck surcharge
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Car car = new Car();
        car.VehicleNumber = "CAR101";
        car.Brand = "Toyota";
        car.RatePerDay = 1000;

        Bike bike = new Bike();
        bike.VehicleNumber = "BIKE202";
        bike.Brand = "Yamaha";
        bike.RatePerDay = 300;

        Truck truck = new Truck();
        truck.VehicleNumber = "TRUCK303";
        truck.Brand = "Volvo";
        truck.RatePerDay = 2000;

        vehicles.Add(car);
        vehicles.Add(bike);
        vehicles.Add(truck);

        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine("Vehicle: " + v.Brand);
            Console.WriteLine("Rent for 3 days: " + v.CalculateRent(3));
            Console.WriteLine();
        }
    }
}