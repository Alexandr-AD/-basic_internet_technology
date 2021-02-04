using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab._6
{

    delegate string MultOrDiv(string s1, float f1, float f2);
    class Program
    {
        static string Multiply (string s, float p1, float p2) { return s + "Умножение : " + (p1 * p2).ToString(); }
        static string Division(string s, float p1, float p2) { return s + "Деление : " + (p1 / p2).ToString(); }
        static void MultOrDivMethod(float f1, float f2, Func<string, float, float, string> MultOrDivParam)
        {
            string Res = MultOrDivParam("Результат ", f1, f2);
            Console.WriteLine(Res);
        }
        static void MultOrDivMethod(string str, float f1, float f2, MultOrDiv MultOrDivParam)
        {
            string Res = MultOrDivParam(str, f1, f2);
            Console.WriteLine(Res);
        }
        static void Main(string[] args)
        {
            float f1 = 100;
            float f2 = 10;

            MultOrDivMethod(f1, f2, Multiply);
            MultOrDivMethod(f1, f2, Division);
            string s1 = "Создание экземпляра делегата на основе лямбда-выражения : ";
            MultOrDivMethod(s1, f1, f2, (s1, x, y) => s1 + (x * y).ToString());
            
            
        }
        
       
    }
}
