using System;
using System.Collections.Generic;
using System.Text;

namespace MFU
{
    class HpPrinter : Printer
    {
        private string name = "HP";
        private string model;
        private double price;
        public HpPrinter()
        {

        }
        public HpPrinter(string model, double price)
        {
            this.model = model;
            this.price = price;
        }
        public override void Print(string strToPrint)
        {
            Console.WriteLine(name);
            Console.WriteLine(model);
            Console.WriteLine($"\n{price}$");

            base.Print(strToPrint);
        }
    }
}
