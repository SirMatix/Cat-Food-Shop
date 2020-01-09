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

        static double Price(int quantity)
        {
            if (quantity < 50)
            {
                return quantity * 2;
            }
            else if (quantity >= 50 && quantity < 100)
            {
                return quantity * 1.75;
            }
            else
            {
                return quantity * 1.5;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the cat food store!");
            string entry = Ask("How many cans are you ordering?");
            int number = int.Parse(entry);
            double total = Price(number);
            Console.WriteLine($"For {number} cans, yout total is: ${total}");
            Console.Write("Press enter to close...");
            Console.ReadLine();
            
        }
    }
}
