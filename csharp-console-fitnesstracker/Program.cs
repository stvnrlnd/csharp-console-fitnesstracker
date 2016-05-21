using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_console_fitnesstracker
{
    class Program
    {
        static void Main()
        {
            // TODO: Prompt user for minutes exercised
            System.Console.Write("How many minutes did you exercise?");
            string userInput = System.Console.ReadLine();

            // TODO: Add minutes exercised to running total
            // TODO: Display total minutes exercised on the screen
            System.Console.WriteLine("You've exercised for " + userInput + " minutes.");

            // TODO: Repeat until the user quits
        }
    }
}
