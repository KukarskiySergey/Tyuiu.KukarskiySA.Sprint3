using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KukarskiySA.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisorsCount = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                int divisorsCount = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisorsCount++;
                    }
                }

                totalDivisorsCount += divisorsCount;
            }

            return totalDivisorsCount;
        }
    }
}
