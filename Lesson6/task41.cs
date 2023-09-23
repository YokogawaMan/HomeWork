using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел (N):");
        int N = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, больших нуля: " + count);
    }
}