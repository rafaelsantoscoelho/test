﻿namespace Lab3Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Task #1\n");

            // Adding some comments
            // Comment 1
            // Comment 2
            // Comment 3

            Console.WriteLine("BLABLABLABLA");

            Console.WriteLine("BLABLABLABLA2");

            Console.WriteLine("BLABLABLABLA3");

            Console.WriteLine("BLABLABLABLA4");

            Console.WriteLine("BLABLABLABLA5");

            Console.WriteLine("Enter the dog's name:");
            string dogName = Console.ReadLine();

            Console.WriteLine("Enter the dog's color:");
            string dogColor = Console.ReadLine();

            Console.WriteLine("Enter the dog's age:");
            int dogAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Dog dog = new Dog(dogName, dogColor, dogAge);
            Console.WriteLine(dog.ToString());
            dog.Eat();

            Console.WriteLine();

            Console.WriteLine("Enter the cat's name:");
            string catName = Console.ReadLine();

            Console.WriteLine("Enter the cat's color:");
            string catColor = Console.ReadLine();

            Console.WriteLine("Enter the cat's age:");
            int catAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Cat cat = new Cat(catName, catColor, catAge);
            Console.WriteLine(cat.ToString());
            cat.Eat();

            Console.WriteLine("----------------------");
        }
    }
}