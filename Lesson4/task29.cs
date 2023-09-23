using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = CreateArray();

        Console.WriteLine("Массив элементов:");
        PrintArray(array);
    }

    static int[] CreateArray()
    {
        int[] array = new int[8];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}