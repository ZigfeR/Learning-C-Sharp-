using System;

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
        public void Info()
        {
            Console.WriteLine($"\nTrademark:\t{name}");
            Console.WriteLine($"\nModel:\t\t{model}");
            Console.WriteLine($"\nPrice:\t\t{price}$");
        }
        public override void Print(string strToPrint)
        {
            base.Print(strToPrint);
        }
    }
}
