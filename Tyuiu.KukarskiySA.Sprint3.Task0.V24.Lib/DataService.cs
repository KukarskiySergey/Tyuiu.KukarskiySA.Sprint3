using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KukarskiySA.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;

            // Цикл для вычисления произведения от startValue до stopValue
            for (int i = startValue; i <= stopValue; i++)
            {
                double term = Math.Pow(3.0 / (i + Math.Pow(value, -i)), 2);
                product *= term;
            }

            return Math.Round(product,3);
        }
    }
}
