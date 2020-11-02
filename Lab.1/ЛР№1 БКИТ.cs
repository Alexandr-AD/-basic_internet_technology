using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()// argc, char [] argv)
        {

            double a, b, c, d;
            System.Console.WriteLine("Выполнил: Алёшин Александр Денисович");
            System.Console.WriteLine("Группа ИУ5-33Б\n");

            System.Console.WriteLine("Введите чилсло a", '\n');//endl);
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка, повторите ввод");
            }

            System.Console.WriteLine("Введите чилсло b", '\n');
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка, повторите ввод");
            }
            System.Console.WriteLine("Введите чилсло c", '\n');
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Ошибка, повторите ввод");
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.Write("Уравнение имеет бесконечное количество решений", '\n');
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.Write("Решений нет", '\n');
                        Console.ResetColor();
                    }

                }
                else
                        if ((-c / b) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.Write("x1 = ", Math.Sqrt(-c / b), '\n');
                    System.Console.Write("x2 = ", -Math.Sqrt(-c / b), '\n');
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write("Решений нет", '\n');
                    Console.ResetColor();
                }
            }
            else
            {

                d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write("Решений нет", '\n');
                    Console.ResetColor();
                }
                else
                    if (d == 0)
                {
                    if ((-b / 2 * a) >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.Write($"x1 = {Math.Sqrt(-b / 2 * a)} {'\n'}");
                        System.Console.Write($"x2 = {-Math.Sqrt(-b / 2 * a)} {'\n'}");
                        Console.ResetColor();
                    }
                    else if ((-b / 2 * a) < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.Write("Решений нет", '\n');
                        Console.ResetColor();
                    }
                }
                else
                {
                    d = Math.Sqrt(d);
                    a *= 2;
                    double t = (-b + d) / a;
                    if (t >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine($"x1 = {Math.Sqrt((-b + d) / a)}");
                        System.Console.WriteLine($"x2 = {-Math.Sqrt((-b + d) / a)}");
                    }
                    t = (-b - d) / a;
                    if (t >= 0)
                    {
                        System.Console.WriteLine($"x3 = {Math.Sqrt((-b - d) / a)}");
                        System.Console.WriteLine($"x4 = {-Math.Sqrt((-b - d) / a)}");
                        Console.ResetColor();
                    }
                    
                }

                Console.ReadLine();
            }
        }
    }
}

