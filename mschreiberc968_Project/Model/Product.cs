using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{
    public class Product 
    {
        public int ProductID { get; set; }
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public int ProdInStock { get; set; }
        public int ProdMin { get; set; }
        public int ProdMax { get; set; }

        public static BindingList<Part> AssociatedParts = new BindingList<Part>();

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            ProdName = name;
            ProdPrice = price;
            ProdInStock = inStock;
            ProdMin = min;
            ProdMax = max;
        }

        public Product()
        {

        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int PartID)
        {
            Part partToRemove = AssociatedParts[PartID];
            if (partToRemove != null)
            {
                return false;
            }
            else
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
        }

        public void AddAssociatedProduct(Part part)
        {
            AssociatedParts.Add(part);
        }
    }
   }




