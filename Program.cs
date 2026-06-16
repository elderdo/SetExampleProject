using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Defining the two sets from your math example
        List<int> setA = new List<int> { 1, 2, 3, 4 };
        List<int> setB = new List<int> { 4, 2, 4, 3, 1, 3 };

        // Check if they contain the exact same unique elements
        bool areTheyEqual = SetComparer.AreSetsEquivalent(setA, setB);

        // This prints "True" because, mathematically and programmatically, they are the same set!
        Console.WriteLine($"Are the sets the same? {areTheyEqual}");
    }
}
