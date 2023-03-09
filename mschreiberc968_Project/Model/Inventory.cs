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
                
            }

            public MockData(int partID, string name, double price, int inStock, int min, int max, string companyName)
            {
                PartID = partID;
                Name = name;
                Price = price;
                InStock = inStock;
                Min = min;
                Max = max;
                CompanyName = companyName;
            }

            public static void LoadMockData()
            {
                //create mock inhouse parts
                Part mockPart1 = new MockData(1, "tuner peg", 3.99, 25, 1, 9, 11923);
                Part mockPart2 = new MockData(2, "electronics", 150.87, 12, 1, 3, 11924);
                //create outsourced parts
                Part mockPart3 = new MockData(3, "tuner peg", 3.99, 25, 1, 9, "Ergotronics");
                Part mockPart4 = new MockData(4, "electronics", 150.87, 12, 1, 3, "Method Products");

                //Add mock parts to list
                Parts.Add(mockPart1);
                Parts.Add(mockPart2);
                Parts.Add(mockPart3);
                Parts.Add(mockPart4);
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
