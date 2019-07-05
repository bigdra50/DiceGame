using System;
using System.Collections.Generic;

namespace DiceGame
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            
            var seed = new Random((int)DateTime.Now.Ticks);
            Console.WriteLine("Rolling the dice...");

            var dice1 = seed.Next(2, 7);
            var dice2 = seed.Next(2, 7);
            var total = dice1 + dice2;

            Console.WriteLine($"Die 1: {dice1}");
            Console.WriteLine($"Die 2: {dice2}");
            
            
            Console.WriteLine($"Total value: {total}");
            Console.WriteLine(total > 7 ? $"{name} won": $"{name} lost");
        }
    }
}