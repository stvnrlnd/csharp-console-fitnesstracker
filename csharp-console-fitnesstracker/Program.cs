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
            bool keepGoing = true;

            // ------ Repeat until the user quits
            while (keepGoing)
            {
                // ------ Prompt user for minutes exercised
                System.Console.WriteLine("How many minutes did you exercise? Type \"quit\" to exit...");
                string userInput = System.Console.ReadLine();
                if (userInput == "quit")
                {
                    keepGoing = false;
                } else
                {
                    int minutes = int.Parse(userInput);

                    // ------ Add minutes exercised to running total
                    runningTotal = runningTotal + minutes;

                    // ------ Display total minutes exercised on the screen
                    System.Console.WriteLine("You've exercised for " + runningTotal + " minutes.");
                }
            }
            System.Console.WriteLine("Goodbye");
        }
    }
}
