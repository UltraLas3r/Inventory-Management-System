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
        public int number = 0;
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
            ModifyPartInventory.Text = part.InStock.ToString();
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

            //this isnt working for some reason
            if (
              modifyPartName.BackColor == Color.White &&
              ModifyPartInventory.BackColor == Color.White &&
              modifyPartPriceCost.BackColor == Color.White &&
              modifyPartMin.BackColor == Color.White &&
              modifyPartMax.BackColor == Color.White &&
              modifyPartCompanyName.BackColor == Color.White
              )
            {
                btn_ModPartSave.Enabled = true;
            }
            else
            {
                btn_ModPartSave.Enabled = false;
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

        private void ModifyPartName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartName.Text) || int.TryParse(modifyPartName.Text, out int n))
            {
                modifyPartName.BackColor = Color.LightCoral;
            }

            else
            {
                modifyPartName.BackColor = Color.White;
            }
        }

        private void ModifyPartInventory_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(ModifyPartInventory.Text) || !(int.TryParse(ModifyPartInventory.Text, out int n)))
            {
                btn_ModPartSave.Enabled = false;
                ModifyPartInventory.BackColor = Color.White;
            }
            else
            {
                ModifyPartInventory.BackColor = Color.LightCoral;
            }
        }

        private void ModifyPartCompanyName_TextChanged(object sender, EventArgs e)
        {  //need to make if statement check for radiobutton checks 
            if (string.IsNullOrWhiteSpace(modifyPartCompanyName.Text) || int.TryParse(modifyPartCompanyName.Text, out int n))
            {
                modifyPartCompanyName.BackColor = Color.LightCoral;
            }

            else
            {
                modifyPartCompanyName.BackColor = Color.White;
            }
        }

        private void btn_Save(object sender, EventArgs e)
    {
        //check for min/max compliance
        int currentInventory = Int32.Parse(ModifyPartInventory.Text);
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
            MessageBox.Show("The Inventory value " + ModifyPartInventory.Text + " must be less than the Max value" + modifyPartMax.Text);
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
                InStock = Int32.Parse(ModifyPartInventory.Text),
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
                InStock = Int32.Parse(ModifyPartInventory.Text),
                Min = Int32.Parse(modifyPartMin.Text),
                Max = Int32.Parse(modifyPartMax.Text),
                CompanyName = modifyPartCompanyName.Text
            };
            Inventory.UpdatePart(UpdatePartOS.PartID, UpdatePartOS);
        }
        this.Hide();
        mainScreenView();
    }

        private void modifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartPriceCost.Text) && int.TryParse(modifyPartPriceCost.Text, out int number))
            {
                modifyPartPriceCost.BackColor = Color.White;
            }
            else
            {
                modifyPartPriceCost.BackColor = Color.LightCoral;
            }

      
        }

        private void modifyPartMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartMin.Text) && int.TryParse(modifyPartMin.Text, out int number))
            {
                modifyPartMin.BackColor = Color.White;

            }
            else
            {
                modifyPartMin.BackColor = Color.LightCoral;
            }
        }

        private void modifyPartMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartMax.Text) && int.TryParse(modifyPartMax.Text, out int number))
            {
                modifyPartMax.BackColor = Color.White;

            }
            else
            {
                modifyPartMax.BackColor = Color.LightCoral;
            }

        }

        private void modifyPart_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartCompanyName.Text) && int.TryParse(ModifyPartInventory.Text, out int number))
            {
                ModifyPartInventory.BackColor = Color.White;

            }
            else
            {
                ModifyPartInventory.BackColor = Color.LightCoral;
            }

            if (
                modifyPartName.BackColor == Color.White &&
                ModifyPartInventory.BackColor == Color.White &&
                modifyPartPriceCost.BackColor == Color.White &&
                modifyPartMin.BackColor == Color.White &&
                modifyPartMax.BackColor == Color.White &&
                modifyPartCompanyName.BackColor == Color.White
                )
            {
                btn_ModPartSave.Enabled = true;
            }

          //  if (
          //modifyPartName.BackColor == Color.White &&
          //ModifyPartInventory.BackColor == Color.White &&
          //modifyPartPriceCost.BackColor == Color.White &&
          //modifyPartMin.BackColor == Color.White &&
          //modifyPartMax.BackColor == Color.White &&
          //modifyPartCompanyName.BackColor == Color.White
          //)
          //  {
          //      btn_ModPartSave.Enabled = true;
          //  }

        }
    }
}


       
    

