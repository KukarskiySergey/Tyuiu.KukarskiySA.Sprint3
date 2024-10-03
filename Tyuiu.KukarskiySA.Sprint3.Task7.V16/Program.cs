using Tyuiu.KukarskiySA.Sprint3.Task7.V16.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #16                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции         *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Функция                                                              *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

double[] functionResults = dataService.GetMassFunction(-5, 5);

Console.WriteLine("Таблица значений функции:");
for (int i = -5; i <= 5; i++)
{
    Console.WriteLine($"f({i}) = {functionResults[i + 5]}");
}
Console.WriteLine("************************************************************************");
Console.ReadLine();