using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Search
    {
        public int FindIndex(ref int[] array, int search)
        {
            int searchIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)
                    searchIndex = i;
            }
            if (searchIndex > 1)
                Console.WriteLine($"Index of the required number '{searchIndex}'");
            else
                Console.WriteLine($"There is no required number '{search}'");
            return searchIndex;
        }
        public int BinarIndex(ref int[] array, int search)
        {
            int key;
            int Left = 0;
            int Right = array.Length - 1;
            key = (Right + Left) / 2;
            int counter = 0;
            while (Left < Right - 1)
            {
                counter++;
                key = (Right + Left) / 2;
                if (array[key] == search)
                {
                    Console.WriteLine(key);
                    return key;
                }
                counter++;
                if (array[key] < search)
                    Left = key;
                else
                    Right = key;
            }
            if (array[key] != search)
            {
                if (array[Left] == search)
                    key = Left;
                else
                {
                    if (array[Right] == search)
                        key = Right;
                    else
                        key = -1;
                };
            }

            if (key > -1)
                Console.WriteLine($"Index of the required number '{key}'");
            else
                Console.WriteLine($"There is no required number '{search}'");
            return key;
        }
    }
}
