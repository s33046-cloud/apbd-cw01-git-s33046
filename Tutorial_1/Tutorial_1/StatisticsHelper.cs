using System.Linq;

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
    }
}