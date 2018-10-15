using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
           int num, first, q = 0;
            Console.Write("введите первое число последовательности:");
            first = Convert.ToInt32(Console.ReadLine());
                do
                {
                Console.Write("введите  число последовательности:");
                num = Convert.ToInt32(Console.ReadLine());
                if (first == 0) ;
                else
                {
                    if (num % first == 0)
                        q++;
                }
                }
                while (num != 0);
                Console.Write("Ответ{0}:",q);
        }
        }
    }

