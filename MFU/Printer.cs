using System.Text;
using System.IO;
using System;

namespace MFU
{
    class Printer
    {
        public void Print(string strToWrite)
        {
            Console.WriteLine("\n-Printing in progress-\n");
            Console.WriteLine(strToWrite);
            Console.WriteLine("\n-Printing completed-\n");
        }
    }
}
