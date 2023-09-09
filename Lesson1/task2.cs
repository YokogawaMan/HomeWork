Console.WriteLine("Введите первое число:");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberSecond = Convert.ToInt32(Console.ReadLine());

FindMinMax(numberFirst, numberSecond);

Console.ReadLine();

public static void FindMinMax(int first, int second)
{
    if (first > second)
    {
        Console.WriteLine("Первое число больше второго.");
        Console.WriteLine("Первое число: " + first);
        Console.WriteLine("Второе число: " + second);
    }
    else if (first < second)
    {
        Console.WriteLine("Второе число больше первого.");
        Console.WriteLine("Первое число: " + first);
        Console.WriteLine("Второе число: " + second);
    }
    else
    {
        Console.WriteLine("Оба числа равны.");
        Console.WriteLine("Число: " + first);
    }
}