﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KukarskiySA.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            // Цикл while для вычисления суммы
            while (i <= stopValue)
            {
                // Вычисляем выражение: (2 / (6 + x^i))^i
                double term = Math.Pow(2.0 / (6 + Math.Pow(value, i)), i);
                sum += term;
                i++;
            }

            return Math.Round(sum,3);
        }
    }
}
