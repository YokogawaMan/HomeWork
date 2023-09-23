using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение k1:");
        double k1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение b1:");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение k2:");
        double k2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение b2:");
        double b2 = Convert.ToDouble(Console.ReadLine());

        double x = CalculateIntersectionPointX(k1, b1, k2, b2);
        double y = CalculateIntersectionPointY(k1, b1, x);

        Console.WriteLine("Точка пересечения двух прямых: (" + x + ", " + y + ")");
    }

    static double CalculateIntersectionPointX(double k1, double b1, double k2, double b2)
    {
        return (b2 - b1) / (k1 - k2);
    }

    static double CalculateIntersectionPointY(double k, double b, double x)
    {
        return k * x + b;
    }
}