using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{
    public class Part
    {
        public const int IDCODE_IDX = 0;
        public int IdCode { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public double Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static BindingList<Part> PartsList = new BindingList<Part>();

        static Part()
        {
            PartsList.Add(
                new Part { IdCode = 1, Name = "Front Wheel", Inventory = 4, Max = 5, Min = 1, Price = 55.99 });
            PartsList.Add(
                new Part { IdCode = 2, Name = "Rear Wheel", Inventory = 9, Max = 3, Min = 1, Price = 75.84 });
            //add a few more ports to this :D

        }

        public override string ToString()
        {
            return "[" + IdCode + "] --> + " + Name + " - " + Inventory + " (" + Price + ")";
        }
        
    }
}

