using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{

    public abstract class PartContainer
    {
        public static BindingList<Part> MyList = new BindingList<Part>();
        public static int CurrentIndex { get; set; }
    }
    public class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
            
        public Part (int partID, string name, int inventory, decimal price, int inStock, int min, int max)
            
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }



    }
}
