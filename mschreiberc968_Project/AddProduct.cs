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
        Product newProduct = new Product();



        public AddProduct()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            txt_AddProductName.Focus();
            dgv_TopAllParts.AutoGenerateColumns = true;
            dgv_TopAllParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_TopAllParts.DataSource = Inventory.AllParts;

            //for bottom grid 
            dgv_BottomAssociatedAddParts.DataSource = newProduct.AssociatedParts;
            dgv_BottomAssociatedAddParts.AutoGenerateColumns = true;
            dgv_BottomAssociatedAddParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
        
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
            foreach (DataGridViewRow row in dgv_TopAllParts.Rows)
            { 
                Part part = row.DataBoundItem as Part;

                newProd.AddAssociatedPart(part);

            }

            this.Hide();
            mainS.Visible = true;
        }

        private void btn_AddPartsToBottomDGV(object sender, EventArgs e)
        {
            if (dgv_TopAllParts.CurrentRow == null || !dgv_TopAllParts.CurrentRow.Selected)
            {
                MessageBox.Show("Must select a part to associate");

                return;

            }
            else
            {
                Part part = dgv_TopAllParts.CurrentRow.DataBoundItem as Part;

                newProduct.AddAssociatedPart(part);

            }
        }

        private void btn_DeleteParts_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgv_BottomAssociatedAddParts.CurrentRow == null || dgv_BottomAssociatedAddParts.CurrentRow.Selected)
                {
                    foreach (DataGridViewRow row in dgv_BottomAssociatedAddParts.SelectedRows)
                    {
                        dgv_BottomAssociatedAddParts.Rows.RemoveAt(row.Index);
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
                foreach (DataGridViewRow row in dgv_TopAllParts.Rows)
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
