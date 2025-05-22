using System;
abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine("Feeding the " + Name);
    }
}

class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine(Name + " roars.");
    }
}

class Elephant : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine(Name + " trumpets.");
    }
}

class Monkey : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine(Name + " chatters.");
    }
}

class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void ShowAllAnimals()
    {
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Feed();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();

        Lion lion = new Lion();
        lion.Name = "Leo";
        lion.Age = 5;

        Elephant elephant = new Elephant();
        elephant.Name = "Ella";
        elephant.Age = 10;

        Monkey monkey = new Monkey();
        monkey.Name = "Max";
        monkey.Age = 3;

        zoo.AddAnimal(lion);
        zoo.AddAnimal(elephant);
        zoo.AddAnimal(monkey);

        zoo.ShowAllAnimals();
    }
}