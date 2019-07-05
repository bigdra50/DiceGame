using System;
using System.Collections.Generic;

namespace DiceGame
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            var seed = new System.Random((int)DateTime.Now.Ticks);
            Console.WriteLine("Rolling the dice...");

            var dice1 = seed.Next(2, 7);
            var dice2 = seed.Next(2, 7);
            var total = dice1 + dice2;

            Console.WriteLine($"Die 1: {dice1}");
            Console.WriteLine($"Die 2: {dice2}");
            
            
            Console.WriteLine($"Total value: {total}");
            Console.WriteLine(total > 7 ? "You won": "You lost");
        }
    }
}