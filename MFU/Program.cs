using System.Text;
using System.IO;
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


            Console.WriteLine("Working with objects");
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("---------dics--------\n");

            string scannedPathOne = ReadLine();

            Console.WriteLine("---------read--------\n");

            string scannedStrTwo = ReadLine();
            mfuHp.Scan(scannedStrTwo, scannedPathOne);

            Console.WriteLine("\nWhat do you want to print: \n");

            string scannedStrOne = ReadLine();
            mfuCanon.Print(scannedStrOne);

            Console.WriteLine("---------extr--------\n");

            mfuHp.Extracts(scannedPathOne);
        }
    }
}
