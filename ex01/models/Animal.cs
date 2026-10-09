namespace Howest.AiDriven.Ex01.Models;

public class Animal
{
    public string Name {get;set;}
    public int Age {get;set;}

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Unknown sound");
    }

    public virtual void Describe()
    {
        Console.WriteLine($"This is {Name} and it is {Age} years old.");
    }
}