using System;
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
            double pricePerUnit;
            if (quantity >= 100)
            {
                pricePerUnit = 1.5;
            }
            else if (quantity >= 50)
            {
                pricePerUnit = 1.75;
            }
            else
            {
                pricePerUnit = 2;
            }
            return quantity * pricePerUnit;

        }

        static void Main(string[] args)
        {
            bool decision = true;
            while (decision == true)
            {
                Console.WriteLine("Welcome to the cat food store!");
                string entry = Ask("How many cans are you ordering?");
                int number = int.Parse(entry);
                double total = Price(number);
                Console.WriteLine($"For {number} cans, yout total is: ${total}");
                Console.Write("Do you want to buy more cans? y/n ");
                string answer = Console.ReadLine();
                answer.ToLower();
                if (answer == "y" || answer == "yes")
                {
                    decision = true;
                }
                else
                {
                    decision = false;
                }
            }
            
            
        }
    }
}
