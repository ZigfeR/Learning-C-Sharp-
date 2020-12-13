using System;
using System.Collections.Generic;
using System.Text;

namespace MFU
{
    class CanonScaner : Scanner
    {
        private string name = "Canon";
        private string model;
        private double price;
        public CanonScaner()
        {

        }
        public CanonScaner(string model, double price)
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
        public override void Scan(string strToWrite, string path)
        {
            base.Scan(strToWrite, path);
        }
    }
}
