using System;
using System.Collections.Generic;

namespace DiceGame
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            var seed = new System.Random((int)DateTime.Now.Ticks);
            System.Console.WriteLine("Rolling the dice...");

            var dice1 = seed.Next(2, 7);
            var dice2 = seed.Next(2, 7);
            var total = dice1 + dice2;

            System.Console.WriteLine($"Die 1: {dice1}");
            System.Console.WriteLine($"Die 2: {dice2}");
            
            
            System.Console.WriteLine($"Total value: {total}");
        }
    }
}