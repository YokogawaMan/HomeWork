using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число A:");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите число B:");
        int B = Convert.ToInt32(Console.ReadLine());

        double result = Power(A, B);

        Console.WriteLine("Результат возведения числа A в степень B: " + result);
    }

    static double Power(double A, int B)
    {
        double result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        return result;
    }
}