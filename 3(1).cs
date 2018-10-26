using System;

using static System.Math;

namespace selivanov_lab3
{
    static class Program
    {

        // Интервал A <= x <= B
        const double A = 0.1;
        const double B = 1;
        // Предел суммирования ряда
        const int N = 10;

        // Количество шагов
        const int K = 10;
        // Точность суммирования
        const double Epsilon = 0.0001;

        // Шаг в интервале: (b-a)/k
        const double Delta = (B - A) / K;

        // Функция f(x) = sin(x)
        static double F(double x) => Sin(x);

        // n-тый элемент ряда в точке х: ((-1)^n)*(x^(2n+1))/(2n+1)!
        static double A_n(double x, uint n) => Pow(-1, n) * (Pow(x, 2 * n + 1) / Fact(2 * n + 1));

        // Сумма ряда в точке x по n-тый элемент: x - x^3/3! + ... + ((-1)^n)*(x^(2n+1))/(2n+1)!
        static double S_n(double x, uint n)
        {
            double result = 0;
            for (uint i = 0; i <= n; i++)
            {
                result += A_n(x, n: i);
            }

            return result;
        }

        // Сумма ряда в точке x с точностью epsilon - суммирование до тех пор, пока разница полученной суммы и реального значения больше epsilon
        static double S_e(double x, double epsilon)
        {
            double expectedResult = F(x);
            double result = 0;
            uint n = 0;

            while (Abs(result - expectedResult) > epsilon)
            {
                result += A_n(x, n++);
            }

            return result;
        }



        static void Main()
        {
            Console.WriteLine($"{"Вычисление функции",43}");

            // цикл по x в интервале a <= x <= b, с шагом (b-a)/k
            for (double x = A; x <= B; x += Delta)
            {
                Console.WriteLine($"X={x,-4} SN={S_n(x, N),-20:G17} SE={S_e(x, Epsilon),-20:G17} Y={F(x),-20:G17}");
            }

            Console.ReadKey();
        }

        // Факториал: n!
        static uint Fact(uint n)
        {
            uint result = 1;
            for (uint i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
