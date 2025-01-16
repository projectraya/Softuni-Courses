using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());  
        int[] result = new int[n];  // Array to store the current combination
        SimulateLoop(result, 0, n);  // Start the recursion
    }

    // Recursive function to simulate nested loops
    static void SimulateLoop(int[] result, int currentLevel, int n)
    {
        if (currentLevel == n)  // Base case: we've reached the last "loop"
        {
            Console.WriteLine(string.Join(" ", result));  // Print the current combination
            return;
        }

        // Simulate one level of a loop
        for (int i = 1; i <= n; i++)
        {
            result[currentLevel] = i;  // Set the current "iteration variable"
            SimulateLoop(result, currentLevel + 1, n);  // Recur for the next level
        }
    }
}
