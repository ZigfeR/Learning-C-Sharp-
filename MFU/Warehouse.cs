using System.Collections.Generic;

namespace MFU
{
    public class Warehouse
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public double Quantity { get; set; }
        public Warehouse(string name, string type, string model, double quantity)
        {
            Name = name;
            Type = type;
            Model = model;
            Quantity = quantity;
        }
        public static Dictionary<string, Warehouse> GetWarehouse()
        {
            var device = new Dictionary<string, Warehouse>();
            //Canon
            var theDevice = new Warehouse("Canon", "Printer", "CND-730", 10);
            device.Add("CND-730", theDevice);
            theDevice = new Warehouse("Canon", "Scanner", "CS-14", 10);
            device.Add("CS-14", theDevice);
            //HP
            theDevice = new Warehouse("HP", "Printer", "GV-210", 15);
            device.Add("GV-210", theDevice);
            theDevice = new Warehouse("HP", "Scanner", "HHS-356", 15);
            device.Add("HHS-356", theDevice);

            return device;
        }
    }
}
