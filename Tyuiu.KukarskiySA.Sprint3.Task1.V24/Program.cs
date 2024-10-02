using Tyuiu.KukarskiySA.Sprint3.Task1.V24.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #24                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет           *");
Console.WriteLine("* сумму ряда по формуле, при X=5                                       *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Формула                                                              *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int x = 5;
int startValue = 1;
int stopValue = 12;

double sumResult = dataService.GetSumSeries(x, startValue, stopValue);

Console.WriteLine($"Сумма ряда: {sumResult}");
Console.WriteLine("************************************************************************");
Console.ReadLine();