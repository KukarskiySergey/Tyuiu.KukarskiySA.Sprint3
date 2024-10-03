using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KukarskiySA.Sprint3.Task2.V16.Lib
{
    public class DataService : ISprint3Task2V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;

            do
            {
                // Вычисляем выражение (1 / k^n)^(-1) = k^n
                double term = Math.Pow(k, value);
                product *= term;
                k++;
            }
            while (k <= stopValue);

            return product;
        }
    }
}
