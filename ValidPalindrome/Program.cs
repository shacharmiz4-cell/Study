//dotnet new console -n ProblemName
//dotnet sln add ProblemName\ProblemName.csproj
//dotnet run --project ProblemName

using System;
using System.Collections.Generic;

public class Solution
{
    public static bool IsPalindrome(string s)
    {
        // string NewString = "";
        // for (int i = 0; i < s.Length; i++)
        // {
        //     if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= '0' && s[i] <= '9'))
        //     {
        //         if (s[i] >= 'A' && s[i] <= 'Z')
        //         {
        //             NewString += char.ToLower(s[i]);
        //         }
        //         else
        //         {
        //             NewString += s[i];
        //         }
        //     }
        // }
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                 left++;
                continue;        
            }
            if (!char.IsLetterOrDigit(s[right]))
            {
                 right--;
                continue;        
            }
            
            if(char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            
            left++;
            right--;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        string input = "race e car";
        bool result = IsPalindrome(input);
        Console.WriteLine(result);
    }
}