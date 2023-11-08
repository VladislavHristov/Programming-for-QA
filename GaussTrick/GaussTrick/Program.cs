using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

        int first = 0;
        int last = numbers.Count - 1;
        List<int> result = new List<int>();

        while (first <= last)
        {
            if (first == last)
            {
                result.Add(numbers[first]);
            }
            else
            {
                result.Add(numbers[first] + numbers[last]);
            }

            first++;
            last--;
        }


        Console.WriteLine(string.Join(" ", result));
    }
}