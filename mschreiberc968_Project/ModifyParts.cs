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
            ValidateTextBox(modifyPartInventory);
            ValidateTextBox(modifyPartPriceCost);
            ValidateTextBox(modifyPartMin);
            ValidateTextBox(modifyPartMax);

            ValidateTextBox(modifyPartName);
            ValidateTextBox(modifyPartCompanyName);

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
        public void ValidateTextBox(TextBox textBox)
        {
            //This can be called to check the textbox for string values and will change the color depending on what exists.
            int number;
            bool isNumber = int.TryParse(textBox.Text, out number);

            if (isNumber)
            {
                textBox.BackColor = Color.LightCoral;
            }
            else
            {
                textBox.BackColor = Color.White;
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
            int currentInventory = Int32.Parse(modifyPartInventory.Text);
            if (int.Parse(modifyPartMin.Text) >= int.Parse(modifyPartMax.Text))
            {
                MessageBox.Show("Minimum must be less than maximum");
                return;
            };

            if (int.Parse(modifyPartMin.Text) >= currentInventory)
            { 
                MessageBox.Show("The Minimum value cannot be greater than the Inventory value");
                return;
            }

            if (int.Parse(modifyPartMax.Text) <= currentInventory)
            {
                MessageBox.Show("The Inventory value " + modifyPartInventory.Text + " must be less than the Max value" + modifyPartMax.Text);
                return;
            }        

            if (RadioInHouse.Checked)
            {
                int _MachineID;
                try
                {
                    _MachineID = Int32.Parse(modifyPartCompanyName.Text);
                }
                catch
                {
                    MessageBox.Show("Please only type numbers in MachineID field, " + modifyPartCompanyName.Text + " is not a number", "Field Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    modifyPartCompanyName.Focus();
                    modifyPartCompanyName.Clear();
                    return;
                }

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


       
    

