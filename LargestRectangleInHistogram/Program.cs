using System;
using System.Collections.Generic;

//dotnet new console -n ProblemName
//dotnet sln add ProblemName\ProblemName.csproj
//dotnet run --project ProblemName
public class Solution
{
    public static int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        int n = heights.Length;
        for (int i = 0; i <= n; i++)
        {
            int h;
            if (i == n)
            {
                h = 0;
            }
            else
            {
                h = heights[i];
            }
            while (stack.Count > 0 && h < heights[stack.Peek()])
            {
                int height = heights[stack.Pop()];
                int width;
                if (stack.Count == 0) {
                  width = i;
                } else {
                  width = i - stack.Peek() - 1;  
                }  
                int area = height * width;
                if (area > maxArea)
                    maxArea = area;
            }
            stack.Push(i);
        }
        return maxArea;
    }
    public static void Main(string[] args)
    {
        int[] heights = { 2, 1, 5, 6, 2, 3 };
        int result = LargestRectangleArea(heights);
        Console.WriteLine(result); // Output: 10
    }
}