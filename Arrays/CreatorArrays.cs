using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class CreatorArrays
    {
        public void Creator()
        {
            //Console.Write("Enter the number of elements of the array:\t");

            //int elemCount = Convert.ToInt32(Console.ReadLine());
            //var myArrayOne = new string[elemCount];

            //for (int i = 0; i < myArrayOne.Length; i++)
            //{
            //    Console.Write($"\nEnter item under number {i}:\t");
            //    myArrayOne[i]= Convert.ToInt32(Console.ReadLine());
            //}
            var dataOne = Console.ReadLine();
            char[] strCharOne = dataOne.ToCharArray();
            string strOne = "";

            Console.WriteLine("\nIterating over an array:\n");
            for (int i = 0; i < strCharOne.Length; i++)
            {
                if (strCharOne[i] == ' ')
                {
                    strOne = "";
                    continue;
                }

                strOne += strCharOne[i];

                if (strCharOne[i] == ',' || strCharOne[i] == '.')
                    Console.Write($"{strOne} ");
            }
        }
    }
}
