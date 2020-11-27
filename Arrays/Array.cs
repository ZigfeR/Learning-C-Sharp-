using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Array
    {
        public void Usual(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
        }
        public void Reverse(ref int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write($"{array[i]} ");
        }
        public void Sorting(ref int[] array, int temp = 0)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Usual(ref array);
        }
    }
}
