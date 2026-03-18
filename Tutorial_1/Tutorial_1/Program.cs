using System;
using System.Linq;
using Tutorial_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers separated by comma:");

        string input = Console.ReadLine();

        int[] numbers = input.Split(',')
            .Select(int.Parse)
            .ToArray();

        int sum = StatisticsHelper.Sum(numbers);

        Console.WriteLine("Sum: " + sum);
    }
}