using System;

namespace StuckInATimeLoop
{
    // Creates the class
    class Solution
    {
        static void Main(string[] args)
        {
            // Saves user input into integer
            int num = int.Parse(Console.ReadLine());

            // Creating for loop that stars at 1 and ends where the input is
            for (int x = 1; x <= num && x <= 100; x++)
            {
                // Asked sentence is created for every loop
                Console.WriteLine(x + " " + "Abracadabra");
            }
        }
    }
}
