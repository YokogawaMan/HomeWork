using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateRandomNumbers(10); // Замените 10 на желаемый размер массива
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbers);

        int evenCount = CountEvenNumbers(numbers);
        Console.WriteLine("Количество четных чисел: " + evenCount);
    }

    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000); // Генерируем случайное трехзначное число
        }

        return numbers;
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0) // Проверяем, является ли число четным
            {
                count++;
            }
        }

        return count;
    }
}