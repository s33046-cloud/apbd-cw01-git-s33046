using System;
using System.Linq;
using Tutorial_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter numbers:");

        string input = Console.ReadLine();

        int[] numbers = input.Split(',')
            .Select(int.Parse)
            .ToArray();

        int sum = StatisticsHelper.Sum(numbers);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Enter numbers now (main)");
    }
}