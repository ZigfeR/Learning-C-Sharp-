using System;

namespace Wiels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнения с циклами");
            Console.WriteLine("---------------------\n");

            //Задание 1
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");

            //Задание 2
            Console.WriteLine("");
            Console.Write("Введиет длину строки звездочек: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= num; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");

            //Задание 3
            Console.WriteLine("");
            Console.WriteLine("Квадрат");
            Console.WriteLine("");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Прямоугольник");
            Console.WriteLine("");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            //Задание 4
            //Снизу вверх
            Console.WriteLine("");
            Console.Write("Введиет число для Треугольников и Ромба: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 1; i <= num2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Сверху вниз
            Console.WriteLine();
            for (int i = num2; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Зеркало сверху вниз
            Console.WriteLine();
            for (int i = 1; i <= num2; i++)
            {
                for (int j = num2; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Зеркало снизу вверх
            Console.WriteLine();
            for (int i = num2; i > 0; i--)
            {
                for (int j = num2; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Задание 5
            //Ромб
            Console.WriteLine();
            for (int i = 1; i <= num2; i++)
            {
                for (int j = num2; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= ((i * 2) - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = (num2 - 1); i > 0; i--)
            {
                for (int j = num2; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= ((i * 2) - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
