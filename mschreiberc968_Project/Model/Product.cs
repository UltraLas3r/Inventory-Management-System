using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{
    class Product
    {
        BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int _productID { get; set; }
        public string _name { get; set; }
        public decimal _price { get; set; }
        public int _inStock { get; set; }
        public int _min { get; set; }
        public int _max { get; set; }

        public int getProductID()
        {
            return _productID;
        }
        public void AddAssociatedParts(Part part)
        {
            AssociatedParts.Add(part);
        }

        //public bool RemoveAssociatedPart(int)
        //{
        //    AssociatedParts.Remove;

        //}

        //public Part lookupAssociatedPart(int)
        //{
        //    we want to conntect the product ID to the associatedparts.
        //    return ProductID;
        //}

    }
}



