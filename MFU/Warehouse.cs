using System.Collections.Generic;

namespace MFU
{
    public class Warehouse
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public double Quantity { get; set; }
        public Warehouse(string name, string model, double quantity)
        {
            Name = name;
            Model = model;
            Quantity = quantity;
        }
        public static Dictionary<string, Warehouse> GetPrinters()
        {
            var device = new Dictionary<string, Warehouse>();
            //Canon
            var theDevice = new Warehouse("Canon", "CND-730", 10);
            device.Add("CND-730", theDevice);
            //HP
            theDevice = new Warehouse("HP", "GV-210", 15);
            device.Add("GV-210", theDevice);

            return device;
        }
        public static Dictionary<string, Warehouse> GetScanners()
        {
            var device = new Dictionary<string, Warehouse>();
            //Canon
            var theDevice = new Warehouse("Canon", "CS-14", 10);
            device.Add("CS-14", theDevice);
            //HP
            theDevice = new Warehouse("HP", "HHS-356", 15);
            device.Add("HHS-356", theDevice);

            return device;
        }
    }
}
