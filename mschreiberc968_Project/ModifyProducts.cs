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
        public ModifyProducts()
        {
            InitializeComponent();
            
        
        }

        

        private void Btn_ModProductCancel(object sender, EventArgs e)
        {
            this.Hide();
            mainS.Visible = true;
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
            Display();
        }

        private void Display()
        {
            dgv_AllProdModParts.AutoGenerateColumns = true;
            dgv_AllProdModParts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_AllProdModParts.DataSource = Inventory.AllParts;  
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

        private void AddNewPart(object sender, EventArgs e)
        {
            ///what is this button supposed to do??
        }

     

        private void DeleteAssociatedPart(object sender, EventArgs e)
        {
            if (dgv_AssociatedProductParts.CurrentRow == null || dgv_AssociatedProductParts.CurrentRow.Selected)
            {
                RowCheckFunc();
            }
        }

        private void RowCheckFunc()
        {
            foreach (DataGridViewRow row in dgv_AllProdModParts.SelectedRows)
            {
                dgv_AllProdModParts.Rows.RemoveAt(row.Index);
            }
        }

        private void ModifyProductSaveButton(object sender, EventArgs e)
        { 
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
            //NEED TO IMPLEMENT SEARCH FUNCTIONALITY FOR THIS
        }

        private void dgv_AllModParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
