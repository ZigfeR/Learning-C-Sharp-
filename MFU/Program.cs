using System;
using System.Collections.Generic;

namespace MFU
{
    class Program
    {
        static string ReadLine()
        {
            string result = Console.ReadLine();
            return result;
        }
        static void Main(string[] args)
        {
            User user = new User(
                "Adrey",
                "University street building 5",
                678,
                0
                );

            double pricePrinterCanonCND730 = 349;
            double priceScannerCanonCS14 = 110;
            double priceMfuCanonMF02 = pricePrinterCanonCND730 + priceScannerCanonCS14;
            Printer printerCanonCND730 = new CanonPrinter("CND-730", pricePrinterCanonCND730);
            Scanner scannerCanonCS14 = new CanonScaner("CS-14", priceScannerCanonCS14);
            var mfuCanonMF02 = new MFU_Canon("MF-02", priceMfuCanonMF02, printerCanonCND730, scannerCanonCS14);

            double pricePrinterHpGV210 = 310;
            double priceScannerHpHHS356 = 129;
            double priceMfuHpMFML46 = pricePrinterHpGV210 + priceScannerHpHHS356;
            Printer printerHpGV210 = new HpPrinter("GV-210", pricePrinterHpGV210);
            Scanner scannerHpHHS356 = new HpScanner("HHS-356", priceScannerHpHHS356);
            var mfuHpMFML46 = new MFU_Hp("MF-ML-46", priceMfuHpMFML46, printerHpGV210, scannerHpHHS356);

            var thePrinter = Warehouse.GetPrinters();
            var theScanner = Warehouse.GetScanners();
            Console.WriteLine("-----Shop entrance-----\n");

            Console.WriteLine("Welcome to our store {0}\n", user.Name);

            Console.WriteLine("What do you want to buy?\n");
            Console.WriteLine("Printer || Scanner || MFU\n");

            string deviceType = ReadLine();
            switch (deviceType)
            {
                case "Printer":
                case "printer":
                    Console.WriteLine("\nWe have such brands:\n");
                    Console.WriteLine("HP || Canon\n");
                    string deviceTypeOne = ReadLine();
                    switch (deviceTypeOne)
                    {
                        case "HP":
                        case "Hp":
                        case "hp":
                            Console.WriteLine("\nSuch models are available:\n");
                            var myValue = thePrinter["HP"];
                            Console.WriteLine("\nModel:\t\t{0} \nQuantity:\t{1}", myValue.Model, myValue.Quantity);
                            
                            break;
                        case "Canon":
                        case "canon":
                            Console.WriteLine("\nSuch models are available:\n");
                            foreach (KeyValuePair<string, Warehouse> keyValue in thePrinter)
                            {
                                Console.WriteLine("\nModel:\t\t{0} \nQuantity:\t{1}", keyValue.Key, keyValue.Value.Quantity);
                            }
                            break;
                        default:
                            Console.WriteLine("\nInvalid selection. Please select HP or Canon.");
                            break;
                    }
                    break;
                case "Scanner":
                case "scanner":
                    Console.WriteLine("We have such brands:\n");
                    Console.WriteLine("HP || Canon");
                    string deviceTypeTwo = ReadLine();
                    switch (deviceTypeTwo)
                    {
                        case "HP":
                        case "Hp":
                        case "hp":
                            Console.WriteLine("\nSuch models are available:\n");
                            foreach (KeyValuePair<string, Warehouse> keyValue in theScanner)
                            {
                                Console.WriteLine("\nModel:\t\t{0} \nQuantity:\t{1}", keyValue.Key, keyValue.Value.Quantity);
                            }
                            break;
                        case "Canon":
                        case "canon":
                            Console.WriteLine("\nSuch models are available:\n");
                            foreach (KeyValuePair<string, Warehouse> keyValue in theScanner)
                            {
                                Console.WriteLine("\nModel:\t\t{0} \nQuantity:\t{1}", keyValue.Key, keyValue.Value.Quantity);
                            }
                            break;
                        default:
                            Console.WriteLine("\nInvalid selection. Please select HP or Canon.");
                            break;
                    }
                    break;
                case "MFU":
                case "Mfu":
                case "mfu":
                    Console.WriteLine("We have such brands:\n");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select Printer, Scanner, or MFU.");
                    break;
            }
            //foreach (var pair in theDevice)
            //{
            //    Console.WriteLine("\nModel:\t\t{0} \nQuantity:\t{1}", pair.Key, pair.Value.Quantity);
            //}
            //var theDev = theDevice["CS-14"];
            //theDev.Quantity -= 1;
            //Console.WriteLine("Model:\t\t{0} \nQuantity:\t{1}", theDev.Model, theDev.Quantity);
            // Loop through the List.
            //string scannedPathOne = ReadLine();
            //string scannedStrOne = ReadLine();
            //mfuHp.Scan(scannedStrOne, scannedPathOne);

        }
    }
}
