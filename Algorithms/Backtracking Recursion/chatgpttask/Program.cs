using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define the input set
        List<int> set = new List<int> { 1, 2, 3 };

        // Call the recursive function to generate the power set
        List<List<int>> result = GeneratePowerSet(set, 0);

        // Print all subsets in the correct format
        Console.WriteLine("Power Set:");
        foreach (var subset in result)
        {
            if (subset.Count == 0)
            {
                Console.WriteLine("{}");
            }
            else
            {
                Console.Write("{");
                for (int i = 0; i < subset.Count; i++)
                {
                    Console.Write(subset[i]);
                    if (i < subset.Count - 1)
                    {
                        Console.Write(", ");  // Add comma and space between elements
                    }
                }
                Console.WriteLine("}");
            }
        }
    }

    // Recursive function to generate power set
    static List<List<int>> GeneratePowerSet(List<int> set, int index)
    {
        // Base case: If we've processed all elements, return the empty set
        if (index == set.Count)
        {
            List<List<int>> emptySet = new List<List<int>>();
            emptySet.Add(new List<int>());  // Add the empty set
            return emptySet;
        }

        // Recursive case: Get all subsets from the remaining elements
        List<List<int>> allSubsets = GeneratePowerSet(set, index + 1);

        // Create new subsets by adding the current element to each existing subset
        int currentElement = set[index];
        List<List<int>> moreSubsets = new List<List<int>>();

        foreach (var subset in allSubsets)
        {
            // Clone the current subset
            List<int> newSubset = new List<int>(subset);
            // Add the current element to main  tain the correct order
            newSubset.Add(currentElement);
            // Add the new subset to the list of more subsets
            moreSubsets.Add(newSubset);
        }

        // Combine the subsets without the current element and with the current element
        allSubsets.AddRange(moreSubsets);

        return allSubsets;
    }
}
