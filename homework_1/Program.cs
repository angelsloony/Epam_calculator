using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Введите число элементов массива: ");
        n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите arr[{0}]", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int z;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j])
                {
                    z = arr[i];
                    arr[i] = arr[j];
                    arr[j] = z;
                }
            }
        }

        Console.WriteLine("Элементы массива в порядке возрастания: ");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
        }
        Console.ReadLine();

    }
}

