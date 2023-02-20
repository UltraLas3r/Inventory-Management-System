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
        private BindingSource BindingSource;


        public MainScreen()
        {
            InitializeComponent();

            //makes grid read only and disables multiselect
            dgv_Parts.ReadOnly = true;
            dgv_Parts.MultiSelect = false;

            //sets data source and inputs mock data 
            dgv_Parts.DataSource = Part.PartsList;

            //selects full horizontal row
            dgv_Parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //remove bottom field
            dgv_Parts.AllowUserToAddRows = false;


            //The below statements are for the Products DataGridView
            dgv_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_Products.ReadOnly = true;
            dgv_Products.MultiSelect = false;

            dgv_Products.AllowUserToAddRows = false;

            dgv_Products.DataSource = BindingSource;
            BindingSource = new BindingSource { DataSource = ProductsDGV.ProductsProperty };



        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void addParts_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();

        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            //create an exit window that pops up and asks the user if they want to exit the application, if they click YES it will application.exit
            //if they click NO then the window will close and the application wont exit.
            Application.Exit(); //THIS IS TEMPORARY UNTIL THE ABOVE FUNCTIONALITY IS IMPLETMENTED
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cellClick = dgv_Parts.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string columnName = dgv_Parts.Columns[e.ColumnIndex].Name;

                MessageBox.Show("You selected " + cellClick.Value.ToString() + ". ID Value " + dgv_Parts.CurrentRow.Cells["Idcode"].Value + ", in Column" + columnName);
            }


        }

        private void modifyParts_Click(object sender, EventArgs e)
        {   //warning message if user hasnt selected an object to modify
            if (!dgv_Parts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected. Please select an item to modify.");
                return;
            }




        }


    }
}
