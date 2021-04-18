using System;
using AnimalShelterConsoleApp.Models;

namespace AnimalShelterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCat = new Cat("Bentley");
            var secondCat = new Cat("Toby");

            var firstDog = new Dog("Manchas");
            var secondDog = new Dog("Max");

            var queue = new AnimalQueue();
            queue.Enqueue(firstCat);
            queue.Enqueue(secondCat);
            queue.Enqueue(firstDog);
            queue.Enqueue(secondDog);

            var animal = queue.DequeueAny();
            Console.WriteLine($"Name: {animal.Name}, Order: {animal.GetOrder()}");
        }
    }
}
