using System;

namespace Recursive
{
    class Program
    {
        static void ProgressBar(int status)
        {
            Console.Write("w");
            //for (int x = 0; x < 10000000; x++) ;
            if (status < 100)
            {
                status++;
                ProgressBar(status);
            }
            return;
        }
        static void StatusBar(int num)
        {
            Console.WriteLine($"Прогресс бар на 100%\n");
            Console.Write("[");
            ProgressBar(num);
            Console.WriteLine("]\n");
        }
        static int Factorial(int factorial)
        {
            if (factorial == 0)
            {
                return 1;
            }
            else
            {
                return factorial * Factorial(factorial - 1);
            }
        }
        static int Fibonacci(int fib)
        {
            if (fib == 0 || fib == 1)
            {
                return fib;
            }
            else
            {
                return Fibonacci(fib - 1) + Fibonacci(fib - 2);
            }
        }
        static bool isPrime(int n, int i)
        {
            if (n <= 2)
                return (n == 2) ? true : false;
            if (n % i == 0)
                return false;
            if (i * i > n)
                return true;

            return isPrime(n, i + 1);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Упражнение рекурсии");
                Console.WriteLine("-----------------------\n");

                int x = 0;
                StatusBar(x);

                Console.Write("Введите число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                Console.Write("Число фибоначи: ");
                Console.WriteLine(Fibonacci(num1));

                Console.Write("Число факториала: ");
                Console.WriteLine(Factorial(num1));

                Console.WriteLine(" ");


                Console.Write("Проверка на простое число: ");
                int startNumber = int.Parse(Console.ReadLine());

                if (isPrime(startNumber, 2))
                    Console.Write("Yes");
                else
                    Console.Write("No");


                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
