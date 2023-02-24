
namespace mschreiberc968_Project
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_forRadioChoice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPartCompanyName = new System.Windows.Forms.TextBox();
            this.addPartMax = new System.Windows.Forms.TextBox();
            this.addPartMin = new System.Windows.Forms.TextBox();
            this.addPartPriceCost = new System.Windows.Forms.TextBox();
            this.addPartInventory = new System.Windows.Forms.TextBox();
            this.addPartName = new System.Windows.Forms.TextBox();
            this.addPartID = new System.Windows.Forms.TextBox();
            this.rb_outsourced = new System.Windows.Forms.RadioButton();
            this.rb_InHouse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(464, 504);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 35);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(315, 504);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 35);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_forRadioChoice
            // 
            this.lbl_forRadioChoice.AutoSize = true;
            this.lbl_forRadioChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forRadioChoice.Location = new System.Drawing.Point(27, 429);
            this.lbl_forRadioChoice.Name = "lbl_forRadioChoice";
            this.lbl_forRadioChoice.Size = new System.Drawing.Size(186, 29);
            this.lbl_forRadioChoice.TabIndex = 19;
            this.lbl_forRadioChoice.Text = "Company Name";
            this.lbl_forRadioChoice.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(107, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Min";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(388, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(22, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price / Cost";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(22, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Inventory";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Part";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addPartCompanyName
            // 
            this.addPartCompanyName.BackColor = System.Drawing.Color.LightCoral;
            this.addPartCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPartCompanyName.Location = new System.Drawing.Point(219, 422);
            this.addPartCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartCompanyName.MaxLength = 100;
            this.addPartCompanyName.Name = "addPartCompanyName";
            this.addPartCompanyName.Size = new System.Drawing.Size(360, 35);
            this.addPartCompanyName.TabIndex = 28;
            // 
            // addPartMax
            // 
            this.addPartMax.BackColor = System.Drawing.Color.LightCoral;
            this.addPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPartMax.Location = new System.Drawing.Point(453, 340);
            this.addPartMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartMax.MaxLength = 4;
            this.addPartMax.Name = "addPartMax";
            this.addPartMax.Size = new System.Drawing.Size(122, 35);
            this.addPartMax.TabIndex = 27;
            // 
            // addPartMin
            // 
            this.addPartMin.BackColor = System.Drawing.Color.LightCoral;
            this.addPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPartMin.Location = new System.Drawing.Point(181, 341);
            this.addPartMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartMin.MaxLength = 4;
            this.addPartMin.Name = "addPartMin";
            this.addPartMin.Size = new System.Drawing.Size(122, 35);
            this.addPartMin.TabIndex = 26;
            // 
            // addPartPriceCost
            // 
            this.addPartPriceCost.BackColor = System.Drawing.Color.LightCoral;
            this.addPartPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPartPriceCost.Location = new System.Drawing.Point(181, 279);
            this.addPartPriceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartPriceCost.Name = "addPartPriceCost";
            this.addPartPriceCost.Size = new System.Drawing.Size(394, 35);
            this.addPartPriceCost.TabIndex = 25;
            // 
            // addPartInventory
            // 
            this.addPartInventory.BackColor = System.Drawing.Color.LightCoral;
            this.addPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPartInventory.Location = new System.Drawing.Point(181, 220);
            this.addPartInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartInventory.MaxLength = 4;
            this.addPartInventory.Name = "addPartInventory";
            this.addPartInventory.Size = new System.Drawing.Size(394, 35);
            this.addPartInventory.TabIndex = 24;
            this.addPartInventory.TextChanged += new System.EventHandler(this.addPartInventory_TextChanged);
            // 
            // addPartName
            // 
            this.addPartName.BackColor = System.Drawing.Color.LightCoral;
            this.addPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPartName.Location = new System.Drawing.Point(181, 165);
            this.addPartName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartName.MaxLength = 100;
            this.addPartName.Name = "addPartName";
            this.addPartName.Size = new System.Drawing.Size(394, 35);
            this.addPartName.TabIndex = 23;
            this.addPartName.TextChanged += new System.EventHandler(this.addPartName_TextChanged);
            // 
            // addPartID
            // 
            this.addPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPartID.Location = new System.Drawing.Point(181, 118);
            this.addPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPartID.MaxLength = 4;
            this.addPartID.Name = "addPartID";
            this.addPartID.Size = new System.Drawing.Size(394, 35);
            this.addPartID.TabIndex = 22;
            this.addPartID.TextChanged += new System.EventHandler(this.addPartID_TextChanged);
            // 
            // rb_outsourced
            // 
            this.rb_outsourced.AutoSize = true;
            this.rb_outsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_outsourced.Location = new System.Drawing.Point(390, 58);
            this.rb_outsourced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_outsourced.Name = "rb_outsourced";
            this.rb_outsourced.Size = new System.Drawing.Size(163, 33);
            this.rb_outsourced.TabIndex = 21;
            this.rb_outsourced.TabStop = true;
            this.rb_outsourced.Text = "Outsourced";
            this.rb_outsourced.UseVisualStyleBackColor = true;
            this.rb_outsourced.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_InHouse
            // 
            this.rb_InHouse.AutoSize = true;
            this.rb_InHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_InHouse.Location = new System.Drawing.Point(181, 58);
            this.rb_InHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_InHouse.Name = "rb_InHouse";
            this.rb_InHouse.Size = new System.Drawing.Size(135, 33);
            this.rb_InHouse.TabIndex = 20;
            this.rb_InHouse.TabStop = true;
            this.rb_InHouse.Text = "In-House";
            this.rb_InHouse.UseVisualStyleBackColor = true;
            this.rb_InHouse.CheckedChanged += new System.EventHandler(this.rb_InHouse_CheckedChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 568);
            this.Controls.Add(this.addPartCompanyName);
            this.Controls.Add(this.addPartMax);
            this.Controls.Add(this.addPartMin);
            this.Controls.Add(this.addPartPriceCost);
            this.Controls.Add(this.addPartInventory);
            this.Controls.Add(this.addPartName);
            this.Controls.Add(this.addPartID);
            this.Controls.Add(this.rb_outsourced);
            this.Controls.Add(this.rb_InHouse);
            this.Controls.Add(this.lbl_forRadioChoice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_forRadioChoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addPartCompanyName;
        private System.Windows.Forms.TextBox addPartMax;
        private System.Windows.Forms.TextBox addPartMin;
        private System.Windows.Forms.TextBox addPartPriceCost;
        private System.Windows.Forms.TextBox addPartInventory;
        private System.Windows.Forms.TextBox addPartName;
        private System.Windows.Forms.TextBox addPartID;
        private System.Windows.Forms.RadioButton rb_outsourced;
        private System.Windows.Forms.RadioButton rb_InHouse;
    }
}