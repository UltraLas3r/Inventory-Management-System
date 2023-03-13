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
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static BindingList<Product> Products = new BindingList<Product>();

        //the following is used to create in house and outsource data
        public class InHouseData : Part
        {
            public InHouseData(int partID, string name, double price, int inStock, int min, int max, int machineID)
            {
                PartID = partID;
                Name = name;
                Price = price;
                InStock = inStock;
                Min = min;
                Max = max;
                MachineID = machineID;
            }
        }
        public class OutSourceData : Part
        {
            public OutSourceData(int partID, string name, double price, int inStock, int min, int max, string companyName)
            {
                PartID = partID;
                Name = name;
                Price = price;
                InStock = inStock;
                Min = min;
                Max = max;
                CompanyName = companyName;
            }

        }

        //The following code handles products

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //public static Product LookupProduct (int productID)
        //{
        //    foreach (Product p in AllParts)
        //    {
        //        if (p.lookupAssociatedPart(productID) == productID)
        //        {
        //            return p;
        //        }
        //    }

        //    return null;
        //}

        //public bool RemoveProduct(int partID)
        //{
        //    Part deletePart = lookupPart(partID);
        //    if (deletePart == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {

        //    }
        //}

        //public LookupProduct(int)
        //{

        //}

        public static Part lookupPart(int partID)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }

        public static bool DeletePart(int partID)
        {
            Part deletedPart = lookupPart(partID);

                if (deletedPart == null)
            {
                return false;
            }
                else
            {
                AllParts.Remove(deletedPart);
                return true;
            }
        }

        public void UpdateProduct()
            {

            }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }


    //mock data 
    public static void LoadMockData()
        {
            //create mock inhouse parts
            Part mockPart1 = new InHouseData(1, "tuner peg", 3.99, 25, 1, 9, 11923);
            Part mockPart2 = new InHouseData(2, "electronics", 150.87, 12, 1, 3, 11924);
            //create outsourced parts
            Part mockPart3 = new OutSourceData(3, "tuner peg", 3.99, 25, 1, 9, "Ergotronics");
            Part mockPart4 = new OutSourceData(4, "electronics", 150.87, 12, 1, 3, "Method Products");

            //Add mock parts to list
            AllParts.Add(mockPart1);
            AllParts.Add(mockPart2);
            AllParts.Add(mockPart3);
            AllParts.Add(mockPart4);

            //mock products
            //Product mockProduct1 = new Product(33, "Electric Guitar", 400.00, 5, 1, 3);

            //Add mock product to list
           // Products.Add(mockProduct1);

            // Products.Add(mockProduct1);



    }
    }
 }

    