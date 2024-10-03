using Tyuiu.KukarskiySA.Sprint3.Task5.V19.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #5                                                           *");
Console.WriteLine("* Вариант #19                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Отсутствует                                                          *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Формула                                                              *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int x = 2;
double result = dataService.GetSumSumSeries(x, 1, 1, 3, 6);

Console.WriteLine($"Результат суммы: {result}");
Console.WriteLine("************************************************************************");
Console.ReadLine();