// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    //dotnet new console -n ProblemName
    //dotnet sln add ProblemName\ProblemName.csproj
    //dotnet run --project ProblemName
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4 };
        bool result = ContainsDuplicate(nums);
        Console.WriteLine(result); // Output: True
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seenNumbers = new HashSet<int>();
        foreach (int num in nums)
        {
            if (seenNumbers.Contains(num))
            {
                return true;
            }
            seenNumbers.Add(num);
        }
        return false;
    }
}
