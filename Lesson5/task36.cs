using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateRandomNumbers(10); // Замените 10 на желаемый размер массива
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbers);

        int sum = CalculateOddPositionSum(numbers);
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }

    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100); // Генерируем случайное число
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

    static int CalculateOddPositionSum(int[] array)
    {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        return sum;
    }
}