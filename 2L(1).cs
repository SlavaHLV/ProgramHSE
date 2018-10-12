using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0;
            int s = 0;
            Console.Write(" количество цифр в последовательности: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                Console.Write(" введите число: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                {
                    s += x;
                }
            }
            Console.Write(" сумма:{0} ", s);
        }
    }
    }

