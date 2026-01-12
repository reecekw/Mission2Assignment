//Reece Williams Section 2
using System;

namespace Mission2Assignment
{
    public class RollGenerator
    {
        public int[] SimulateRolls(int numberOfRolls)
        {
            // Store counts for the totals in Array
            int[] results = new int[13];
            Random random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                // Roll two separate 6-sided dice
                int d1 = random.Next(1, 7); 
                int d2 = random.Next(1, 7);
                int total = d1 + d2;

                // Increment the count for that combination
                results[total]++;
            }

            // Return the array back to Program.cs
            return results;
        }
    }
}