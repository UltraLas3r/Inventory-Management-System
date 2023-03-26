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
            lbl_MustAssociatePart.Visible = false;
        }

        private void Display()
        {
            dgv_AllAddParts.AutoGenerateColumns = true;
            dgv_AllAddParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_AllAddParts.DataSource = Inventory.AllParts;
        }
        private void btn_AddProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainS.Visible = true;
        }

        private void btn_AddProductSave_Click(object sender, EventArgs e)
        {
            //NEED TO Save the connection between the object and the associated parts.
            //
           
            if (dgv_AssociatedAddParts.Rows.Count == 0)
            {
                lbl_MustAssociatePart.Visible = true;
                return;
            }

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

            //disable the label
            lbl_MustAssociatePart.Visible = false;
        }

        private void btn_DeleteParts_Click(object sender, EventArgs e)
        {
            if (dgv_AssociatedAddParts.CurrentRow == null || dgv_AssociatedAddParts.CurrentRow.Selected)
            {
                RowCheckFunc();
            }
        }

        private void RowCheckFunc()
        {
            foreach (DataGridViewRow row in dgv_AssociatedAddParts.SelectedRows)
            {
                dgv_AssociatedAddParts.Rows.RemoveAt(row.Index);
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

     
        private void txt_AddProdSearch_TextChanged(object sender, EventArgs e)
        {
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
        }
    }
}
