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

            //makes grid read only and disables multiselect
            dgv_Parts.ReadOnly = true;
            dgv_Parts.MultiSelect = false;

            //sets data source and inputs mock data 
            dgv_Parts.DataSource = Part.PartsList;

            //selects full horizontal row
            dgv_Parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //remove bottom field
            dgv_Parts.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addParts_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_Parts.ClearSelection();
        }
    }
}
