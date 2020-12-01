using System.Text;
using System.IO;
using System;

namespace MFU
{
    public partial class Printer
    {
        protected private double Price { get; set; }
        protected string Name { get; set; }

        public void Print(int Modul, string strToWrite)
        {
            Console.WriteLine("\n-Printing in progress-\n");

            for (int i = 1; i <= Modul; i++){
                Console.WriteLine(strToWrite);
            }

            Console.WriteLine("\n-Printing completed-\n");
        }
    }
}
