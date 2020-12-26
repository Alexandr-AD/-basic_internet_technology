using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Circle : Figure, IPrint
    {
        /// <summary>
        /// Ширина
        /// </summary>
        public double radius { get; set; }

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Circle(double pr)
        {
            radius = pr;
            this.Type = "Круг";
        }

        public override double Area()
        {
            double Result = Math.PI * radius * radius;
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
