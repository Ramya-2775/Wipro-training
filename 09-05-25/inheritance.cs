using System;

class Animal
{
    public string Name;
    public string species;

    //method to display details
    public void DisplayAnimal()
    {
        Console.WriteLine($"Animal name : {Name}");
        Console.WriteLine($"species:{species}");
    }
}
//child class
class dog : Animal
{
    public string breed;
    //method to dog details
    public void displaydog()
    {
        Console.WriteLine($"breed:{breed}");
    }
}
class program
{
    static void Main()
    {
        //creating an object of dog class
        dog mydog = new dog();
        mydog.Name = "Happy";
        mydog.species = "canine";
        mydog.breed = "shizu";

        //disply details
        mydog.DisplayAnimal();

        //display specific details
        mydog.displaydog();
    }
}