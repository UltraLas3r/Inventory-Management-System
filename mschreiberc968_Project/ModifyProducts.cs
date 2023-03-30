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
    public partial class ModifyProducts : Form
    {
        MainScreen mainS = new MainScreen();
        private int modProductID;

        public BindingList<Part> GridAssociatedParts = new BindingList<Part>();
        public ModifyProducts()
        {
        }

        public ModifyProducts(Product product, int ProductID)
        {
            InitializeComponent();
            modProductID = ProductID;
            txt_modifyProductID.Text = product.ProductID.ToString();
            txt_ModifyProductName.Text = product.ProdName.ToString();
            txt_ModifyProductInventory.Text = product.ProdInStock.ToString();
            txt_ModifyProductPriceCost.Text = product.ProdPrice.ToString();
            txt_ModifyProductMin.Text = product.ProdMin.ToString();
            txt_ModifyProductMax.Text = product.ProdMax.ToString();
            Display(product);
        }

        private void Display(Product product)
        {
            dgv_TopAllParts.AutoGenerateColumns = true;
            //dgv_AllParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_TopAllParts.DataSource = Inventory.AllParts;
            dgv_BottomAssociatedParts.ColumnCount = 6;

            //for bottom grid 
          
            dgv_BottomAssociatedParts.AutoGenerateColumns = false;
           // dgv_AssociatedProductParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
            GridAssociatedParts = product.AssociatedParts;
            dgv_BottomAssociatedParts.DataSource = GridAssociatedParts;

        }
        public object mainScreenView()
        {
            MainScreen mainScreen = new MainScreen();
            return (mainScreen.Visible = true);
        }
        
        private void modifyProductName_TextChanged(object sender, EventArgs e)
        {
            if (txt_ModifyProductName.Text.Length > 0)
            {
                CheckTextBoxForString(txt_ModifyProductName);
            }

            else { txt_ModifyProductName.BackColor = Color.LightCoral; }

            if (txt_ModifyProductName.BackColor == Color.LightCoral)
            {
                btn_ModProductSave.Enabled = false;
            }

            else { btn_ModProductSave.Enabled = true; }
        }
        private void modifyProductInventory_TextChanged(object sender, EventArgs e)
        {
            if (txt_ModifyProductInventory.Text.Length >= 0)
            {
                CheckTextBoxForInt(txt_ModifyProductInventory);
            }

            else { txt_ModifyProductInventory.BackColor = Color.LightCoral; }

            if (txt_ModifyProductInventory.BackColor == Color.LightCoral)
            {
                btn_ModProductSave.Enabled = false;
            }

            else btn_ModProductSave.Enabled = true;
        }
        private void modifyProductPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ModifyProductPriceCost.Text) || !Double.TryParse(txt_ModifyProductPriceCost.Text, out double n))
            {
                CheckTextBoxForInt(txt_ModifyProductPriceCost);

                btn_ModProductSave.Enabled = false;
            }

            else 
            {
                txt_ModifyProductPriceCost.BackColor = Color.White;
                btn_ModProductSave.Enabled = true; 
            }
        }
        private void modifyProductMin_TextChanged(object sender, EventArgs e)
        {
            if (txt_ModifyProductMin.Text.Length > 0)
            {
                CheckTextBoxForInt(txt_ModifyProductMin);
            }

            else { txt_ModifyProductMin.BackColor = Color.LightCoral; }

            if (txt_ModifyProductMin.BackColor == Color.LightCoral)
            {
                btn_ModProductSave.Enabled = false;
            }
            else btn_ModProductSave.Enabled = true;
        }
        private void modifyProductMax_TextChanged(object sender, EventArgs e)
        {
            if (txt_ModifyProductMax.Text.Length > 0)
            {
                CheckTextBoxForInt(txt_ModifyProductMax);
            }

            else { txt_ModifyProductMax.BackColor = Color.LightCoral; }

            if (txt_ModifyProductMax.BackColor == Color.LightCoral)
            {
                btn_ModProductSave.Enabled = false;
            }
            else btn_ModProductSave.Enabled = true;
        }
        private void AddNewAssociatedPart(object sender, EventArgs e)
        {
            if (dgv_TopAllParts.CurrentRow == null || !dgv_TopAllParts.CurrentRow.Selected)
            {
                MessageBox.Show("Must select a part to associate");

                return;

            }
            else
            {
                Part part = dgv_TopAllParts.CurrentRow.DataBoundItem as Part;

                //todo fix the reference for the part
                GridAssociatedParts.Add(part);

                dgv_BottomAssociatedParts.DataSource = GridAssociatedParts;

            }

        }

        private void DeleteAssociatedPart(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgv_BottomAssociatedParts.CurrentRow == null || dgv_BottomAssociatedParts.CurrentRow.Selected)
                {
                    foreach (DataGridViewRow row in dgv_TopAllParts.SelectedRows)
                    {
                        dgv_TopAllParts.Rows.RemoveAt(row.Index);
                    }
                }
            }  
        }

        public void ModifyProductSaveButton(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            int minStock = int.Parse(txt_ModifyProductMin.Text);
            int maxStock = int.Parse(txt_ModifyProductMax.Text);
            int currentInventory = Int32.Parse(txt_ModifyProductInventory.Text);
      
            Random rnd = new Random();
            int num = rnd.Next(1000);
            
            if (minStock <= maxStock && currentInventory >= minStock)
            {
                newProduct.ProductID = num;
                newProduct.ProdName = txt_ModifyProductName.Text;
                newProduct.ProdPrice = decimal.Parse(txt_ModifyProductPriceCost.Text);
                newProduct.ProdInStock = int.Parse(txt_ModifyProductInventory.Text);
                newProduct.ProdMin = int.Parse(txt_ModifyProductMin.Text);
                newProduct.ProdMax = int.Parse(txt_ModifyProductMax.Text);
                Inventory.Products.Add(newProduct);
            }

            if (dgv_BottomAssociatedParts.RowCount >= 1)
            {
                int prodIDForModifiedProduct = int.Parse(txt_modifyProductID.Text);

                Product updateProd = new Product(
                prodIDForModifiedProduct,
                txt_ModifyProductName.Text.ToString(),
                decimal.Parse(txt_ModifyProductPriceCost.Text),
                int.Parse(txt_ModifyProductInventory.Text),
                int.Parse(txt_ModifyProductMin.Text),
                int.Parse(txt_ModifyProductMax.Text));

                //I might not have the UpdateProduct function working correctly??
                Inventory.UpdateProduct(prodIDForModifiedProduct, updateProd);

                for (int i = dgv_BottomAssociatedParts.RowCount - 3; i >= 0; i--)
                {
                    Part partAssociatedWithProduct = (Part)dgv_BottomAssociatedParts.Rows[i].DataBoundItem;

                    //Product.AssociatedParts.Add(partAssociatedWithProduct);
                }
            }


            ////this is where I am having a lot of problems
            //foreach (DataGridView row in dgv_AssociatedProductParts.SelectedCells)
            //{
            //    if (row.SelectedCells[0].Value != null)
            //    {
            //        newProduct.AddAssociatedPart(Inventory.LookupPart(Int32.Parse(row.SelectedCells[0].Value.ToString())));
            //    }
            //}

            
            

            this.Hide();
            mainScreenView();
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

        private void btn_ModProdSearch_Click(object sender, EventArgs e)
        {
            string searchContent = txt_ModProdSearch.Text.Trim();
            if (string.IsNullOrEmpty(txt_ModProdSearch.Text))
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

        private void Btn_ModProductCancel(object sender, EventArgs e)
        {
            this.Hide();
            mainS.Visible = true;
        }


    }
}
