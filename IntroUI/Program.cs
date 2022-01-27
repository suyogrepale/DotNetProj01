using System;
using IntroLib;

namespace Program // Note: actual namespace depends on the project name.
{

    ///comment number one
    
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel{
                FirstName="Suyog",
                LastName = "Repale"
            };

            Console.WriteLine($"{p.FirstName} {p.LastName} is my name.");

            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello Suyog!");

            Console.WriteLine("Hello Kaveron India Pvt Ltd!");
        }
    }
}