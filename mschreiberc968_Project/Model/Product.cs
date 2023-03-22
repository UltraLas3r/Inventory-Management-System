using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{
    class Product 
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public Product()
        {
        }

        BindingList<Part> AssociatedParts = new BindingList<Part>();

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




