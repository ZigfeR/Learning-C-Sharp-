using System;

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
            double pricePrinetCanon = 349;
            double priceScannerCanon = 110;
            double priceMfuCanon = pricePrinetCanon + priceScannerCanon;
            Printer printerCanon = new CanonPrinter("CND-730", pricePrinetCanon);
            Scanner scannerCanon = new CanonScaner("CS-14", priceScannerCanon);
            var mfuCanon = new MFU_Canon("MF-02", priceMfuCanon, printerCanon, scannerCanon);

            Printer printerHp = new HpPrinter("GV-210", 310);
            Scanner scannerHp = new HpScanner("HHS-356", 129);
            var mfuHp = new MFU_Hp("MF-ML-46", 439, printerHp, scannerHp);

            var theDevice = Warehouse.GetWarehouse();
            var theDev = theDevice["CS-14"];

            Console.WriteLine("Model:\t\t{0} \nQuantity:\t{1}", theDev.Model, theDev.Quantity);
            mfuHp.Info();
            //string scannedPathOne = ReadLine();
            //string scannedStrOne = ReadLine();
            //mfuHp.Scan(scannedStrOne, scannedPathOne);

        }
    }
}
