﻿using mschreiberc968_Project.Model;
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
            modifyPartName.Focus();
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

                OutSourced outSourced = part as OutSourced;
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

        private void RadioButtonCheck(object sender, EventArgs e)
        {
            if (RadioInHouse.Checked)
            {
                lbl_ForRadioChange.Text = "Machine ID #:";
                if (modifyPartCompanyName.Text.Length > 0)
                {
                    CheckTextBoxForInt(modifyPartCompanyName);
                }
            }

            if (RadioOutsource.Checked)
            {
                lbl_ForRadioChange.Text = "Company Name:";
                if (modifyPartCompanyName.Text.Length > 0)
                {
                    CheckTextBoxForString(modifyPartCompanyName);
                }
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
            MessageBox.Show("The Inventory value " + ModifyPartInventory.Text + " must be less than the Max value of" + modifyPartMax.Text);
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

            Part UpdatePartOS = new OutSourced()
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
        private void ModifyPartName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartName.Text) || int.TryParse(modifyPartName.Text, out int n))
            {
                btn_ModPartSave.Enabled = false;
                modifyPartName.BackColor = Color.LightCoral;
            }

            else
            {
                btn_ModPartSave.Enabled = true;
                modifyPartName.BackColor = Color.White;
            }
        }

        private void ModifyPartInventory_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(ModifyPartInventory.Text) || !(int.TryParse(ModifyPartInventory.Text, out int n)))
            {
                btn_ModPartSave.Enabled = false;
                ModifyPartInventory.BackColor = Color.LightCoral;

            }
            else
            {
                btn_ModPartSave.Enabled = true;
                ModifyPartInventory.BackColor = Color.White;
            }
        }

        private void modifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartPriceCost.Text) || !Double.TryParse(modifyPartPriceCost.Text, out double n))
            {
                btn_ModPartSave.Enabled = false;
                modifyPartPriceCost.BackColor = Color.LightCoral;
            }
            else
            {
                btn_ModPartSave.Enabled = true;
                modifyPartPriceCost.BackColor = Color.White;
            }
        }

        private void modifyPartMin_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(modifyPartMin.Text) || !int.TryParse(modifyPartMin.Text, out int n))
            {
                btn_ModPartSave.Enabled = false;
                modifyPartMin.BackColor = Color.LightCoral;
            }
            else
            {
                btn_ModPartSave.Enabled = true;
                modifyPartMin.BackColor = Color.White;
            }
            
        }

        private void modifyPartMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartMax.Text) || !int.TryParse(modifyPartMax.Text, out int n))
            {
                btn_ModPartSave.Enabled = false;
                modifyPartMax.BackColor = Color.LightCoral;
            }
            else
            {
                btn_ModPartSave.Enabled = true;
                modifyPartMax.BackColor = Color.White;
            }
        }

        private void ModifyPartCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (RadioInHouse.Checked)
            {
                if (modifyPartCompanyName.Text.Length > 0)
                {
                    CheckTextBoxForInt(modifyPartCompanyName);
                }
                else
                {
                    modifyPartCompanyName.BackColor = Color.LightCoral;
                }

            }

            if (RadioOutsource.Checked)
            {
                if (modifyPartCompanyName.Text.Length > 0)
                {
                    CheckTextBoxForString(modifyPartCompanyName);
                }
                else
                {
                    modifyPartCompanyName.BackColor = Color.LightCoral;
                }  
            }
        }

        public void CheckTextBoxForString(TextBox textBox)
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

            if (textBox.BackColor == Color.LightCoral)
            {
                btn_ModPartSave.Enabled = false;
            }

            else { btn_ModPartSave.Enabled = true; }
        }

        public void CheckTextBoxForInt(TextBox textBox)
        {
            //This can be called to check the textbox for INT values and will change the color depending on what exists.
            int number;
            bool isNumber = int.TryParse(textBox.Text, out number);

            if (!isNumber)
            {
                textBox.BackColor = Color.LightCoral;
            }
            else
            {
                textBox.BackColor = Color.White;
            }

            if (textBox.BackColor == Color.LightCoral)
            {
                btn_ModPartSave.Enabled = false;
            }

            else { btn_ModPartSave.Enabled = true; }
        }
    }
}


       
    

