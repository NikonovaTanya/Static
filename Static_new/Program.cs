using System;

namespace Static_new
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Введите a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b= ");
            int b = int.Parse(Console.ReadLine());
            do
            { 
            Console.WriteLine("Введите операцию: + - / *" );
            Console.WriteLine("0 - выход из программы");
            ch = Console.ReadLine()[0];
                switch (ch)
                {
                    case '+':
                        {
                            Console.WriteLine(a+" + "+b+ "= "+calc.sum(a, b));
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine(a + " - " + b + "= " + calc.minus(a, b));
                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine(a + " * " + b + "= " + calc.mult(a, b));
                            break;
                        }
                    case '/':
                        {
                            Console.WriteLine(a + " / " + b + "= " + calc.div(a, b));
                            break;
                        }
                    default: break;
                }
                Console.ReadKey();
                //Console.Clear();
            }   while (ch != '0');
         }
        }
    }

