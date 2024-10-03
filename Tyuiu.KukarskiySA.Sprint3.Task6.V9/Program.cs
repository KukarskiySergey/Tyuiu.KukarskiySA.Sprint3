using Tyuiu.KukarskiySA.Sprint3.Task6.V9.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #9                                                           *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих    *");
Console.WriteLine("* числовому отрезку [19, 30] количество всех делителей                 *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Числовой отрезок [19, 30]                                            *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int startValue = 19, stopValue = 30;
int totalDivisorsCount = dataService.GetSumTheDivisors(startValue, stopValue);
Console.WriteLine($"Общее количество делителей для чисел в диапазоне [{startValue}, {stopValue}]: {totalDivisorsCount}");
Console.WriteLine("************************************************************************");
Console.ReadLine();