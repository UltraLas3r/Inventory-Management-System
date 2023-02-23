﻿
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
            this.btn_saveModifyPart = new System.Windows.Forms.Button();
            this.btn_closeModifyPart = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            // btn_saveModifyPart
            // 
            this.btn_saveModifyPart.Location = new System.Drawing.Point(320, 497);
            this.btn_saveModifyPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_saveModifyPart.Name = "btn_saveModifyPart";
            this.btn_saveModifyPart.Size = new System.Drawing.Size(112, 35);
            this.btn_saveModifyPart.TabIndex = 0;
            this.btn_saveModifyPart.Text = "Save";
            this.btn_saveModifyPart.UseVisualStyleBackColor = true;
            this.btn_saveModifyPart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_closeModifyPart
            // 
            this.btn_closeModifyPart.Location = new System.Drawing.Point(468, 497);
            this.btn_closeModifyPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_closeModifyPart.Name = "btn_closeModifyPart";
            this.btn_closeModifyPart.Size = new System.Drawing.Size(112, 35);
            this.btn_closeModifyPart.TabIndex = 1;
            this.btn_closeModifyPart.Text = "Cancel";
            this.btn_closeModifyPart.UseVisualStyleBackColor = true;
            this.btn_closeModifyPart.Click += new System.EventHandler(this.btn_closeModifyPart_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton1.Location = new System.Drawing.Point(186, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 33);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In-House";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton2.Location = new System.Drawing.Point(395, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(163, 33);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outsourced";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_modifyPartHeader
            // 
            this.lbl_modifyPartHeader.AutoSize = true;
            this.lbl_modifyPartHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_modifyPartHeader.Location = new System.Drawing.Point(24, 22);
            this.lbl_modifyPartHeader.Name = "lbl_modifyPartHeader";
            this.lbl_modifyPartHeader.Size = new System.Drawing.Size(133, 29);
            this.lbl_modifyPartHeader.TabIndex = 4;
            this.lbl_modifyPartHeader.Text = "Modify Part";
            // 
            // lbl_forIDTextBox
            // 
            this.lbl_forIDTextBox.AutoSize = true;
            this.lbl_forIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forIDTextBox.Location = new System.Drawing.Point(24, 122);
            this.lbl_forIDTextBox.Name = "lbl_forIDTextBox";
            this.lbl_forIDTextBox.Size = new System.Drawing.Size(36, 29);
            this.lbl_forIDTextBox.TabIndex = 5;
            this.lbl_forIDTextBox.Text = "ID";
            // 
            // lvl_forNameTextBox
            // 
            this.lvl_forNameTextBox.AutoSize = true;
            this.lvl_forNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvl_forNameTextBox.Location = new System.Drawing.Point(24, 179);
            this.lvl_forNameTextBox.Name = "lvl_forNameTextBox";
            this.lvl_forNameTextBox.Size = new System.Drawing.Size(78, 29);
            this.lvl_forNameTextBox.TabIndex = 6;
            this.lvl_forNameTextBox.Text = "Name";
            // 
            // lbl_forInventoryTextBox
            // 
            this.lbl_forInventoryTextBox.AutoSize = true;
            this.lbl_forInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forInventoryTextBox.Location = new System.Drawing.Point(24, 234);
            this.lbl_forInventoryTextBox.Name = "lbl_forInventoryTextBox";
            this.lbl_forInventoryTextBox.Size = new System.Drawing.Size(109, 29);
            this.lbl_forInventoryTextBox.TabIndex = 7;
            this.lbl_forInventoryTextBox.Text = "Inventory";
            // 
            // lbl_ForPriceTextBox
            // 
            this.lbl_ForPriceTextBox.AutoSize = true;
            this.lbl_ForPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ForPriceTextBox.Location = new System.Drawing.Point(24, 287);
            this.lbl_ForPriceTextBox.Name = "lbl_ForPriceTextBox";
            this.lbl_ForPriceTextBox.Size = new System.Drawing.Size(137, 29);
            this.lbl_ForPriceTextBox.TabIndex = 8;
            this.lbl_ForPriceTextBox.Text = "Price / Cost";
            // 
            // lbl_forMaxTextBox
            // 
            this.lbl_forMaxTextBox.AutoSize = true;
            this.lbl_forMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forMaxTextBox.Location = new System.Drawing.Point(395, 352);
            this.lbl_forMaxTextBox.Name = "lbl_forMaxTextBox";
            this.lbl_forMaxTextBox.Size = new System.Drawing.Size(57, 29);
            this.lbl_forMaxTextBox.TabIndex = 9;
            this.lbl_forMaxTextBox.Text = "Max";
            // 
            // lbl_forMinTextBox
            // 
            this.lbl_forMinTextBox.AutoSize = true;
            this.lbl_forMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forMinTextBox.Location = new System.Drawing.Point(105, 355);
            this.lbl_forMinTextBox.Name = "lbl_forMinTextBox";
            this.lbl_forMinTextBox.Size = new System.Drawing.Size(52, 29);
            this.lbl_forMinTextBox.TabIndex = 10;
            this.lbl_forMinTextBox.Text = "Min";
            this.lbl_forMinTextBox.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_ForRadioChange
            // 
            this.lbl_ForRadioChange.AutoSize = true;
            this.lbl_ForRadioChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ForRadioChange.Location = new System.Drawing.Point(24, 429);
            this.lbl_ForRadioChange.Name = "lbl_ForRadioChange";
            this.lbl_ForRadioChange.Size = new System.Drawing.Size(186, 29);
            this.lbl_ForRadioChange.TabIndex = 11;
            this.lbl_ForRadioChange.Text = "Company Name";
            // 
            // modifyPartID
            // 
            this.modifyPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartID.Location = new System.Drawing.Point(186, 116);
            this.modifyPartID.Name = "modifyPartID";
            this.modifyPartID.Size = new System.Drawing.Size(394, 35);
            this.modifyPartID.TabIndex = 12;
            // 
            // modifyPartName
            // 
            this.modifyPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartName.Location = new System.Drawing.Point(186, 173);
            this.modifyPartName.Name = "modifyPartName";
            this.modifyPartName.Size = new System.Drawing.Size(394, 35);
            this.modifyPartName.TabIndex = 13;
            // 
            // modifyPartInventory
            // 
            this.modifyPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartInventory.Location = new System.Drawing.Point(186, 228);
            this.modifyPartInventory.Name = "modifyPartInventory";
            this.modifyPartInventory.Size = new System.Drawing.Size(394, 35);
            this.modifyPartInventory.TabIndex = 14;
            // 
            // modifyPartPriceCost
            // 
            this.modifyPartPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartPriceCost.Location = new System.Drawing.Point(186, 287);
            this.modifyPartPriceCost.Name = "modifyPartPriceCost";
            this.modifyPartPriceCost.Size = new System.Drawing.Size(394, 35);
            this.modifyPartPriceCost.TabIndex = 15;
            // 
            // modifyPartMin
            // 
            this.modifyPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartMin.Location = new System.Drawing.Point(186, 349);
            this.modifyPartMin.Name = "modifyPartMin";
            this.modifyPartMin.Size = new System.Drawing.Size(122, 35);
            this.modifyPartMin.TabIndex = 16;
            // 
            // modifyPartMax
            // 
            this.modifyPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartMax.Location = new System.Drawing.Point(458, 348);
            this.modifyPartMax.Name = "modifyPartMax";
            this.modifyPartMax.Size = new System.Drawing.Size(122, 35);
            this.modifyPartMax.TabIndex = 17;
            // 
            // modifyPartCompanyName
            // 
            this.modifyPartCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyPartCompanyName.Location = new System.Drawing.Point(250, 423);
            this.modifyPartCompanyName.Name = "modifyPartCompanyName";
            this.modifyPartCompanyName.Size = new System.Drawing.Size(330, 35);
            this.modifyPartCompanyName.TabIndex = 18;
            // 
            // modifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 568);
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
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_closeModifyPart);
            this.Controls.Add(this.btn_saveModifyPart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "modifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveModifyPart;
        private System.Windows.Forms.Button btn_closeModifyPart;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
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