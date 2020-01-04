using System;
using System.Collections.Generic;
using System.Text;

namespace sort
{
    public static class Array
    {
    

        public static void inputArray(this int [] mas)
        {
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());

            }
        }
        public static void print(this int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i] } \t");
            }
            Console.WriteLine();
        }
        public static void bubbleSort(this int[] mas)
        {
            int tmp = 0;
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = (mas.Length - 1); j >= (i + 1); j--)
                    if (mas[j] < mas[j - 1])
                    {
                        tmp = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = tmp;
                    }
            }
        }
    }
}
