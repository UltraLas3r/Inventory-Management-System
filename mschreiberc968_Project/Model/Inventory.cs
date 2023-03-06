using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{
    class Inventory
    {
        //parts bindinglist 
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static BindingList<Product> Products = new BindingList<Product>();
      
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        //the following is used to create mock data 
        public class MyMockData : Part
        {
            public MyMockData()
            {
                //inhouse part
                Parts.Add(new InHouse(PartID = 1, Name = "tuner peg", Price = 3.99, InStock = 25, Min = 1, Max = 9, MachineID = 11923));
             
                //outsourced part
                Parts.Add(new InHouse(2, "strings", 23.99, 200, 1, 15, "Mock Company"));
            }
        }

    }


   
}
