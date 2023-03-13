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
    public partial class modifyPart : Form
    {
        private int modPartID;
        public modifyPart()
        {
            InitializeComponent();
        }

        public modifyPart(Part part, int PartID)
        {
            InitializeComponent();

            modPartID = PartID;
            modifyPartID.Text = PartID.ToString();
            modifyPartName.Text = part.Name;
            modifyPartInventory.Text = part.InStock.ToString();
            modifyPartPriceCost.Text = part.Price.ToString();
            modifyPartMin.Text = part.Min.ToString();
            modifyPartMax.Text = part.Max.ToString();

            if (part is InHouse)
            {
                RadioInHouse.Checked = true;
                lbl_ForRadioChange.Text = "Machine ID";

                InHouse inHouse = part as InHouse;
                modifyPartCompanyName.Text = inHouse.machineID.ToString();
            }
            else
            {
                RadioOutsource.Checked = true;
                lbl_ForRadioChange.Text = "Company Name";

                //OutSourced outSourced = part as OutSourced;
                //modifyPartCompanyName.Text = outSourced.CompanyName;
            }
        }

        public object mainScreenView()
        {
            MainScreen mainScreen = new MainScreen();
            return (mainScreen.Visible = true);
        }

        private void btn_modifyPart(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_closeModifyPart_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Visible = true;

            this.Hide();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ForRadioChange.Text = "Machine ID #:";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ForRadioChange.Text = "Company Name:";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //On Click take the textbox objects from this form and send them to the DGV into the appropriate cell spaces
            //string newCompanyName = new InHouse(companyName);



            ////add new data to the bindinglist
            //Inventory.AllParts(CompanyName).Add(newCompanyName);



            this.Hide();
            mainScreenView();
        }

        //public void PopulateTextBoxes()
        //{ //this method handles  taking the data from the dgv and putting it in the appropriate textbox
        //    modifyPartName.Text = Parts.ToString();
        //}



    }
}
