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
            Printer printerCanon = new CanonPrinter("CND-730", 349);
            Scanner scannerCanon = new CanonScaner("CS-14", 110);
            var mfuCanon = new MFU_Canon("MF-02", 459, printerCanon, scannerCanon);

            Printer printerHp = new HpPrinter("GV-210", 310);
            Scanner scannerHp = new HpScanner("HHS-356", 129);
            var mfuHp = new MFU_Hp("MF-ML-46", 439, printerHp, scannerHp);

            string scannedPathOne = ReadLine();
            string scannedStrOne = ReadLine();
            mfuHp.Scan(scannedStrOne, scannedPathOne);


        }
    }
}
