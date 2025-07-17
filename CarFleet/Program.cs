// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int target = 12;
        int[] position = { 10, 8, 0, 5, 3 };
        int[] speed = { 2, 4, 1, 1, 3 };
        Console.WriteLine(CarFleet(target, position, speed));
    }

    public static int CarFleet(int target, int[] position, int[] speed)
    {
        Dictionary<int, double> carArrivalTimes = new Dictionary<int, double>();
        for (int i = 0; i < position.Length; i++)
        {
            position[i] = target - position[i]; // Convert to distance from target
            carArrivalTimes[position[i]] = (double)position[i] / speed[i]; // Calculate time to reach target
        }
        Array.Sort(position);
        int fleets = 0;
        Stack<int> stack = new Stack<int>();
        foreach (int pos in position)
        {
            if (stack.Count == 0 || carArrivalTimes[pos] > carArrivalTimes[stack.Peek()])
            {
                stack.Push(pos);
                fleets++;
            }
        }
        return fleets;
    }
}
