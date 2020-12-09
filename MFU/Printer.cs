using System;

namespace MFU
{
    public class Printer
    {
        public virtual void Print(string strToPrint)
        {
            Console.WriteLine("\n-Printing in progress-\n");

            Console.WriteLine(strToPrint);

            Console.WriteLine("\n-Printing completed-\n");
        }
    }
}
