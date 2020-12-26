using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Square : Rectangle, IPrint
    {
        public Square(double size)
            : base(size, size)
        {
            this.Type = "Квадрат";
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public new void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
