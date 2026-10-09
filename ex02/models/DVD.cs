namespace Howest.AiDriven.Ex02.Models;

public class DVD : LibraryItem
{
    public int Duration { get; set; } // in minutes

    public DVD(int id, string title, int yearPublished, int duration) : base(id, title, yearPublished)
    {
        Duration = duration;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Duration: {Duration} min");
    }
}
