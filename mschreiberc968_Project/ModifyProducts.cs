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
        private int modPartID;
        public ModifyProducts(Part part, int PartID)
        {
            InitializeComponent();
            LoadPartData();
            //modPartID = PartID;
            //txt_modifyProductID.Text = PartID.ToString();
            //txt_modifyPartName.Text = part.Name;
            //txt_modifyPartInventory.Text = part.InStock.ToString();
            //txt_modifyPartPriceCost.Text = part.Price.ToString();
            //txt_modifyPartMin.Text = part.Min.ToString();
            //txt_modifyPartMax.Text = part.Max.ToString();
        }

        private void LoadPartData()
        {
            dgv_AllModParts.AutoGenerateColumns = true;
            dgv_AllModParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_AllModParts.DataSource = Inventory.AllParts;
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

        private void label6_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

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
