using System;
using mschreiberc968_Project.Model;
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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        public object mainScreenView()
        {
            MainScreen mainScreen = new MainScreen();
            return (mainScreen.Visible = true);
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            mainScreenView();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_forRadioChoice.Text = "Company Name";
            if (addPartCompanyName.Text.Length > 0)
            {
                CheckTextBoxForString(addPartCompanyName);
            }
        }

        private void rb_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_forRadioChoice.Text = "Machine ID";
            if (addPartCompanyName.Text.Length > 0)
            {
                CheckTextBoxForInt(addPartCompanyName);
            }
        }

        private void addPartID_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxForString(addPartID);
        }

        private void addPartName_TextChanged(object sender, EventArgs e)
        {
            if (addPartName.Text.Length > 0)
            {
                CheckTextBoxForString(addPartName);
            }
            else { addPartName.BackColor = Color.LightCoral; }

            if (addPartName.BackColor == Color.LightCoral)
            {
                btn_Save.Enabled = false;
            }
            else btn_Save.Enabled = true; 
        }


        private void addPartInventory_TextChanged(object sender, EventArgs e)
        {
            if (addPartInventory.Text.Length > 0)
                CheckTextBoxForInt(addPartInventory);

            else
            {
                addPartInventory.BackColor = Color.LightCoral;
            }

            if (addPartInventory.BackColor == Color.LightCoral)
            {
                btn_Save.Enabled = false;
            }

            else btn_Save.Enabled = true;
            
        }
        private void addPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addPartPriceCost.Text) || !Double.TryParse(addPartPriceCost.Text, out double n))
            {
                btn_Save.Enabled = false;
                addPartPriceCost.BackColor = Color.LightCoral;
            }

            else
            {
                btn_Save.Enabled = true;
                addPartPriceCost.BackColor = Color.White;
            }
        }


        private void addPartMin_TextChanged(object sender, EventArgs e)
        {
            if (addPartMin.Text.Length > 0)
                CheckTextBoxForInt(addPartMin);

            else
            {
                addPartMin.BackColor = Color.LightCoral;
            }

            if (addPartMin.BackColor == Color.LightCoral)
            {
                btn_Save.Enabled = false;
            }
            else btn_Save.Enabled = true;
           
        }


        private void addPartMax_TextChanged(object sender, EventArgs e)
        {
            if (addPartMax.Text.Length > 0)
            {
                CheckTextBoxForInt(addPartMax);
            }

            else
            {
                addPartMax.BackColor = Color.LightCoral;
            }

            if (addPartMax.BackColor == Color.LightCoral)
            {
                btn_Save.Enabled = false;
            }
            else btn_Save.Enabled = true;
            
        }

        private void addPartCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (rb_InHouse.Checked)
            {
                if (addPartCompanyName.Text.Length > 0)
                {
                    CheckTextBoxForInt(addPartCompanyName);
                }
                else
                {
                    addPartCompanyName.BackColor = Color.LightCoral;
                }

                if (addPartCompanyName.BackColor == Color.LightCoral)
                {
                    btn_Save.Enabled = false;
                }
                else   
                    btn_Save.Enabled = true;
            }

            if (rb_outsourced.Checked)
            {
                if (addPartCompanyName.Text.Length > 0)
                {
                    CheckTextBoxForString(addPartCompanyName);
                }
                else
                {
                    addPartCompanyName.BackColor = Color.LightCoral;
                }

                if (addPartCompanyName.BackColor == Color.LightCoral)
                {
                    btn_Save.Enabled = false;
                }
                else
                    btn_Save.Enabled = true;
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int currentInventory = Int32.Parse(addPartInventory.Text);

            //check for min/max compliance
            if (int.Parse(addPartMin.Text) >= int.Parse(addPartMax.Text))
            {
                MessageBox.Show("Minimum must be less than maximum");
                return;
            };

            if (int.Parse(addPartMin.Text) >= currentInventory)
            {
                MessageBox.Show("The Minimum value cannot be greater than the Inventory value of " + currentInventory);
                return;
            }


            //random number for PartID
            Random rnd = new Random();
            int num = rnd.Next(1000);

            if (rb_InHouse.Checked)
            {
                //take the textbox values and assign them to a new part
                InHouse newPartIH = new InHouse();

                newPartIH.PartID = num;
                newPartIH.Name = addPartName.Text;
                newPartIH.InStock = int.Parse(addPartInventory.Text);
                newPartIH.Price = decimal.Parse(addPartPriceCost.Text);
                newPartIH.Min = int.Parse(addPartMin.Text);
                newPartIH.Max = int.Parse(addPartMax.Text);
                newPartIH.MachineID = int.Parse(addPartCompanyName.Text);

                Inventory.AllParts.Add(newPartIH);
            }

            else if (rb_outsourced.Checked)
            {
                OutSourced newPartOS = new OutSourced();

                newPartOS.PartID = num;
                newPartOS.Name = addPartName.Text;
                newPartOS.InStock = int.Parse(addPartInventory.Text);
                newPartOS.Price = decimal.Parse(addPartPriceCost.Text);
                newPartOS.Min = int.Parse(addPartMin.Text);
                newPartOS.Max = int.Parse(addPartMax.Text);
                newPartOS.CompanyName = addPartCompanyName.Text;

                Inventory.AddPart(newPartOS);
            }

            this.Hide();
            mainScreenView();
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
        }

    }

}
   
    




    

