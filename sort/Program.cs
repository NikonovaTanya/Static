using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array.inputArray();
            array.bubbleSort();
            array.print();
        }
    }
}
