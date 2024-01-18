using System;
using System.Threading;
namespace Mission2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Thread.Sleep(1000);
            Console.WriteLine("How many dice rolls would you like to simulate?");
            Console.Write("Enter number of rolls: ");
            int numberOfRolls = int.Parse(Console.ReadLine());

            RollDice rollDice = new RollDice();

            int[] results = rollDice.SimulateDiceRolls(numberOfRolls);

            Console.WriteLine("\nResults:");

            for (int i = 0; i < results.Length; i++)
            {
                double percentage = (double)results[i] / numberOfRolls * 100;

                Console.Write((i + 2) + ": ");

                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine($"  ({percentage:F0}%)");
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
