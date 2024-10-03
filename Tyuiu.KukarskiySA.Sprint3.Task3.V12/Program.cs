using Tyuiu.KukarskiySA.Sprint3.Task3.V12.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #12                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв k,    *");
Console.WriteLine("* находящихся на соседних позициях в строке: bkkrk ckkkcs ksr          *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* bkkrk ckkkcs ksr                                                     *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

string value = "bkkrk ckkkcs ksr";
char item = 'k';

int result = dataService.GetMaxCharCount(value, item);

Console.WriteLine($"Максимальное количество символов '{item}', идущих подряд: {result}");
Console.WriteLine("************************************************************************");
Console.ReadLine();