﻿using System;
using System.Collections.Generic;
using System.Text;

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
