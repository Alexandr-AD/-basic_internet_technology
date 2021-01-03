using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Rectangle : Figure//, IPrint
    {
        /// <summary>
        /// Высота
        /// </summary>
        public double height { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public double width { get; set; }

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Rectangle(double ph, double pw)
        {
            height = ph;
            width = pw;
            this.Type = "Прямоугольник";
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = width * height;
            return Result;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
