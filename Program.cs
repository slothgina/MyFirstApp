using System;
using System.ComponentModel.Design.Serialization;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my first app!!!");
            Console.WriteLine("What do you think about my first app?");

            string response = Console.ReadLine();

            Console.WriteLine("Thanks for your feedback: " + response); 

            Console.WriteLine("\nPress any Key to exit...");
            Console.ReadKey();
        }

    }
}
