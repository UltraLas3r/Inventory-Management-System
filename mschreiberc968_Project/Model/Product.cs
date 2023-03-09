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

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public void AddAssociatedParts(Part part)
        {
            AssociatedParts.Add(part);
        }

        //public bool RemoveAssociatedPart (int)
        //{
        //    AssociatedParts.Remove;
        //}

        //public Part lookupAssociatedPart(int)
        //{

    }
}



