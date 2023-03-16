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
        private void radioButtonCheck(object sender, EventArgs e)
        {
            if (RadioInHouse.Checked)
            {
                lbl_ForRadioChange.Text = "Machine ID #:";
            }
            else 
            {
                lbl_ForRadioChange.Text = "Company Name:";
            }
           
        }

       
      

        private void btn_Save(object sender, EventArgs e)
        {
            //check for min/max compliance
            if (int.Parse(modifyPartMin.Text) >= int.Parse(modifyPartMax.Text))
            {
                MessageBox.Show("Minimum must be less than maximum");
                return;
            };

            if (int.Parse(modifyPartMin.Text) >= int.Parse(modifyPartInventory.Text))
            { 
                MessageBox.Show("The minimum value must be less than the inventory value.");
                return;
            }

            if (int.Parse(modifyPartMax.Text) <= int.Parse(modifyPartInventory.Text))
            {
                MessageBox.Show("The maximum value must be greater than the inventory value.");
                return;
            }

            if (RadioInHouse.Checked)
            {
                Part UpdatePartIH = new InHouse()
                {
                    PartID = Int32.Parse(modifyPartID.Text),
                    Name = modifyPartName.Text,
                    Price = Decimal.Parse(modifyPartPriceCost.Text),
                    InStock = Int32.Parse(modifyPartInventory.Text),
                    Min = Int32.Parse(modifyPartMin.Text),
                    Max = Int32.Parse(modifyPartMax.Text),
                    MachineID = Int32.Parse(modifyPartCompanyName.Text)
                };
                Inventory.UpdatePart(UpdatePartIH.PartID, UpdatePartIH);
            }

            else if (RadioOutsource.Checked)
                { 
                Part UpdatePartOS = new OutSource()
                {
                    PartID = Int32.Parse(modifyPartID.Text),
                    Name = modifyPartName.Text,
                    Price = Decimal.Parse(modifyPartPriceCost.Text),
                    InStock = Int32.Parse(modifyPartInventory.Text),
                    Min = Int32.Parse(modifyPartMin.Text),
                    Max = Int32.Parse(modifyPartMax.Text),
                    CompanyName = modifyPartCompanyName.Text
                };
                Inventory.UpdatePart(UpdatePartOS.PartID, UpdatePartOS);
            }
            this.Hide();
            mainScreenView();
        }
    }
}


       
    

