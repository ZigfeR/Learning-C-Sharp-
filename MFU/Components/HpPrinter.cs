using System;

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
        public void Info()
        {
            Console.WriteLine($"\n{name}");
            Console.WriteLine($"\n{model}");
            Console.WriteLine($"\n{price}$");

        }
        public override void Print(string strToPrint)
        {
            base.Print(strToPrint);
        }
    }
}
