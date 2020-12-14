using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MFU
{
    public class Warehouse
    {

        public string model { get; set; }
        public double Price { get; set; }
        public Warehouse(string model, double price)
        {
            Model = model;
            Price = price;
        }
        public static Dictionary<string, Warehouse> GetWarehouse()
        {
            var warehouse = new Dictionary<string, Warehouse>();
            var theWarehouse = new Warehouse("mg-245", 325);
            warehouse.Add("Canon", theWarehouse);

            theWarehouse = new Warehouse("dg-24", 405);
            warehouse.Add("HP", theWarehouse);

            return warehouse;
        }
    }
}
