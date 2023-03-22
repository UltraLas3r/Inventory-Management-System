using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mschreiberc968_Project.Model.Inventory;

namespace mschreiberc968_Project.Model
{
    class InHouse : Part
    {

        public int MachineID { get; set; }

        

        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }

        public InHouse()
        {
        }
    }
}