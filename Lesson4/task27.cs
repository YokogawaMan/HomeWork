using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = GetDigitSum(number);

        Console.WriteLine("Сумма цифр числа: " + sum);
    }

    static int GetDigitSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10; // Получаем последнюю цифру числа
            sum += digit; // Добавляем цифру к сумме
            number /= 10; // Удаляем последнюю цифру числа
        }

        return sum;
    }
}