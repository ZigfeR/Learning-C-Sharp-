using System;

namespace Pifagor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Таблица Пи v4 Final");
                Console.WriteLine("--------------------------\n");

                Console.WriteLine("Выберите тип таблицы: ");
                Console.WriteLine("От 'A' до 'Б' || Только от 'A' ");
                Console.WriteLine("      1       ||       2       ");

                Console.WriteLine("");
                int TableType = int.Parse(Console.ReadLine());

                switch (TableType)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Таблица Пи от 'A' до 'Б'");
                        Console.WriteLine("-------------------------\n");
                        //Ввод данных
                        Console.WriteLine("Введите начальное число ширины: ");
                        int HeightStart = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите конечное число ширины: ");
                        int HeighEnd = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите начальное число высоты: ");
                        int WidthStart = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите конечное число высоты: ");
                        int WidthEnd = int.Parse(Console.ReadLine());

                        int LocalSpaceH = HeighEnd;
                        int LocalSpaceW = WidthEnd;

                        int count1 = 1;
                        int sum1 = HeighEnd * WidthEnd;

                        int LocalSpaceCountW = 0;
                        int LocalSpaceCountH = 0;

                        Console.WriteLine();
                        //Пробелы
                        for (; LocalSpaceW >= 1; LocalSpaceW /= 10) { LocalSpaceCountW++; }
                        for (; LocalSpaceH >= 1; LocalSpaceH /= 10) { LocalSpaceCountH++; }
                        for (; sum1 >= 1; count1++, sum1 /= 10) ;
                        //Верхняя линия
                        for (int TopLine = 0; TopLine < LocalSpaceCountH; TopLine++) { Console.Write(" "); }
                        Console.Write("|");
                        for (int lenghth = HeightStart; lenghth <= HeighEnd; lenghth++)
                        {
                            int LocalCount = 0;
                            int LocalSpaceLenghth = lenghth;
                            for (; LocalSpaceLenghth >= 1; LocalSpaceLenghth /= 10) { LocalCount++; }
                            for (; LocalCount < count1; LocalCount++) { Console.Write(" "); }
                            Console.Write(lenghth);
                        }
                        Console.WriteLine();
                        //Таблица
                        for (int Table = WidthStart; Table <= WidthEnd; Table++)
                        {
                            //Пунктир
                            if (Table == WidthStart)
                            {
                                int DotLine = 0;
                                for (; DotLine < LocalSpaceCountH; DotLine++) { Console.Write("-"); }
                                Console.Write("+");
                                for (; DotLine <= count1 * (HeighEnd - HeightStart) + LocalSpaceCountH + count1 - 1; DotLine++) { Console.Write("-"); }

                                Console.WriteLine();
                            }
                            //Сумма
                            for (int Sum1 = HeightStart; Sum1 <= HeighEnd; Sum1++)
                            {
                                if (Sum1 == HeightStart)
                                {
                                    int LocalCount1 = 0;
                                    int LocalSpaceC = Table;

                                    for (; LocalSpaceC >= 1; LocalSpaceC /= 10) { LocalCount1++; }
                                    for (; LocalCount1 < LocalSpaceCountW; LocalCount1++) { Console.Write(" "); }

                                    Console.Write(Table);
                                    Console.Write("|");
                                }
                                int LocalSpaceOne = Table * Sum1;
                                int LocalCount = 0;
                                for (; LocalSpaceOne >= 1; LocalSpaceOne /= 10) { LocalCount++; }
                                for (; LocalCount < count1; LocalCount++) { Console.Write(" "); }
                                Console.Write(Table * Sum1);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Таблица Пи только от 'A'");
                        Console.WriteLine("-------------------------\n");
                        //Ввод данных
                        Console.Write("Введите длину высоты: ");
                        int height = Convert.ToInt32(Console.ReadLine());


                        Console.Write("Введите длину ширины: ");
                        int width = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                        Console.Write("Введите начальное число высоты: ");
                        int NumH = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите начальное число ширины: ");
                        int NumW = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                        int NumWidth = NumW;
                        int NumHeight = NumH - 1;

                        int count2 = 1;
                        int sum2 = height * width;

                        int LocalSpace2 = NumW;
                        int LocalSpaceCount2 = 0;

                        //Пробелы
                        for (; LocalSpace2 >= 1; LocalSpace2 /= 10) { LocalSpaceCount2++; }
                        for (; sum2 >= 1; count2++, sum2 /= 10) ;
                        //Первая строка
                        for (int LSpace = 0; LSpace <= LocalSpaceCount2 + 5; LSpace++) { Console.Write(" "); }
                        Console.Write("|");

                        for (int lenghthSpace = 1; lenghthSpace <= width; lenghthSpace++)
                        {
                            int LocalSpaceLenghth2 = (NumW < 10) ? LocalSpaceCount2 + 4 :
                                    (NumW < 100) ? LocalSpaceCount2 + 3 :
                                    (NumW < 1000) ? LocalSpaceCount2 + 2 :
                                    LocalSpaceCount2 + 1;
                            for (int LSpace = 0; LSpace <= LocalSpaceLenghth2; LSpace++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(NumW++);
                        }
                        Console.WriteLine();

                        //Таблица v3
                        for (int table = 1; table <= height; table++)
                        {
                            if (table == 1)
                            {
                                for (int LSpace = 0; LSpace <= LocalSpaceCount2 + 5; LSpace++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("+");
                                int factor = (width < 10 && NumWidth < 10) ? 7 :
                                    (width < 10 && NumWidth > 10) ? 8 :
                                    (width > 10 && NumWidth > 10) ? 8 :
                                    (width > 10 && NumWidth < 10) ? 7 : 1;
                                for (int line = 0; line <= width * factor - 1; line++)
                                {
                                    Console.Write("-");
                                }
                                Console.WriteLine();
                            }
                            //Расчет пробелов <..
                            int LocalSpaceLenghth2 = (NumHeight < 9) ? LocalSpaceCount2 + 4 :
                                    (NumHeight < 99) ? LocalSpaceCount2 + 3 :
                                    (NumHeight < 999) ? LocalSpaceCount2 + 2 :
                                    LocalSpaceCount2 + 1;
                            for (int LSpace = 0; LSpace <= LocalSpaceLenghth2; LSpace++)
                            {
                                Console.Write(" ");
                            }
                            //..>
                            for (int a = 1; a <= 1; a++)
                            {
                                Console.Write(++NumHeight);
                            }
                            Console.Write("|");
                            //Сумма

                            for (int sum3 = NumWidth; sum3 <= NumW - 1; sum3++)
                            {
                                int LocalSum = NumHeight * sum3;

                                //Расчет пробелов <..
                                int LocalSpaceLenghth3 = (LocalSum < 10) ? LocalSpaceCount2 + 4 :
                                    (LocalSum < 100) ? LocalSpaceCount2 + 3 :
                                    (LocalSum < 1000) ? LocalSpaceCount2 + 2 :
                                    LocalSpaceCount2 + 1;
                                for (int LSpace = 0; LSpace <= LocalSpaceLenghth3; LSpace++)
                                {
                                    Console.Write(" ");
                                }
                                //..>
                                Console.Write(LocalSum);
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine($"Неизвестный выбор: {TableType}");
                        break;
                }
                Console.WriteLine();
                Console.ReadKey();
                /*
                while (true)
                {//Таблица v1
                    for (int table = 1; table <= height; table++)
                    {
                        if (table == 1)
                        {
                            for (int m = 1; m <= 5; m++)
                            {
                                Console.Write("-");
                            }
                            for (int p = 1; p <= 1; p++)
                            {
                                Console.Write("+");
                            }
                            for (int line = 0; line <= count + width * 3 - 2; line++)
                            {
                                Console.Write("-");
                            }
                            Console.WriteLine();
                        }
                        for (int n = 1; n <= 1; n++)
                        {
                            Console.Write("{0,5}", num++);
                        }
                        for (int h = 1; h <= 1; h++)
                        {
                            Console.Write("|");
                        }
                        for (int sum1 = 1; sum1 <= width; sum1++)
                        {
                            Console.Write("{0,4}", table * j);
                        }
                        Console.WriteLine();
                    }
                    
                    Console.WriteLine();
                    Console.ReadKey();
                }
                */
            }
        }
    }
}
