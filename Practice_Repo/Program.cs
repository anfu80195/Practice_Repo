using System;

namespace FunProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic Coffee Machine!");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + "!");

            Random random = new Random();
            int magicNumber = random.Next(1, 6);

            Console.WriteLine("Rolling the magic number...");

            if (magicNumber == 5)
            {
                Console.WriteLine("YOU WIN A FREE COFFEE!");
            }
            else
            {
                Console.WriteLine("No coffee today 😭");
            }

            Console.WriteLine("Magic number was: " + magicNumber);
        }
    }
}