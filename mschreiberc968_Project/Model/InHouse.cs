using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{
    class InHouse : Part
    {
        public int machineID { get; set; }

        public InHouse(int partId, string name, double price, int inStock, int min, int max, int machineID)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }

        public InHouse(int partId, string name, double price, int inStock, int min, int max, string companyName)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

       
    }
}