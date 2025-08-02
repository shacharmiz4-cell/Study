//dotnet new console -n ProblemName
//dotnet sln add ProblemName\ProblemName.csproj
//dotnet run --project ProblemName

using System;
using System.Collections.Generic;

public class Solution
{
    public static int[] TwoSum(int[] numbers, int target)
    {
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        int complement = target - numbers[i];
        if (map.ContainsKey(complement))
        {
            return new int[] { map[complement], i };
        }

        // Store the index of the current number
        if (!map.ContainsKey(numbers[i]))
        {
            map[numbers[i]] = i;
        }
    }

    return new int[] { -1, -1 }; // No solution found
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 0,0,3,4};
        int target = 0;
        int[] result = TwoSum(numbers, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]"); // Output: [0, 1]
    }
}
