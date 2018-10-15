using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество чисел в последовательности:");
            n = Convert.ToInt32(Console.ReadLine());
            int f = 0, sum = 0;
            for (int i = 1; i < n; i++)
            {
            f++;
            if (f % 3==0) { sum = sum - i;} else { sum = sum + i; }
            }
            Console.Write("Ответ:{0}", sum);
        }
    }
}

