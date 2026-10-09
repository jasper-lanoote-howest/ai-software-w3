using Howest.AiDriven.Ex02.Models;

List<LibraryItem> catalogue = new List<LibraryItem>
{
    new Book(1, "The Hobbit", 1937, "J.R.R. Tolkien"),
    new Magazine(2, "National Geographic", 2024, 245),
    new DVD(3, "Inception", 2010, 148)
};

foreach (LibraryItem item in catalogue)
{
    item.PrintDetails();
    Console.WriteLine();
}
