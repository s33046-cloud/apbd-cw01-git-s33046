using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers separated by comma:");

        string input = Console.ReadLine();

        Console.WriteLine("You entered: " + input);
        int[] numbers = input.Split(',')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine("Parsed " + numbers.Length + " numbers.");
    }
}