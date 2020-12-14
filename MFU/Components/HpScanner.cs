using System;

namespace MFU
{
    class HpScanner : Scanner
    {
        private string name = "HP";
        private string model;
        private double price;
        public HpScanner()
        {

        }
        public HpScanner(string model, double price)
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
        public override void Scan(string strToWrite, string path)
        {
            base.Scan(strToWrite, path);
        }
    }
}
