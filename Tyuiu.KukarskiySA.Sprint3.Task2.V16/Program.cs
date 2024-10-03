using Tyuiu.KukarskiySA.Sprint3.Task2.V16.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #16                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет      *");
Console.WriteLine("* произведение ряда по формуле, при n=2                                *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Формула                                                              *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int n = 2;
int startValue = 1;
int stopValue = 5;

double result = dataService.GetMultiplySeries(n, startValue, stopValue);

Console.WriteLine($"Произведение ряда при n={n}, k от {startValue} до {stopValue}: {result}");
Console.WriteLine("************************************************************************");
Console.ReadLine();