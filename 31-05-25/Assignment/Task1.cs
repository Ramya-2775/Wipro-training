using System;
using System.Collections.Generic;

interface IRentable
{
    void Rent();
}

class Vehicle : IRentable
{
    public string Model;
    public double RentPerDay;

    public void SetData(string model, double rentPerDay)
    {
        this.Model = model;
        this.RentPerDay = rentPerDay;
    }

    public virtual void Rent()
    {
        Console.WriteLine($"Renting Vehicle: {Model} - ${RentPerDay}/day");
    }
}

class Car : Vehicle
{
    public void SetCarData(string model, double rentPerDay)
    {
        this.Model = model;
        this.RentPerDay = rentPerDay;
    }

    public override void Rent()
    {
        Console.WriteLine($"Renting Car: {Model} - ${RentPerDay}/day");
    }
}

class Bike : Vehicle
{
    public void SetBikeData(string model, double rentPerDay)
    {
        this.Model = model;
        this.RentPerDay = rentPerDay;
    }

    public override void Rent()
    {
        Console.WriteLine($"Renting Bike: {Model} - ${RentPerDay}/day");
    }
}

class Truck : Vehicle
{
    public void SetTruckData(string model, double rentPerDay)
    {
        this.Model = model;
        this.RentPerDay = rentPerDay;
    }

    public override void Rent()
    {
        Console.WriteLine($"Renting Truck: {Model} - ${RentPerDay}/day");
    }
}

/*class Program
{
    static void Main()
    {
        List<Vehicle> rentalList = new List<Vehicle>();

       
        Car car1 = new Car();
        car1.SetCarData("Maruti Swift", 50);
        rentalList.Add(car1);

     
        Bike bike1 = new Bike();
        bike1.SetBikeData("Honda Shine", 20);
        rentalList.Add(bike1);

       
        Truck truck1 = new Truck();
        truck1.SetTruckData("Tata Heavy", 100);
        rentalList.Add(truck1);

        Console.WriteLine("Vehicle Rental Information:");
        foreach (Vehicle v in rentalList)
        {
            v.Rent(); 
        }

        
        Console.Write("\nEnter number of days to rent all vehicles: ");
        int days = Convert.ToInt32(Console.ReadLine());

        double totalCost = 0;
        foreach (Vehicle v in rentalList)
        {
            totalCost += v.RentPerDay * days;
        }

        Console.WriteLine($"\nTotal rent for {days} day(s): ${totalCost}");
    }
}*/
