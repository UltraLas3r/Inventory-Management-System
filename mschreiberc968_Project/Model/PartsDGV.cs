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
                new Part { IdCode = 1, Name = "Tuner Peg", Inventory = 4, Max = 5, Min = 1, Price = 9.99 });
            PartsList.Add(
                new Part { IdCode = 2, Name = "Fretboard", Inventory = 9, Max = 3, Min = 1, Price = 150.84 });
            PartsList.Add(
                new Part { IdCode = 3, Name = "Pickup", Inventory = 18, Max = 9, Min = 1, Price = 100.84 });
            PartsList.Add(
                new Part { IdCode = 4, Name = "Body", Inventory = 25, Max = 8, Min = 1, Price = 350.00 });
            PartsList.Add(
                new Part { IdCode = 4, Name = "Electronic Components", Inventory = 3, Max = 4, Min = 1, Price = 350.00 });
            //add a few more ports to this :D

        }

        public override string ToString()
        {
            return "[" + IdCode + "] --> + " + Name + " - " + Inventory + " (" + Price + ")";
        }
        
    }
}

