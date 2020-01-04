using System;

namespace SortDirection
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '0';
            Console.Write("Введите количество элементов n=");
            int n = int.Parse(Console.ReadLine());
            do {
                Console.WriteLine("Введите: true-сортировка по возрастанию, false-сортировка по убыанию");
                bool flag = bool.Parse(Console.ReadLine());
                int[] array = new int[n];
                array.inputArray();
                array.bubbleSort(flag);
                array.print();
                ch = Console.ReadLine()[0];
            } while (ch != '0');


        }
    }
}
