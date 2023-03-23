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
            Display();    
        }

        private void Display()
        {
            dgv_AllModParts.AutoGenerateColumns = true;
            dgv_AllModParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_AllModParts.DataSource = Inventory.AllParts;
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
        }

        public object mainScreenView()
        {
            MainScreen mainScreen = new MainScreen();
            return (mainScreen.Visible = true);
        }
        private void modifyProductsID_TextChanged(object sender, EventArgs e)
        {

        }
        private void modifyPartName_TextChanged(object sender, EventArgs e)
        {


        }
        private void modifyPartInventory_TextChanged(object sender, EventArgs e)
        {

        }
        private void modifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {

        }
        private void modifyPartMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyPartMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewPart(object sender, EventArgs e)
        {
            ///what is this button supposed to do??
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteAssociatedPart(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_AllModParts.SelectedRows)
            {
                dgv_AllModParts.Rows.RemoveAt(row.Index);
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenView();
        }
    }
}
