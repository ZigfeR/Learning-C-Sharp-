using System;
using System.Collections.Generic;
using System.Text;

namespace MFU
{
    class CanonPrinter : Printer
    {
        private string name = "Canon";
        private string model;
        private double price; 
        public CanonPrinter()
        {

        }
        public CanonPrinter(string model, double price)
        {
            this.model = model;
            this.price = price;
        }
        public override void Print(string scannedStrOne)
        {
            Console.WriteLine(name);
            Console.WriteLine(model);
            Console.WriteLine($"\n{price}$");

            base.Print(scannedStrOne);
        }
    }
}
