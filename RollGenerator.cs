using System;

namespace Mission2Assignment
{
    public class RollGenerator
    {
        public int[] SimulateRolls(int numberOfRolls)
        {
            // Array to store counts for the totals
            int[] results = new int[13];
            Random random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                // Roll two separate 6-sided dice
                int die1 = random.Next(1, 7); 
                int die2 = random.Next(1, 7);
                int total = die1 + die2;

                // Increment the count for that combination
                results[total]++;
            }

            // Return the array back to Program.cs
            return results;
        }
    }
}