using mschreiberc968_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiberc968_Project
{
    public partial class AddProduct : Form
    {
        MainScreen mainS = new MainScreen();
        
        public AddProduct()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgv_AllAddParts.AutoGenerateColumns = true;
            dgv_AllAddParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_AllAddParts.DataSource = Inventory.AllParts;
        }
        private void btn_AddProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainS.Visible = true;
        }

        private void btn_AddProductSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AddProductInventory.Text))
            {
                MessageBox.Show("Must have a product to add a part to.");

                return;
            }
            //validate integer amount compliance
            int currentInventory = Int32.Parse(txt_AddProductInventory.Text);
            int minStock = int.Parse(txt_AddProductMin.Text);
            int maxStock = int.Parse(txt_AddProductMax.Text);

            if (minStock >= maxStock)
            {
                MessageBox.Show("Minimum must be less than maximum");
                return;
            }

            if (minStock >= currentInventory)
            {
                MessageBox.Show("The Minimum value cannot be greater than the Inventory value of " + currentInventory);
                return;
            }

            if (maxStock <= currentInventory)
            {
                MessageBox.Show("The Maximum value must be greater than the Inventory value of " + currentInventory);
                return;
            }

            Random rnd = new Random();
            int num = rnd.Next(1000);
            Product newProd = new Product();

            //Create the new product
            if (minStock <= maxStock && currentInventory >= minStock)
            {   
                newProd.ProductID = num;
                newProd.ProdName = txt_AddProductName.Text;
                newProd.ProdPrice = decimal.Parse(txt_AddProductPriceCost.Text);
                newProd.ProdInStock = int.Parse(txt_AddProductInventory.Text);
                newProd.ProdMin = int.Parse(txt_AddProductMin.Text);
                newProd.ProdMax = int.Parse(txt_AddProductMax.Text);
                Inventory.Products.Add(newProd);
            }

            // Adds currently selectd parts to product associated parts
            foreach (DataGridViewRow row in dgv_AllAddParts.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    newProd.AddAssociatedPart(Inventory.LookupPart(Int32.Parse(row.Cells[0].Value.ToString())));
                }
            }

            this.Hide();
            mainS.Visible = true;
        }

        private void btn_AddParts_Click(object sender, EventArgs e)
        {
            //get the selected row
            DataGridViewRow selectedRow = dgv_AllAddParts.SelectedRows[0];

            //clone the row
            DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
            //create a new row in associated parts dgv
            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                newRow.Cells[i].Value = selectedRow.Cells[i].Value;
            }

            //copy the values from allparts DGV to associated parts dgv
            dgv_AssociatedAddParts.Rows.Add(newRow);
        }

        private void btn_DeleteParts_Click(object sender, EventArgs e)
        {

           foreach (DataGridViewRow row in dgv_AssociatedAddParts.SelectedRows)
            {
                dgv_AssociatedAddParts.Rows.RemoveAt(row.Index);
            }
        }
    }
}
