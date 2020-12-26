using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class program
    {
        static void Main()
        {
            double rh, rw, ss, cr;
            Console.WriteLine("Введите высоту прямоугольника : ");
            rh = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника : ");
            rw = Double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(rh, rw);
            rect.Print();

            Console.WriteLine("Введите сторону квадрата : ");
            ss = Double.Parse(Console.ReadLine());
            Square sq = new Square(ss);
            sq.Print();

            Console.WriteLine("Введите радиус окружности : ");
            cr = Double.Parse(Console.ReadLine());
            Circle cir = new Circle(cr);
            cir.Print();


            Console.ReadLine();
        }
    }
}

