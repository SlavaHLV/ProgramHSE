using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b , c = 0;
            Console.Write("Введите a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = double.Parse(Console.ReadLine());
            c = ((a + b) * (a + b) * (a + b) - ((a * a * a) + (3 * (a * a) * b))) / (3 * a * (b * b) + (b * b));
            Console.Write(c);
        }
    }
}
