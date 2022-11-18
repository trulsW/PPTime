using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTime
{
    public class Produckt
    {

        public string Name { get; set; }
        public int Price { get; set; }
        //public int Count { get; set; }


        public Produckt(string name, int price)
        {
            Name = name;
            Price = price;
        
        }


        public void ShowProdukts()
        {
            Console.WriteLine($"ProduktName: {Name} Price: {Price}");
        }
    }
}
