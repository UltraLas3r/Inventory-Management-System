using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiberc968_Project.Model
{
    class Inventory
    {
        //parts bindinglist 
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static BindingList<Product> Products = new BindingList<Product>();

        //the following is used to create mock data 
        public class MockData : Part
        {
           
            public MockData(int partID, string name, double price, int inStock, int min, int max, int machineID)
            {
                PartID = partID;
                Name = name;
                Price = price;
                InStock = inStock;
                Min = min;
                Max = max;
                MachineID = machineID;

                // POSSIBLY DELETE THE BELOW CODE
                ////Create mock parts
                //Part mockPart1 = new MockData(1, "tuner peg", 3.99, 25, 1, 9, 11923);

                ////Add the mock parts to the bindingList using the AddPart function
                //Parts.Add(mockPart1);
            }

             public static void LoadMockData()
            {
                Part mockPart1 = new MockData(1, "tuner peg", 3.99, 25, 1, 9, 11923);
                Part mockPart2 = new MockData(1, "tuner peg", 3.99, 25, 1, 9, 11923);
                Parts.Add(mockPart1);
                Parts.Add(mockPart2);
            }

            public static void AddPart(Part part)
            {
                Parts.Add(part);
            }

        }













        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

    }

}
