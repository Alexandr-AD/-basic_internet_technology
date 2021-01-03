using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Figure : IComparable
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public abstract double Area();

        /// <summary>
        /// Приведение к строке, переопределение метода Object
        /// </summary>
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        public int CompareTo(object obj)
        { 
            //Приведение параметра к типу "фигура" 
            Figure p = (Figure) obj; //Сравнение
            if (this.Area() < p.Area()) return -1; 
            else if (this.Area() == p.Area()) return 0;
            else return 1; //(this.Area() > p.Area()) 
        }
        //public void Sort()
        //{

        //}
    }
}
