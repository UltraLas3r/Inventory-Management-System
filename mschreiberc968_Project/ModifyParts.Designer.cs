
namespace mschreiberc968_Project
{
    partial class modifyPart
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
            this.btn_ModPartSave = new System.Windows.Forms.Button();
            this.btn_closeModifyPart = new System.Windows.Forms.Button();
            this.RadioInHouse = new System.Windows.Forms.RadioButton();
            this.RadioOutsource = new System.Windows.Forms.RadioButton();
            this.lbl_modifyPartHeader = new System.Windows.Forms.Label();
            this.lbl_forIDTextBox = new System.Windows.Forms.Label();
            this.lvl_forNameTextBox = new System.Windows.Forms.Label();
            this.lbl_forInventoryTextBox = new System.Windows.Forms.Label();
            this.lbl_ForPriceTextBox = new System.Windows.Forms.Label();
            this.lbl_forMaxTextBox = new System.Windows.Forms.Label();
            this.lbl_forMinTextBox = new System.Windows.Forms.Label();
            this.lbl_ForRadioChange = new System.Windows.Forms.Label();
            this.modifyPartID = new System.Windows.Forms.TextBox();
            this.modifyPartName = new System.Windows.Forms.TextBox();
            this.modifyPartInventory = new System.Windows.Forms.TextBox();
            this.modifyPartPriceCost = new System.Windows.Forms.TextBox();
            this.modifyPartMin = new System.Windows.Forms.TextBox();
            this.modifyPartMax = new System.Windows.Forms.TextBox();
            this.modifyPartCompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ModPartSave
            // 
            this.btn_ModPartSave.Location = new System.Drawing.Point(277, 398);
            this.btn_ModPartSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ModPartSave.Name = "btn_ModPartSave";
            this.btn_ModPartSave.Size = new System.Drawing.Size(100, 28);
            this.btn_ModPartSave.TabIndex = 0;
            this.btn_ModPartSave.Text = "Save";
            this.btn_ModPartSave.UseVisualStyleBackColor = true;
            this.btn_ModPartSave.Click += new System.EventHandler(this.btn_Save);
            // 
            // btn_closeModifyPart
            // 
            this.btn_closeModifyPart.Location = new System.Drawing.Point(416, 398);
            this.btn_closeModifyPart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_closeModifyPart.Name = "btn_closeModifyPart";
            this.btn_closeModifyPart.Size = new System.Drawing.Size(100, 28);
            this.btn_closeModifyPart.TabIndex = 1;
            this.btn_closeModifyPart.Text = "Cancel";
            this.btn_closeModifyPart.UseVisualStyleBackColor = true;
            this.btn_closeModifyPart.Click += new System.EventHandler(this.btn_closeModifyPart_Click);
            // 
            // RadioInHouse
            // 
            this.RadioInHouse.AutoSize = true;
            this.RadioInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RadioInHouse.Location = new System.Drawing.Point(165, 41);
            this.RadioInHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioInHouse.Name = "RadioInHouse";
            this.RadioInHouse.Size = new System.Drawing.Size(113, 29);
            this.RadioInHouse.TabIndex = 2;
            this.RadioInHouse.TabStop = true;
            this.RadioInHouse.Text = "In-House";
            this.RadioInHouse.UseVisualStyleBackColor = true;
            this.RadioInHouse.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioOutsource
            // 
            this.RadioOutsource.AutoSize = true;
            this.RadioOutsource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RadioOutsource.Location = new System.Drawing.Point(351, 41);
            this.RadioOutsource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioOutsource.Name = "RadioOutsource";
            this.RadioOutsource.Size = new System.Drawing.Size(135, 29);
            this.RadioOutsource.TabIndex = 3;
            this.RadioOutsource.TabStop = true;
            this.RadioOutsource.Text = "Outsourced";
            this.RadioOutsource.UseVisualStyleBackColor = true;
            this.RadioOutsource.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_modifyPartHeader
            // 
            this.lbl_modifyPartHeader.AutoSize = true;
            this.lbl_modifyPartHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_modifyPartHeader.Location = new System.Drawing.Point(21, 18);
            this.lbl_modifyPartHeader.Name = "lbl_modifyPartHeader";
            this.lbl_modifyPartHeader.Size = new System.Drawing.Size(110, 25);
            this.lbl_modifyPartHeader.TabIndex = 4;
            this.lbl_modifyPartHeader.Text = "Modify Part";
            // 
            // lbl_forIDTextBox
            // 
            this.lbl_forIDTextBox.AutoSize = true;
            this.lbl_forIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forIDTextBox.Location = new System.Drawing.Point(21, 98);
            this.lbl_forIDTextBox.Name = "lbl_forIDTextBox";
            this.lbl_forIDTextBox.Size = new System.Drawing.Size(31, 25);
            this.lbl_forIDTextBox.TabIndex = 5;
            this.lbl_forIDTextBox.Text = "ID";
            // 
            // lvl_forNameTextBox
            // 
            this.lvl_forNameTextBox.AutoSize = true;
            this.lvl_forNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvl_forNameTextBox.Location = new System.Drawing.Point(21, 143);
            this.lvl_forNameTextBox.Name = "lvl_forNameTextBox";
            this.lvl_forNameTextBox.Size = new System.Drawing.Size(64, 25);
            this.lvl_forNameTextBox.TabIndex = 6;
            this.lvl_forNameTextBox.Text = "Name";
            // 
            // lbl_forInventoryTextBox
            // 
            this.lbl_forInventoryTextBox.AutoSize = true;
            this.lbl_forInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forInventoryTextBox.Location = new System.Drawing.Point(21, 187);
            this.lbl_forInventoryTextBox.Name = "lbl_forInventoryTextBox";
            this.lbl_forInventoryTextBox.Size = new System.Drawing.Size(92, 25);
            this.lbl_forInventoryTextBox.TabIndex = 7;
            this.lbl_forInventoryTextBox.Text = "Inventory";
            // 
            // lbl_ForPriceTextBox
            // 
            this.lbl_ForPriceTextBox.AutoSize = true;
            this.lbl_ForPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ForPriceTextBox.Location = new System.Drawing.Point(21, 230);
            this.lbl_ForPriceTextBox.Name = "lbl_ForPriceTextBox";
            this.lbl_ForPriceTextBox.Size = new System.Drawing.Size(113, 25);
            this.lbl_ForPriceTextBox.TabIndex = 8;
            this.lbl_ForPriceTextBox.Text = "Price / Cost";
            // 
            // lbl_forMaxTextBox
            // 
            this.lbl_forMaxTextBox.AutoSize = true;
            this.lbl_forMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forMaxTextBox.Location = new System.Drawing.Point(351, 282);
            this.lbl_forMaxTextBox.Name = "lbl_forMaxTextBox";
            this.lbl_forMaxTextBox.Size = new System.Drawing.Size(50, 25);
            this.lbl_forMaxTextBox.TabIndex = 9;
            this.lbl_forMaxTextBox.Text = "Max";
            // 
            // lbl_forMinTextBox
            // 
            this.lbl_forMinTextBox.AutoSize = true;
            this.lbl_forMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forMinTextBox.Location = new System.Drawing.Point(93, 284);
            this.lbl_forMinTextBox.Name = "lbl_forMinTextBox";
            this.lbl_forMinTextBox.Size = new System.Drawing.Size(44, 25);
            this.lbl_forMinTextBox.TabIndex = 10;
            this.lbl_forMinTextBox.Text = "Min";
            this.lbl_forMinTextBox.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_ForRadioChange
            // 
            this.lbl_ForRadioChange.AutoSize = true;
            this.lbl_ForRadioChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ForRadioChange.Location = new System.Drawing.Point(21, 343);
            this.lbl_ForRadioChange.Name = "lbl_ForRadioChange";
            this.lbl_ForRadioChange.Size = new System.Drawing.Size(154, 25);
            this.lbl_ForRadioChange.TabIndex = 11;
            this.lbl_ForRadioChange.Text = "Company Name";
            // 
            // modifyPartID
            // 
            this.modifyPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartID.Location = new System.Drawing.Point(165, 93);
            this.modifyPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartID.Name = "modifyPartID";
            this.modifyPartID.ReadOnly = true;
            this.modifyPartID.Size = new System.Drawing.Size(351, 30);
            this.modifyPartID.TabIndex = 12;
            // 
            // modifyPartName
            // 
            this.modifyPartName.BackColor = System.Drawing.Color.LightCoral;
            this.modifyPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartName.Location = new System.Drawing.Point(165, 138);
            this.modifyPartName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartName.Name = "modifyPartName";
            this.modifyPartName.Size = new System.Drawing.Size(351, 30);
            this.modifyPartName.TabIndex = 13;
            // 
            // modifyPartInventory
            // 
            this.modifyPartInventory.BackColor = System.Drawing.Color.LightCoral;
            this.modifyPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartInventory.Location = new System.Drawing.Point(165, 182);
            this.modifyPartInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartInventory.Name = "modifyPartInventory";
            this.modifyPartInventory.Size = new System.Drawing.Size(351, 30);
            this.modifyPartInventory.TabIndex = 14;
            // 
            // modifyPartPriceCost
            // 
            this.modifyPartPriceCost.BackColor = System.Drawing.Color.LightCoral;
            this.modifyPartPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartPriceCost.Location = new System.Drawing.Point(165, 230);
            this.modifyPartPriceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartPriceCost.Name = "modifyPartPriceCost";
            this.modifyPartPriceCost.Size = new System.Drawing.Size(351, 30);
            this.modifyPartPriceCost.TabIndex = 15;
            // 
            // modifyPartMin
            // 
            this.modifyPartMin.BackColor = System.Drawing.Color.LightCoral;
            this.modifyPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartMin.Location = new System.Drawing.Point(165, 279);
            this.modifyPartMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartMin.Name = "modifyPartMin";
            this.modifyPartMin.Size = new System.Drawing.Size(109, 30);
            this.modifyPartMin.TabIndex = 16;
            // 
            // modifyPartMax
            // 
            this.modifyPartMax.BackColor = System.Drawing.Color.LightCoral;
            this.modifyPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartMax.Location = new System.Drawing.Point(407, 278);
            this.modifyPartMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartMax.Name = "modifyPartMax";
            this.modifyPartMax.Size = new System.Drawing.Size(109, 30);
            this.modifyPartMax.TabIndex = 17;
            // 
            // modifyPartCompanyName
            // 
            this.modifyPartCompanyName.BackColor = System.Drawing.Color.LightCoral;
            this.modifyPartCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartCompanyName.Location = new System.Drawing.Point(222, 338);
            this.modifyPartCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPartCompanyName.Name = "modifyPartCompanyName";
            this.modifyPartCompanyName.Size = new System.Drawing.Size(294, 30);
            this.modifyPartCompanyName.TabIndex = 18;
            // 
            // modifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 454);
            this.Controls.Add(this.modifyPartCompanyName);
            this.Controls.Add(this.modifyPartMax);
            this.Controls.Add(this.modifyPartMin);
            this.Controls.Add(this.modifyPartPriceCost);
            this.Controls.Add(this.modifyPartInventory);
            this.Controls.Add(this.modifyPartName);
            this.Controls.Add(this.modifyPartID);
            this.Controls.Add(this.lbl_ForRadioChange);
            this.Controls.Add(this.lbl_forMinTextBox);
            this.Controls.Add(this.lbl_forMaxTextBox);
            this.Controls.Add(this.lbl_ForPriceTextBox);
            this.Controls.Add(this.lbl_forInventoryTextBox);
            this.Controls.Add(this.lvl_forNameTextBox);
            this.Controls.Add(this.lbl_forIDTextBox);
            this.Controls.Add(this.lbl_modifyPartHeader);
            this.Controls.Add(this.RadioOutsource);
            this.Controls.Add(this.RadioInHouse);
            this.Controls.Add(this.btn_closeModifyPart);
            this.Controls.Add(this.btn_ModPartSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "modifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ModPartSave;
        private System.Windows.Forms.Button btn_closeModifyPart;
        private System.Windows.Forms.RadioButton RadioInHouse;
        private System.Windows.Forms.RadioButton RadioOutsource;
        private System.Windows.Forms.Label lbl_modifyPartHeader;
        private System.Windows.Forms.Label lbl_forIDTextBox;
        private System.Windows.Forms.Label lvl_forNameTextBox;
        private System.Windows.Forms.Label lbl_forInventoryTextBox;
        private System.Windows.Forms.Label lbl_ForPriceTextBox;
        private System.Windows.Forms.Label lbl_forMaxTextBox;
        private System.Windows.Forms.Label lbl_forMinTextBox;
        private System.Windows.Forms.Label lbl_ForRadioChange;
        private System.Windows.Forms.TextBox modifyPartID;
        private System.Windows.Forms.TextBox modifyPartName;
        private System.Windows.Forms.TextBox modifyPartInventory;
        private System.Windows.Forms.TextBox modifyPartPriceCost;
        private System.Windows.Forms.TextBox modifyPartMin;
        private System.Windows.Forms.TextBox modifyPartMax;
        private System.Windows.Forms.TextBox modifyPartCompanyName;
    }
}