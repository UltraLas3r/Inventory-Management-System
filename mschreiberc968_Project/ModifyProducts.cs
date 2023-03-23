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
        private int modProductID;
        public ModifyProducts()
        {
            InitializeComponent();
            LoadPartData();
            txt_ModifyProductName.Focus();
        }

        private void LoadPartData()
        {
            dgv_AllModParts.AutoGenerateColumns = true;
            dgv_AllModParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_AllModParts.DataSource = Inventory.AllParts;
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

        private void modifyPartMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void modifyPartMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyPartInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyPartName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void modifyProductsID_TextChanged(object sender, EventArgs e)
        {
           // string newId = modifyProductsID.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ModProductCancel  (object sender, EventArgs e)
        {
            this.Hide();
            mainScreenView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenView();
        }
    }
}
