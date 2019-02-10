using DIamondTDD.Library;
using System;

namespace DiamondTDD.ConsoleUI
{
    class DiamondUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose the mid Letter for your Diamond: \n");
            char letter = Console.ReadLine().ToCharArray()[0];

            Console.WriteLine("\n");

            Console.Write($"{Diamond.Create(letter)}");
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
