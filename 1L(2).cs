using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool b;
            Console.Write("Введите x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            y = double.Parse(Console.ReadLine());
            b = (((Math.Abs(x)) + (Math.Abs(y))) <= 2);
            Console.WriteLine(b);
        }
    }
}
