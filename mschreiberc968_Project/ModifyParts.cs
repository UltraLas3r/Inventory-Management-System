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
    public partial class modifyPart : Form
    {
        public modifyPart()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //On Click take the textbox objects from this form and send them to the DGV into the appropriate cell spaces

            this.Hide();
            mainScreenView();
        }
    }
}
