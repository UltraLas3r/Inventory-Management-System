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
    public partial class MainScreen : Form
    {
        private int TempPartID;
        private int TempProdID;

        public MainScreen()
        {
            InitializeComponent();
            Display();

            //The below statements are rules for the Parts Data Grid View
            dgv_Parts.ReadOnly = true;
            dgv_Parts.MultiSelect = false;
            dgv_Parts.AllowUserToAddRows = false;
            dgv_Parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //The below statements are rules for the Products DataGridView
            dgv_Products.ReadOnly = true;
            dgv_Products.MultiSelect = false;
            dgv_Products.AllowUserToAddRows = false;
            dgv_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Display()
        {
            //PARTS DGV
            dgv_Parts.AutoGenerateColumns = true;
            dgv_Parts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_Parts.DataSource = Inventory.AllParts;

            //PRODUCTS DGV
            dgv_Products.AutoGenerateColumns = true;
            dgv_Products.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Products.DataSource = Inventory.Products;   
        }

        public object mainScreenView()
        {
            MainScreen mainScreen = new MainScreen();
            return (mainScreen.Visible = true);
        }

     
        private void productsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void addParts_Click(object sender, EventArgs e)
        { //this opens the addParts window
            AddPart addPart = new AddPart();
            addPart.Show();
            this.Visible = false; 
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_Parts.ClearSelection();
        }

        private void myProductsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_Products.ClearSelection();
        }

        private void dgv_Parts_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                TempPartID = (int)dgv_Parts.Rows[e.RowIndex].Cells[0].Value;
            }
    
        }

        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    TempProdID = (int)dgv_Products.Rows[e.RowIndex].Cells[0].Value;
                }
            }
        }




        private void modifyParts_Click(object sender, EventArgs e)
        {   //warning message if user hasnt selected an object to modify
            if (!dgv_Parts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected. Please select an item to modify.");
                return;
            }

            else 
            {
                var tempSelectedPart = (Part)dgv_Parts.CurrentRow.DataBoundItem;

                modifyPart modifyParts = new modifyPart(tempSelectedPart, TempPartID);
                modifyParts.Show();
                
                this.Visible = false;
            }
        }

        private void dgv_Parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   //on click, take the row data and assign it to the currentIdx variable
            
            //show data being stored
           
            //CurrentObj = mylist[CurrentIndex];

        }

        private void addProducts_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Visible = true;
            this.Hide();
        }

        private void modifyProducts_Click(object sender, EventArgs e)
        {
            ModifyProducts modifyProduct = new ModifyProducts();
            modifyProduct.Visible = true;
            this.Hide();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

       private void deleteParts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Parts.SelectedRows)
            {
                dgv_Parts.Rows.RemoveAt(row.Index);
            }
        }
    }
}
