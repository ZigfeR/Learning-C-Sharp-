using System;

namespace Functions
{
    class Program
    {

        static string ReadLine()
        {
            string result = Console.ReadLine();
            return result;
        }
        static int CalcOperator(int num1, int num2, string OperatorOne)
        {
            int result = 0;
            switch (OperatorOne)
            {
                case "+":
                    result = SumTwo(num1, num2);
                    Console.WriteLine($"Результат сложения: ");
                    break;
                case "-":
                    result = SubTwo(num1, num2);
                    Console.WriteLine($"Результат вычетания: ");
                    break;
                case "*":
                    result = MultTwo(num1, num2);
                    Console.WriteLine($"Результат умножения: ");
                    break;
                case "/":
                    result = DivTwo(num1, num2);
                    Console.WriteLine($"Результат сложения: ");
                    break;
                default:
                    Console.WriteLine($"Неизвестный деления: {OperatorOne}");
                    break;
            }
            return result;
        }
        static int SumTwo(int NumbOne, int NumbTwo)
        {
            return NumbOne + NumbTwo;
        }
        static int SubTwo(int NumbOne, int NumbTwo)
        {
            return NumbOne - NumbTwo;
        }
        static int MultTwo(int NumbOne, int NumbTwo)
        {
            return NumbOne * NumbTwo;
        }
        static int DivTwo(int NumbOne, int NumbTwo)
        {
            return NumbOne / NumbTwo;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Калькулятор на функциях");
                Console.WriteLine("-----------------------\n");

                Console.WriteLine("Введите первое число: ");
                int num1 = Convert.ToInt32(ReadLine());

                Console.WriteLine(" ");

                Console.WriteLine("Введите доступные операторы: ");
                Console.WriteLine("'+' || '-' || '/' || '*' ");
                string OperatorOne = ReadLine();

                Console.WriteLine(" ");

                Console.WriteLine("Введите второе число: ");
                int num2 = Convert.ToInt32(ReadLine());

                Console.WriteLine(" ");

                Console.WriteLine(CalcOperator(num1, num2, OperatorOne));



                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
