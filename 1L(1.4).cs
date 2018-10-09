using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y = 0;
            Console.Write("Введите x: ");
            x = double.Parse(Console.ReadLine());
            y = Math.Pow(x, 4) - Math.Cos(Math.Asin(x));
            Console.Write(y);
        }
    }
}
