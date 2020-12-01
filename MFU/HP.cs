using System;
using System.Collections.Generic;
using System.Text;

namespace MFU
{
    class HP
    {
    }
    class HpPrinter : Printer
    {
        public void Print()
        {
            Price = 213;
            Name = "HP";

            Console.WriteLine("\n---Printer started---\n");

            Console.WriteLine(Name);
            Console.WriteLine($"\n{Price}$");

            Console.WriteLine("\nWhat do you want to print: \n");
            string scannedStrOne = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("How many pages do you want to print: ");
            int numberOfPages = Convert.ToInt32(Console.ReadLine());
            base.Print(numberOfPages, scannedStrOne);
        }
    }
    class HpScaner : Scanner
    {
    }
}
