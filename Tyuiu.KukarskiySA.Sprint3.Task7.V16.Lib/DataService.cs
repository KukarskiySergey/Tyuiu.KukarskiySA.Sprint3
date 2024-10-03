using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KukarskiySA.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] results = new double[size];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                if (x - 0.4 == 0)  // Проверка деления на ноль
                {
                    result = 0;
                }
                else
                {
                    result = (Math.Cos(x) / (x - 0.4)) + (Math.Sin(x) * 8 * x) + 2;
                }

                results[index] = Math.Round(result, 2);  // Округление до двух знаков
                index++;
            }

            return results;
        }
    }
}
