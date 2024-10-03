using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KukarskiySA.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                    continue;

                double y = ((Math.Cos(x) + x) / x) + 0.25;
                product *= y;
            }

            return Math.Round(product,3);
        }
    }
}
