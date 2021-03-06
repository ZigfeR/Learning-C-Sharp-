﻿using System;

namespace MFU
{
    class MFU_Canon : MFU
    {
        private string name = "Canon";
        private string model;
        private double price;
        private Printer printer;
        private Scanner scanner;
        public MFU_Canon(string model, double price, Printer printer, Scanner scanner)
        {
            this.model = model;
            this.price = price;
            this.printer = printer;
            this.scanner = scanner;
        }
        public void Info()
        {
            Console.WriteLine($"\nTrademark:\t{name}");
            Console.WriteLine($"\nModel:\t\t{model}");
            Console.WriteLine($"\nPrice:\t\t{price}$");
        }
        public void Print(string strToPrint)
        {
            printer.Print(strToPrint);
        }
        public void Scan(string strToWrite, string path)
        {
            scanner.Scan(strToWrite, path);
        }
    }
}
