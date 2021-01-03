using lab3.Матрица;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
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

            //Работа с необобщенным списком
            Console.WriteLine("\nНеобобщенный список:");
            ArrayList al = new ArrayList();
            al.Add(rect);
            al.Add(sq);
            al.Add(cir);

            Console.WriteLine("\nПеред сортировкой");
            foreach (object o in al)
                Console.WriteLine(o);
            Console.WriteLine("\nПосле сортировки");
            al.Sort();
            foreach (object o in al)
                Console.WriteLine(o);

            Console.WriteLine("\nОбобщённый список:");
            List<Figure> L = new List<Figure>();
            L.Add(rect);
            L.Add(sq);
            L.Add(cir);

            Console.WriteLine("\nПеред сортировкой");
            foreach (object o in L)
                Console.WriteLine(o);
            Console.WriteLine("\nПосле сортировки");
            L.Sort();
            foreach (object o in L)
                Console.WriteLine(o);
            
            Matrix<Figure> SparseMatrix = new Matrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            SparseMatrix[0, 0, 0] = rect;
            SparseMatrix[1, 1, 1] = sq;
            SparseMatrix[2, 2, 2] = cir;

            String b = SparseMatrix.ToString();
            Console.WriteLine(b);
            Console.WriteLine("\nСтек");

            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            //добавление данных в стек
            stack.Push(rect);
            stack.Push(sq);
            stack.Push(cir);
            //чтение данных из стека
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }

            

            Console.ReadLine();
        }
    }
}
