using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = { 2.5, 1.8, 3.2, 4.6, 2.1 }; // Замените значения на свои

        double difference = CalculateDifference(numbers);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }

    static double CalculateDifference(double[] array)
    {
        double max = array[0];
        double min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return max - min;
    }
}