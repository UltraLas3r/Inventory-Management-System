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

        //PRODUCTS
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int productID)
        {
            Product productToDelete = LookupProduct(productID);

            if (productToDelete == null)
            {
                return false;
            }
            else
            {
                Products.Remove(productToDelete);
                return true;
            }
        }
        public static Product LookupProduct(int productID)
        {
            foreach (Product pr in Products)
            {
                if (pr.ProductID == productID)
                {
                    return pr;
                }
            }
            return null;
        }

        public static void UpdateProduct(int productID, Product product)
        {
            RemoveProduct(productID);
            AddProduct(product);
        }

        //PARTS
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(int partID)
        {
            Part deletedPart = LookupPart(partID);

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

        public static Part LookupPart(int partID)
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

    //mock data 
        public static void LoadMockData()
            {
                //create mock inhouse parts
                Part mockPart1 = new InHouse(1, "Tuning Peg", 3.99m, 6, 1, 9, 11923);
                Part mockPart2 = new InHouse(2, "Pickups", 150.87m, 12, 1, 15, 11924);
                //create outsourced parts
                Part mockPart3 = new OutSourced(3, "Knobs", 8.99m, 8, 1, 9, "Ergotronics");
                Part mockPart4 = new OutSourced(4, "Switch", 222.87m, 3, 1, 7, "Method Products");

                //Add mock parts to list
                AllParts.Add(mockPart1);
                AllParts.Add(mockPart2);
                AllParts.Add(mockPart3);
                AllParts.Add(mockPart4);

                //mock products
                Product mockProduct1 = new Product(33, "Electric Guitar", 400.00m, 5, 1, 9);
                Product mockProduct2 = new Product(34, "Acoustic", 800.00m, 5, 1, 13);
                Product mockProduct3 = new Product(35, "Bass", 2300.00m, 4, 1, 7);

                //Add mock product to list
                Products.Add(mockProduct1);
                Products.Add(mockProduct2);
                Products.Add(mockProduct3);
            }
    }

 }

    