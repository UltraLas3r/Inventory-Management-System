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
        public BindingList<Part> partsToAdd = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            txt_AddProductName.Focus();
            dgv_AllAddParts.AutoGenerateColumns = true;
            dgv_AllAddParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_AllAddParts.DataSource = Inventory.AllParts;

            //for bottom grid 
            BindingList<Product> newEmptyGrid = new BindingList<Product>();
            dgv_AssociatedAddParts.AutoGenerateColumns = true;
            dgv_AssociatedAddParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
           


        }
        private void btn_AddProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainS.Visible = true;
        }

        private void btn_AddProductSave_Click(object sender, EventArgs e)
        {
            //validate integer amount compliance
            int currentInventory;
            int minStock;
            int maxStock;

            try
            {
                currentInventory = Int32.Parse(txt_AddProductInventory.Text);
                minStock = int.Parse(txt_AddProductMin.Text);
                maxStock = int.Parse(txt_AddProductMax.Text);
            }
            catch 
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must contain a number.");
                return;
            }


            Random rnd = new Random();
            int num = rnd.Next(1000);

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

            //Create the new product
            Product newProd = new Product();
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
                Part part = row.DataBoundItem as Part;

                newProd.AddAssociatedPart(part);

            }

            this.Hide();
            mainS.Visible = true;
        }

        private void btn_AddParts_Click(object sender, EventArgs e)
        {
            dgv_AssociatedAddParts.DataSource = Inventory.AllParts;
            //get the selected row and clone it
            DataGridViewRow selectedRow = dgv_AllAddParts.SelectedRows[0];       
            DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();

           //create a new row in associated parts dgv
            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                newRow.Cells[i].Value = selectedRow.Cells[i].Value;
            }

            //add a new entry to the newEmptyGrid list...
            //dgv_AssociatedAddParts.ColumnCount = 6;
            
            //copy the values from allparts dgv to associated parts dgv
            dgv_AssociatedAddParts.Rows.Add(newRow);


            //new idea?? copy the concept from addPart.cs line 225-238. I need to figure out how to take 
            //cell values from the topdgv and clone/paste them into new cells in the bottom dgv. 
            //there might be an example online about this .
            Product newProduct = new Product();
            newProduct.ProductID = selectedRow.Cells[0].Value;
        }

        private void btn_DeleteParts_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgv_AssociatedAddParts.CurrentRow == null || dgv_AssociatedAddParts.CurrentRow.Selected)
                {
                    foreach (DataGridViewRow row in dgv_AssociatedAddParts.SelectedRows)
                    {
                        dgv_AssociatedAddParts.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void txt_AddProductName_TextChanged(object sender, EventArgs e)
        {
            if (txt_AddProductName.Text.Length > 0)
            {
                CheckTextBoxForString(txt_AddProductName);
            }

            else {txt_AddProductName.BackColor = Color.LightCoral; }

            if (txt_AddProductName.BackColor == Color.LightCoral)
            {
                btn_AddProductSave.Enabled = false;
            }
            else { btn_AddProductSave.Enabled = true; }
        }

        private void txt_AddProductInventory_TextChanged(object sender, EventArgs e)
        {
            if (txt_AddProductInventory.Text.Length > 0)
            CheckTextBoxForInt(txt_AddProductInventory);

            else
            {
                txt_AddProductInventory.BackColor = Color.LightCoral;
            }

            if (txt_AddProductInventory.BackColor == Color.LightCoral)
            {
                btn_AddProductSave.Enabled = false;
            }
            else btn_AddProductSave.Enabled = true;
        }

        private void txt_AddProductPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AddProductPriceCost.Text) || !Double.TryParse(txt_AddProductPriceCost.Text, out double n))
            {
                btn_AddProductSave.Enabled = false;
                txt_AddProductPriceCost.BackColor = Color.LightCoral;
            }
           
            else
            {
                btn_AddProductSave.Enabled = true;
                txt_AddProductPriceCost.BackColor = Color.White;
            }
        }

        private void txt_AddProductMin_TextChanged(object sender, EventArgs e)
        {
            if (txt_AddProductMin.Text.Length > 0)
            {
                CheckTextBoxForInt(txt_AddProductMin);
            }
            else { txt_AddProductMin.BackColor = Color.LightCoral; }

            if (txt_AddProductMax.BackColor == Color.LightCoral)
            {
                btn_AddProductSave.Enabled = false;
            }
            else { btn_AddProductSave.Enabled = true; }
        }

        private void txt_AddProductMax_TextChanged(object sender, EventArgs e)
        {
            if (txt_AddProductMax.Text.Length > 0)
            {
                CheckTextBoxForInt(txt_AddProductMax);
            }
            else { txt_AddProductMax.BackColor = Color.LightCoral; }

            if (txt_AddProductMax.BackColor == Color.LightCoral)
            {
                btn_AddProductSave.Enabled = false;
            }
            else { btn_AddProductSave.Enabled = true; }
        }
    
        private void txt_AddProdSearch_TextChanged(object sender, EventArgs e)
        {            
            string searchContent = txt_AddProdSearch.Text.Trim();
            if (string.IsNullOrEmpty(txt_AddProdSearch.Text))
            {
                MessageBox.Show("Enter a valid search term");
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dgv_AllAddParts.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchContent))
                        {
                            cell.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        public void CheckTextBoxForString(TextBox textBox)
        {
            //This can be called to check the textbox for string values and will change the color depending on what exists.
            int number;
            bool isNumber = int.TryParse(textBox.Text, out number);

            if (isNumber)
            {
                textBox.BackColor = Color.LightCoral;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        public void CheckTextBoxForInt(TextBox textBox)
        {
            //This can be called to check the textbox for INT values and will change the color depending on what exists.
            int number;
            bool isNumber = int.TryParse(textBox.Text, out number);

            if (!isNumber)
            {
                textBox.BackColor = Color.LightCoral;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

    }
}
