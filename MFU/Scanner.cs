using System.Text;
using System.IO;
using System;

namespace MFU
{
    public partial class Scanner
    {
        public void Scan(string strToWrite, string path)
        {
            string fpath = @$"{path}:\Test.txt";
            // Delete file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            // Create the file
            using (FileStream fs = File.Create(fpath))
            {
                AddTexttoFile(fs, strToWrite);
            }
        }
        void AddTexttoFile(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
