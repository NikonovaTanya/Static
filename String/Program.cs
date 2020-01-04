using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "mama";
            Console.WriteLine("Строка: "+str);
            Console.WriteLine("Встроенный метод Substring:");
            Console.WriteLine(str.Substring(1, 3));
            Console.WriteLine(str.Substring(2));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Собственный метод Substring: ");
            Console.WriteLine(str.SubString(1, 3));
            Console.WriteLine(str.SubString(2));
            Console.WriteLine("Встроенный метод IndexOf:");
            Console.WriteLine(str.IndexOf("am"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Собственный метод IndexOf: ");
            if (str.IndexOfNew("am")!=-1)
              Console.WriteLine(str.IndexOfNew("am"));
            else
                Console.WriteLine("Нет такого вхождения ");
            Console.WriteLine("Встроенный метод Replace:");
            Console.WriteLine(str.Replace("am","aa"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Собственный метод Replace: ");
            Console.WriteLine(str.ReplaceNew("am", "aa"));
        }
    }
}
