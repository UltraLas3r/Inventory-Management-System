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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Hide();
            mainScreenView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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



    

