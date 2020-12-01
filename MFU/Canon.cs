using System;
using System.Collections.Generic;
using System.Text;

namespace MFU
{
    class Canon
    {
    }
    class CanonPrinter : Printer
    {
        public new void Print(int Modul, string strToWrite)
        {
            Price = 100;
            Name = "Canon";

            Console.WriteLine(Name);
            Console.WriteLine($"\n{Price}$");

            base.Print(Modul, strToWrite);
        }    
    }
    class CanonScaner : Scanner
    {

    }
}
