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
        }

        private void Display()
        {
            dgv_AllAddParts.AutoGenerateColumns = true;
            dgv_AllAddParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_AllAddParts.DataSource = Inventory.AllParts;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddProductCancel_Click(object sender, EventArgs e)
        {


            this.Hide();
            mainS.Visible = true;
        }

        private void btn_AddProductSave_Click(object sender, EventArgs e)
        {
            //save all changes and apply them to the appropriate DGV spaces

            this.Hide();
            mainS.Visible = true;
        }
    }
}
