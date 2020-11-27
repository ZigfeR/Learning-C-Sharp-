using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MinMax
    {
        public void MinValue(ref int[] array)
        {
            int minValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                    minValue = array[i];
            }

            Console.WriteLine(minValue);
        }
        public void MaxValue(ref int[] array)
        {
            int maxValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }

            Console.WriteLine(maxValue);
        }

    }
}
