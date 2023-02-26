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

        public MainScreen()
        {
            InitializeComponent();
            display();
            
            //makes grid read only and disables multiselect
            dgv_Parts.ReadOnly = true;
            dgv_Parts.MultiSelect = false;

            //sets data source and inputs mock data 
            dgv_Parts.DataSource = PartContainer.MyList;

            //selects full horizontal row
            dgv_Parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //remove bottom field
            dgv_Parts.AllowUserToAddRows = false;


            //The below statements are for the Products DataGridView
            dgv_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_Products.ReadOnly = true;
            dgv_Products.MultiSelect = false;

            dgv_Products.AllowUserToAddRows = false;

            
           // BindingSource = new BindingSource { DataSource = ProductsDGV.ProductsProperty };


        }

        public class PartListMockData : Part
        {

            public PartListMockData() =>
            
                PartContainer.MyList.Add(new Part(1, "Tuner Peg", 8, 9, 20, 1, 8));

            
        }

        private void display()
        {
            dgv_Parts.AutoGenerateColumns = false;
            dgv_Parts.DataSource = PartContainer.MyList;
        }

        public object mainScreenView()
        {
            MainScreen mainScreen = new MainScreen();
            return (mainScreen.Visible = true);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                modifyPart modifyParts = new modifyPart();
                modifyParts.Show();
                this.Visible = false;
            }
        }

        private void dgv_Parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   //on click, take the row data and assign it to the currentIdx variable
            PartContainer.CurrentIndex = dgv_Parts.CurrentCell.RowIndex;
            //show data being stored
            Console.WriteLine(PartContainer.CurrentIndex);
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

        private void deleteParts_Click(object sender, EventArgs e)
        {
           
            if (PartContainer.CurrentIndex >= 0)
            {
                PartContainer.MyList.RemoveAt(PartContainer.CurrentIndex);
                display();
                PartContainer.CurrentIndex = -1;
            }
            else
            {
                MessageBox.Show("Please Select a row to delete");
            }
        }
    }
}
