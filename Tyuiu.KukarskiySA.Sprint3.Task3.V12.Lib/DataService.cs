using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KukarskiySA.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int maxCount = 0;
            int currentCount = 0;

            // Проход по каждому символу строки
            foreach (char c in value)
            {
                if (c == item)
                {
                    // Увеличиваем счетчик, если символ совпадает с item ('k')
                    currentCount++;
                }
                else
                {
                    // Обновляем максимальное количество и сбрасываем текущий счетчик
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 0;
                }
            }

            // После завершения цикла обновляем maxCount, если последовательность заканчивается на 'k'
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            return maxCount;
        }
    }
}
