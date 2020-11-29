using System.Text;
using System.IO;
using System;

namespace MFU
{
    class Program
    {
        static void Main(string[] args)
        {
            var mfu = new MFU();
            var printer = new Printer();
            var scaner = new Scanner();

            Console.WriteLine("Working with objects");
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("\n---Printer started---\n");
            Console.WriteLine("\n-What do you want to print-\n");

            printer.Print(Console.ReadLine());

            Console.WriteLine("\n---Scanner launched---\n");

            Console.WriteLine("\n-Scanning in progress-");
            Console.WriteLine("\nWhich drive to import the file to:\n");
            string path = Console.ReadLine();
            Console.WriteLine("\nPlease enter scanned text:\n");
            string scannedStrOne = Console.ReadLine();
            scaner.Scan(scannedStrOne, path);
            Console.WriteLine("\n-Scan completed-\n");

            Console.WriteLine("\n---MFU started---\n");
            Console.WriteLine("\n-Scanning in progress-");
            Console.WriteLine("\nPlease enter scanned text:\n");
            string scannedStrTwo = Console.ReadLine();
            mfu.Scan(scannedStrTwo, path);
            Console.WriteLine("\n-Scan completed-\n");

            mfu.Extracts(path);
        }
    }
}
