using System.Linq;
using System;
namespace Tutorial_1
{
    public static class StatisticsHelper
    {
        public static int Sum(int[] values)
        {
            int sum = 0;
            foreach (var v in values)
            {
                sum += v;
            }
            return sum;
        }

        public static double CalculateAverage(int[] values)
        {
            return values.Average();
        }
        public static int CalculateMax(int[] values)
        {
            return values.Max();
        }
        public static int CalculateMin(int[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Values cannot be empty");

            int minValue = values.Min();
            return minValue;
        }
    }
}