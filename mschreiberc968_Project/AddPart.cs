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


    private void CancelButtonClick(object sender, EventArgs e)
    {
        this.Hide();
        mainScreenView();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        lbl_forRadioChoice.Text = "Company Name";
    }

    private void rb_InHouse_CheckedChanged(object sender, EventArgs e)
    {
        lbl_forRadioChoice.Text = "Machine ID";
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

            if (int.Parse(addPartMax.Text) <= currentInventory)
            {
                MessageBox.Show("The Maximum value must be greater than the Inventory value of " + currentInventory);
                return;
            }

            //create a new part by taking the text of the textboxes and saving them to a 
            //new part object and passing that into the bindinglist

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
                OutSource newPartOS = new OutSource();

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
    }
}
   
    




    

