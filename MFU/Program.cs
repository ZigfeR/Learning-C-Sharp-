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
            var mfu = new MFU();
            var printer = new Printer();
            var scaner = new Scanner();
            var canon = new CanonPrinter();
            var hp = new HpPrinter();

            Console.WriteLine("Working with objects");
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("\n---Printer started---\n");
            Console.WriteLine("\nWhat do you want to print: \n");
            string scannedStrOne = ReadLine();
            Console.WriteLine("");
            Console.Write("How many pages do you want to print: ");
            int numberOfPages = Convert.ToInt32(ReadLine());
            canon.Print(numberOfPages, scannedStrOne);

            hp.Print();

            Console.WriteLine("\n---Scanner launched---\n");
            
            Console.WriteLine("\n-Scanning in progress-");
            Console.WriteLine("\nWhich drive to import the file to:\n");
            string path = ReadLine();
            Console.WriteLine("\nPlease enter scanned text:\n");
            string scannedStrTwo = ReadLine();
            scaner.Scan(scannedStrTwo, path);
            Console.WriteLine("\n-Scan completed-\n");

            Console.WriteLine("\n---MFU started---\n");
            Console.WriteLine("\n-Scanning in progress-");
            Console.WriteLine("\nPlease enter scanned text:\n");
            string scannedStrTree = ReadLine();
            //mfu.Scan(scannedStrTree, path);
            Console.WriteLine("\n-Scan completed-\n");

            mfu.Extracts(path);
        }
    }
}
