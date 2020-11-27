using System;

namespace ConsoleApp
{class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 1
            /*
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Калькулятор запущен \n");
                Console.WriteLine("--------------------\n");

                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(""); //не нашел как делать абзац

                Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение 4.Деление");
                int calc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                int result = 0;
                switch (calc)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Результат сложения :{result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Результат вычетания :{result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Результат умножения :{result}");
                        break;
                    case 4:
                        result = num1 / num2;
                        Console.WriteLine($"Результат деления :{result}");
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }
                Console.ReadKey();
            }
            
            /*
            //Задание 2
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Чет не чет\r");
                Console.WriteLine("----------\n");

                Console.Write("Введите число для проверки: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                if (num % 2 == 0)
                {
                    Console.WriteLine($"Число '{num}' четное");
                }
                else if (!(num % 2 == 0))
                {
                    Console.WriteLine($" Число '{num}' нечетное");
                }

                Console.ReadKey();
            }
            */
            //Задание 3
            //int[] myNumbers = { 42, 5, 78, 23, 57 };
            //Console.WriteLine(myNumbers.Max());
            //Спасибо W3
            //https://www.w3schools.com/cs/cs_arrays.asp
            
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Какое введеное число больше?\r");
                Console.WriteLine("----------------------------\n");

                int num1, num2, num3, num4, num5, num6;

                Console.Write("Введите желаемое '1' число: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите желаемое '2' число: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите желаемое '3' число: ");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите желаемое '4' число: ");
                num4 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите желаемое '5' число: ");
                num5 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите желаемое '6' число: ");
                num6 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                /*
                //Первый способ
                if (num1 > num2 && num1>num3 && num1 > num4 && num1 > num5 && num1 > num6)
                {
                    Console.WriteLine(num1);
                }
                else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5 && num2 > num6)
                {
                    Console.WriteLine(num2);
                }
                else if (num3 > num2 && num3 > num1 && num3 > num4 && num3 > num5 && num3 > num6)
                {
                    Console.WriteLine(num3);
                }
                else if (num4 > num2 && num4 > num3 && num4 > num1 && num4 > num5 && num4 > num6)
                {
                    Console.WriteLine(num4);
                }
                else if (num5 > num2 && num5 > num3 && num5 > num4 && num5 > num1 && num5 > num6)
                {
                    Console.WriteLine(num5);
                }
                else if (num6 > num2 && num6 > num3 && num6 > num4 && num6 > num1 && num6 > num5)
                {
                    Console.WriteLine(num6);
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так..");
                }
                */
                //Второй способ
                int max = num1;

                if (max < num2)
                {
                    max = num2;
                }
                if (max < num3)
                {
                    max = num3;
                }
                if (max < num4)
                {
                    max = num4;
                }
                if (max < num5)
                {
                    max = num5;
                }
                if (max < num6)
                {
                    max = num6;
                }

                Console.WriteLine(max);

                Console.ReadKey();
            }
        }
    }
}
