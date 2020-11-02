using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()//string[] args)
        {
       //system.console.setlocale(LC_ALL, "Russian");
        //double a = 0, b = 0, c = 0, d = 0;
        double a, b, c, d;

            System.Console.WriteLine("Введите чилсло a",'\n');//endl);
            a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введите чилсло b", '\n');
            b = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введите чилсло c" ,'\n');
            c = Convert.ToDouble(System.Console.ReadLine());

            if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                   System.Console.Write("Уравнение имеет бесконечное количество решений" ,'\n');
                else
                   System.Console.Write("Решений нет",'\n');

            }
            else
               System.Console.Write("x = ", -c / b,'\n');
        }
        else
        {

            d = b * b - 4 * a * c;
            if (d < 0)
               System.Console.Write($"Решений нет {'\n'}");
            else
                if (d == 0)
            {

                System.Console.Write($"x = {-b / a} {'\n'}");
            }
            else
            {
                d = Math.Sqrt(d);
                a *= 2;
                    System.Console.WriteLine($"x1 = {(-b + d) / a}");
                    System.Console.WriteLine($"x2 = {(-b - d) / a} { '\n'}");
            }


        }
            Console.ReadLine();
        //System("pause");

       //return 0;
    }
}
}

