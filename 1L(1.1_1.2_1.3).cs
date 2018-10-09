using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1

{
    class Program
    {
        static void Main()
        {
            float a ,n, m = 0;
            bool b, c = false;
            Console.Write("Введите n: ");
            n = float.Parse(Console.ReadLine());
            Console.Write("Введите m: ");
            m = float.Parse(Console.ReadLine());
            a = m- -n;
            Console.WriteLine("m--n={0}, m={1},n={2}", a, m, n);
            b = m++>n;
            Console.WriteLine("m++>n={0}, m={1},n={2}", b, m, n);
            c = n++>m;
            Console.WriteLine("n++>m={0}, m={1},n={2}", c, m, n);




        }
      
    }
}
