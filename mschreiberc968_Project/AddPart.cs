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
        

        private void button2_Click(object sender, EventArgs e)
        {
                        this.Hide();
            mainScreenView();
        }

        private void btn_Save(object sender, EventArgs e)
        {
            //check for min/max compliance
            if (int.Parse(addPartMin.Text) > int.Parse(addPartMax.Text))
            {
                MessageBox.Show("Minimum must be less than maximum");
                return;
            }


            //bind new information to the AllParts bindinglist from Inventory.cs


            this.Hide();
            mainScreenView();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_forRadioChoice.Text = "Company Name:";
        }

        private void rb_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_forRadioChoice.Text = "Machine Id:";
        }

        private void addPartID_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxForString(addPartID);
        }

        private void addPartName_TextChanged(object sender, EventArgs e)
        {
            if (addPartName.Text.Length > 1)
            {
            CheckTextBoxForString(addPartName);
           
            }
            else { addPartName.BackColor = Color.LightCoral; }
        }


        private void addPartInventory_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxForInt(addPartInventory);
        }
    }
    }



    

