﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFoodShop
{
    class Program
    {
        static string Ask(string message)
        {
            Console.Write(message + " ");
            return Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the cat food store!");
            string entry = Ask("How many cans are you ordering?");
            Console.Write($"You entered {entry} cans");
            int number = int.Parse(entry);
            Console.WriteLine($"For {entry} cans, yout total is: ${number * 2}");
            Console.Write("Press any key to close...");
            Console.ReadLine();
            
        }
    }
}
