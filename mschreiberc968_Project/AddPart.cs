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
        private int plusPartID;
        public AddPart()
        {
            InitializeComponent();
        }

        public AddPart(Part part, int PartID)
        {
            InitializeComponent();

            plusPartID = PartID;
            addPartID.Text = part.PartID.ToString();
            addPartName.Text = part.Name;
            addPartInventory.Text = part.InStock.ToString();
            addPartPriceCost.Text = part.Price.ToString();
            addPartMin.Text = part.Min.ToString();
            addPartMax.Text = part.Max.ToString();

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
            int currentInventory = Int32.Parse(addPartInventory.Text);
            if (int.Parse(addPartMin.Text) >= int.Parse(addPartMax.Text))
            {
                MessageBox.Show("Minimum must be less than maximum");
                return;
            };

            if (int.Parse(addPartMin.Text) >= currentInventory)
            {
                MessageBox.Show("The Minimum value cannot be greater than the Inventory value");
                return;
            }

            if (int.Parse(addPartMax.Text) >= currentInventory)
            {
                MessageBox.Show("The Maximum value must be greater than the Inventory value");
                return;
            }


            //create a new part by taking the text of the textboxes and saving them to a 
            //new part object and passing that into the bindinglist
            //if (rb_InHouse.Checked)
            //{
            //    Part newPartIH = new InHouse();
            //    {
            //        PartID = Int32.Parse(addPartID.Text),
            //        Name = addPartName.Text,
            //        InStock = Int32.Parse(addPartInventory.Text),
            //        Min = Int32.Parse(addPartmin.text),
            //        Max = Int32.Parse(addPartMax.Text),
            //        MachineID = Int32.Parse(addPartCompanyName.Text)
            //    }
            //    Inventory.AddPart(newPartIH);
            //};


            //else(rb_outsourced.Checked)
            //{
            //    //create new outsource item
            //};

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
   
    




    

