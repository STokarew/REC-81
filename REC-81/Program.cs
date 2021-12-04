using System;

namespace REC_81
{
    class Program
    {
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static int Max(int x, int y)
        {
            return x > y ? x : y;
        }
        static int GreatestCommonDivisor(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                var min = Min(a, b);
                var max = Max(a, b);
                return GreatestCommonDivisor(max - min, min);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int FirstNum = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int LastNum = int.Parse(Console.ReadLine());
            Console.Write($"Наибольший общий делитель: {GreatestCommonDivisor(FirstNum,LastNum)}");
        }
    }
}
