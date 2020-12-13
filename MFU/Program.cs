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
            Printer printerHp = new HpPrinter("GV-210", 309);
            Scanner scannerCanon = new CanonScaner("CS-14", 110);
            Scanner scannerHp = new HpScanner("HHS-356", 110);
            var mfuCanon = new MFU_Canon("MF-02", 500, printerCanon, scannerCanon);
            var mfuHp = new MFU_Hp("MF-ML-46", 500, printerHp, scannerHp);



            Console.WriteLine("Working with objects");
            Console.WriteLine("-----------------------\n");
            
            Console.WriteLine("\n---Printer started---\n");

            Console.WriteLine("\nWhat do you want to print: \n");
            string scannedStrOne = ReadLine();
            mfuCanon.Print(scannedStrOne);

            string scannedPathOne = ReadLine();
            string scannedStrTwo = ReadLine();
            mfuHp.Scan(scannedStrTwo, scannedPathOne);


            //var mfu = new MFU();
            //var printer = new Printer();
            //var scaner = new Scanner();
            //var canon = new CanonPrinter();
            //var hp = new HpPrinter();
            //
            //Printer printerOne = new CanonPrinter();
            //
            //string scannedStrOne = ReadLine();
            //canon.Print(scannedStrOne);
            //
            //string scannedStrTwo = ReadLine();
            //printer.Print(scannedStrTwo);
            //printerOne.Print(scannedStrTwo);
            //Console.WriteLine("\nWhat do you want to print: \n");
            //
            //Console.WriteLine("");
            //Console.Write("How many pages do you want to print: ");
            //string scannedStrTwo = ReadLine();
            //hp.Print(scannedStrTwo);
            //
            //Console.WriteLine("\n---Scanner launched---\n");
            //
            //Console.WriteLine("\n-Scanning in progress-");
            //Console.WriteLine("\nWhich drive to import the file to:\n");
            //string path = ReadLine();
            //Console.WriteLine("\nPlease enter scanned text:\n");
            //string scannedStrTree = ReadLine();
            //scaner.Scan(scannedStrTree, path);
            //
            //
            //Console.WriteLine("\n---MFU started---\n");
            //Console.WriteLine("\n-Scanning in progress-");
            //Console.WriteLine("\nPlease enter scanned text:\n");
            //string scannedStrFour = ReadLine();
            ////mfu.Scan(scannedStrFour, path);
            //Console.WriteLine("\n-Scan completed-\n");
            //
            //mfu.Extracts(path);
        }
    }
}
