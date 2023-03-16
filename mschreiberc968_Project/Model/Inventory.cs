using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
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

        //the following is to remove parts, i dont know if it is correct
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

        public static void UpdatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = part;
                }
            }
        }

        public static void UpdateProduct(int productID, Part part)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = part;
                }
            }
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

    //mock data 
    public static void LoadMockData()
        {
            //create mock inhouse parts
            Part mockPart1 = new InHouse(1, "tuner peg", 3.99m, 25, 1, 9, 11923);
            Part mockPart2 = new InHouse(2, "electronics", 150.87m, 12, 1, 3, 11924);
            //create outsourced parts
            Part mockPart3 = new OutSource(3, "tuner peg", 3.99m, 25, 1, 9, "Ergotronics");
            Part mockPart4 = new OutSource(4, "electronics", 150.87m, 12, 1, 3, "Method Products");

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

    