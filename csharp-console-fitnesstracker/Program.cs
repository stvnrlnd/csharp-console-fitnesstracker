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
            int runningTotal = 0;
            
            // TODO: Prompt user for minutes exercised
            System.Console.WriteLine("How many minutes did you exercise?");
            string userInput = System.Console.ReadLine();
            int minutes = int.Parse(userInput);

            // TODO: Add minutes exercised to running total
            runningTotal = runningTotal + minutes;

            // TODO: Display total minutes exercised on the screen
            System.Console.WriteLine("You've exercised for " + runningTotal + " minutes.");

            // TODO: Repeat until the user quits
        }
    }
}
