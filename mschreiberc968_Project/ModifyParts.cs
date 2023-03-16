using mschreiberc968_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            modifyPartID.Text = part.PartID.ToString();
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
                modifyPartCompanyName.Text = inHouse.MachineID.ToString();
            }
            else
            {
                RadioOutsource.Checked = true;
                lbl_ForRadioChange.Text = "Company Name";

                OutSource outSourced = part as OutSource;
                modifyPartCompanyName.Text = outSourced.CompanyName;
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

        private void btn_Save(object sender, EventArgs e)
        {
            //check for min/max compliance
            if (int.Parse(modifyPartMin.Text) >= int.Parse(modifyPartMax.Text))
            {
                MessageBox.Show("Minimum must be less than maximum");
                return;
            }

            if (RadioInHouse.Checked)
            {
                Part newPartIH = new InHouse()
                {
                    PartID = Int32.Parse(modifyPartID.Text),
                    Name = modifyPartName.Text,
                    //Price = Decimal.ToUInt32(modifyPartPriceCost.Text),
                    InStock = Int32.Parse(modifyPartInventory.Text),
                    Min = Int32.Parse(modifyPartMin.Text),
                    Max = Int32.Parse(modifyPartMax.Text),
                    MachineID = Int32.Parse(modifyPartCompanyName.Text),
            };
                Inventory.AllParts.Add(newPartIH);

            }

            //else if (RadioOutsource.Checked) {
            //    Part newPartOS = new OutSource()
            //    {
            //        PartID = Int32.Parse(modifyPartID.Text),
            //        Name = modifyPartName.Text,
            //        Price = Int32.Parse(modifyPartPriceCost.Text),
            //        InStock = Int32.Parse(modifyPartInventory.Text),
            //        Min = Int32.Parse(modifyPartMin.Text),
            //        Max = Int32.Parse(modifyPartMax.Text),
            //        //CompanyName = modifyPartCompanyName.Text
            //    };
            //    Inventory.AllParts.Add(newPartOS);
            
            //}

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
