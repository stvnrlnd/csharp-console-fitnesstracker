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
            double runningTotal = 0;
            bool keepGoing = true;

            // ------ Repeat until the user quits
            while (keepGoing)
            {
                // ------ Prompt user for minutes exercised
                System.Console.WriteLine("How many minutes did you exercise? Type \"quit\" to exit...");
                string userInput = System.Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        double minutes = double.Parse(userInput);

                        // ------ Give some feedback to the user based on the number of minutes entered
                        if (minutes <= 0)
                        {
                            System.Console.WriteLine("Well what are you waiting for? Let's get in shape!");
                            continue;
                        }
                        else if (minutes <= 10)
                        {
                            System.Console.WriteLine("Don't stop now, you've got this!");
                        }
                        else if (minutes <= 30)
                        {
                            System.Console.WriteLine("Awesome job!");
                        }
                        else if (minutes <= 60)
                        {
                            System.Console.WriteLine("Whoa! That's amazing!");
                        }
                        else
                        {
                            System.Console.WriteLine("Very impressive!");
                        }

                        // ------ Add minutes exercised to running total
                        runningTotal = runningTotal + minutes;

                        // ------ Display total minutes exercised on the screen
                        System.Console.WriteLine("You've exercised for " + runningTotal + " minutes.");
                    }
                    catch (FormatException)
                    {
                        System.Console.WriteLine("Invalid input.");
                        continue;
                    }
                }
            }
            System.Console.WriteLine("Goodbye");
        }
    }
}
