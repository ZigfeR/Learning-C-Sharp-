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
        public static Dictionary<string, Warehouse> GetWarehouse()
        {
            var warehouse = new Dictionary<string, Warehouse>();
            var theWarehouse = new Warehouse("Canon", "CND-730", 10);
            warehouse.Add("CND-730", theWarehouse);

            theWarehouse = new Warehouse("HP", "GV-210", 15);
            warehouse.Add("GV-210", theWarehouse);

            return warehouse;
        }
    }
}
