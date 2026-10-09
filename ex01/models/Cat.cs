namespace Howest.AiDriven.Ex01.Models;

public class Cat : Animal
{
    public string Color { get; set; }
    public Cat(string name, int age, string color) : base(name, age)
    {
        Color = color;
    }

    public override void Describe()
    {
        Console.WriteLine($"This is {Name}, it is {Age} years old and its color is {Color}.");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}