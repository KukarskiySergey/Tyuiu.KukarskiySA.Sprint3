using Tyuiu.KukarskiySA.Sprint3.Task4.V16.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #3 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Операторы составного присваивания                              *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #16                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение  *");
Console.WriteLine("* функции y=((cos(x)+x)/x)+0.25                                        *");
Console.WriteLine("* При х = 0 пропустить значение Полученные значения перемножать.       *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* y=((cos(x)+x)/x)+0.25                                                *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

double result = dataService.Calculate(-5, 5);

Console.WriteLine($"Произведение значений функции: {result}");
Console.WriteLine("************************************************************************");
Console.ReadLine();