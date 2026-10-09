using Howest.AiDriven.Ex01.Models;

Animal animal1 = new Animal("Generic", 5);
animal1.MakeSound();
Console.WriteLine($"Animal -> Name: {animal1.Name}, Age: {animal1.Age}");

Dog dog1 = new Dog("Rex", 3, "Labrador");
dog1.MakeSound();
Console.WriteLine($"Dog -> Name: {dog1.Name}, Age: {dog1.Age}, Breed: {dog1.Breed}");

Cat cat1 = new Cat("Whiskers", 3, "black");
cat1.MakeSound();
cat1.Describe();
