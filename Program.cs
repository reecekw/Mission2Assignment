//Reece Williams Section 2
using Mission2Assignment;

// Welcome the user and ask for the number of rolls
Console.WriteLine("Welcome to the dice throwing simulator!");
Console.Write("How many dice rolls would you like to simulate? ");

// Read user input
if (int.TryParse(Console.ReadLine(), out int numRolls) &&  numRolls >= 1)
{
    // Start the second class
    RollGenerator rg = new RollGenerator();
    
    // Pass the number of rolls
    int[] rollResults = rg.SimulateRolls(numRolls);

    Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
    Console.WriteLine("Each * represents 1% of the total number of rolls.");
    Console.WriteLine($"Total number of rolls = {numRolls}.\n");

    // Loop through the results for totals 2 through 12
    for (int i = 2; i <= 12; i++)
    {
        // Calculate percentage of total rolls
        double percentage = ((double)rollResults[i] / numRolls) * 100;
        
        // Round to the nearest whole number for the histogram
        int asteriskCount = (int)Math.Round(percentage);

        Console.Write($"{i}: ");
        Console.WriteLine(new string('*', asteriskCount));
    }

    Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
}
else
{
    Console.WriteLine("Please enter a valid number.");
}