using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Working with arrays");
                Console.WriteLine("-----------------------\n");
                //Connecting arrays
                var Create = new CreatorArrays();
                var array = new Array();
                var growing = new Growing();
                var search = new Search();
                var minMax = new MinMax();
                //Task 1
                Console.Write("Enter the number of array elements separated by commas:\n\n");

                Create.Creator();

                Console.ReadKey();
                //Task 2
                Console.WriteLine("\n\nGrowing an array");
                Console.WriteLine("-----------------------\n");

                var myArrayTwo = new int[] { 56, 87, 4, 1, 97 };

                array.Usual(ref myArrayTwo);
                Console.Write("\n\nAdd number to END array:\t");
                int AddEND = Convert.ToInt32(Console.ReadLine());

                growing.AddLast(ref myArrayTwo, AddEND);
                Console.WriteLine();
                array.Usual(ref myArrayTwo);

                Console.Write("\n\nAdd number to START array:\t");
                int AddSTART = Convert.ToInt32(Console.ReadLine());

                growing.AddFirst(ref myArrayTwo, AddSTART);
                Console.WriteLine();
                array.Usual(ref myArrayTwo);

                Console.ReadKey();
                //Task 3
                Console.WriteLine("\n\nSerarch index an array");
                Console.WriteLine("-----------------------\n");

                var myArrayTree = new int[] { 34, 23, 9, 36, 6, 97, 4 };

                array.Usual(ref myArrayTree);

                Console.Write("\n\nSearch number to array:\t\t");
                int searchIndex = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                search.FindIndex(ref myArrayTree, searchIndex);
                Console.WriteLine();

                Console.ReadKey();
                //Task 4
                Console.WriteLine("\nRevers array");
                Console.WriteLine("-----------------------\n");

                var myArrayFour = new int[] { 8, 76, 3, 73, 2, 1, 53, 89 };

                Console.WriteLine("Usual\n");
                array.Usual(ref myArrayFour);
                Console.WriteLine("\n\nReverse\n");
                array.Reverse(ref myArrayFour);
                Console.WriteLine();
                Console.ReadKey();
                //Task 5
                Console.WriteLine("\nSorting array");
                Console.WriteLine("-----------------------\n");

                var myArrayFive = new int[] { 78, 6, 3, 67, 84, 11, 19, 9 };

                Console.WriteLine("Usual\n");
                array.Usual(ref myArrayFive);

                Console.WriteLine("\n\nSorting\n");
                array.Sorting(ref myArrayFive);
                Console.ReadKey();
                //Task 6
                Console.WriteLine("\n\nMaxValue array");
                Console.WriteLine("-----------------------\n");

                var myArraySix = new int[] { 54, 8, 65, 9, 33, 6 };

                Console.WriteLine("Usual\n");
                array.Usual(ref myArraySix);

                Console.WriteLine("\n\nMaxValue\n");
                minMax.MaxValue(ref myArraySix);

                Console.WriteLine("\nMinValue\n");
                minMax.MinValue(ref myArraySix);

                Console.ReadKey();
                //Task 7
                Console.WriteLine("\nBinarSearch array");
                Console.WriteLine("-----------------------\n");

                var myArraySeven = new int[] { 34, 525, 23, 9, 36, 324, 6, 89, 4, 456, 78, 2, 13, 212 };

                Console.WriteLine("Sorting\n");
                array.Sorting(ref myArraySeven);

                Console.Write("\n\nSearch numer: \t");
                int numB = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nBinar Search: \t");
                search.BinarIndex(ref myArraySeven, numB);

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
