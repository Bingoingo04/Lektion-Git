﻿namespace Lektion_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this super awesome game!");
            Console.WriteLine("Chose a nickname: ");
            string userNick = Console.ReadLine();
            Console.WriteLine($"Greetings, oh exalted {userNick}");
        }
    }
}
