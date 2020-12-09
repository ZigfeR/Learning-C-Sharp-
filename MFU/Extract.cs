using System.Text;
using System.IO;
using System;

namespace MFU
{
    public partial class Extract
    {
        public void Extracts(string path)
        {
            string data;
            Console.WriteLine("\n-Printing in progress-\n");
            FileStream fsSource = new FileStream($"{path}:\\Test.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource))
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            Console.WriteLine("\n-Printing completed-\n");
            Console.ReadLine();
        }
    }
}
