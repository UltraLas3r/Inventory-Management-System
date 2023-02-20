using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mschreiberc968_Project.Model
{
    class ProductsDGV
    {
        public const int IDCODE_IDX = 0;
        public int IdCode { get; set; }
        public string _name { get; set; }
        public int _Inventory { get; set; }
        public double _Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static List<ProductsDGV> products = new List<ProductsDGV>();

        public static List<ProductsDGV> ProductsProperty { get {return products;} }

        public string PRODUCT_ID { get { return IdCode.ToString(); } }
        public string PRODUCT_NAME {get {return  _name; } }
        public string PRODUCT_INVENTORY { get { return _Inventory.ToString(); } }
        public double PRODUCT_PRICE { get { return _Price; } }
        public ProductsDGV(int IDcode, string name, int inventory, double price)
        {
            this.IdCode = IdCode;
            _name = name;
            _Inventory = inventory;
            _Price = price;
        }

        //static ProductsDGV()
        //{
        //    ProductsProperty.Add(
        //        new ProductsDGV { 1, name = "Red Bike" }
        //}

        //public int getId() (return IdCode;)
        //public void setID(int IDCode = ID)
    }
}
