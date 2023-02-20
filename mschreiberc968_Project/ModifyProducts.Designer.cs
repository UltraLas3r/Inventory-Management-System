
namespace mschreiberc968_Project
{
    partial class ModifyProducts
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
            this.txt_modifyPartMax = new System.Windows.Forms.TextBox();
            this.txt_modifyPartMin = new System.Windows.Forms.TextBox();
            this.txt_modifyPartPriceCost = new System.Windows.Forms.TextBox();
            this.txt_modifyPartInventory = new System.Windows.Forms.TextBox();
            this.txt_modifyPartName = new System.Windows.Forms.TextBox();
            this.txt_modifyProductID = new System.Windows.Forms.TextBox();
            this.lbl_ModProductMin = new System.Windows.Forms.Label();
            this.lbl_ModProductMax = new System.Windows.Forms.Label();
            this.lbl_ModProductPrice = new System.Windows.Forms.Label();
            this.lbl_ModProductInventory = new System.Windows.Forms.Label();
            this.lbl_ModProductName = new System.Windows.Forms.Label();
            this.lbl_ModProductID = new System.Windows.Forms.Label();
            this.lbl_ModProductMain = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_AssociatedModParts = new System.Windows.Forms.Label();
            this.dgv_AllModParts = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_AddModParts = new System.Windows.Forms.Button();
            this.btn_DeleteModParts = new System.Windows.Forms.Button();
            this.btn_ModProductSave = new System.Windows.Forms.Button();
            this.btn_ModProductCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllModParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_modifyPartMax
            // 
            this.txt_modifyPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modifyPartMax.Location = new System.Drawing.Point(444, 333);
            this.txt_modifyPartMax.Name = "txt_modifyPartMax";
            this.txt_modifyPartMax.Size = new System.Drawing.Size(122, 35);
            this.txt_modifyPartMax.TabIndex = 30;
            this.txt_modifyPartMax.TextChanged += new System.EventHandler(this.modifyPartMax_TextChanged);
            // 
            // txt_modifyPartMin
            // 
            this.txt_modifyPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modifyPartMin.Location = new System.Drawing.Point(172, 334);
            this.txt_modifyPartMin.Name = "txt_modifyPartMin";
            this.txt_modifyPartMin.Size = new System.Drawing.Size(122, 35);
            this.txt_modifyPartMin.TabIndex = 29;
            this.txt_modifyPartMin.TextChanged += new System.EventHandler(this.modifyPartMin_TextChanged);
            // 
            // txt_modifyPartPriceCost
            // 
            this.txt_modifyPartPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modifyPartPriceCost.Location = new System.Drawing.Point(172, 272);
            this.txt_modifyPartPriceCost.Name = "txt_modifyPartPriceCost";
            this.txt_modifyPartPriceCost.Size = new System.Drawing.Size(394, 35);
            this.txt_modifyPartPriceCost.TabIndex = 28;
            this.txt_modifyPartPriceCost.TextChanged += new System.EventHandler(this.modifyPartPriceCost_TextChanged);
            // 
            // txt_modifyPartInventory
            // 
            this.txt_modifyPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modifyPartInventory.Location = new System.Drawing.Point(172, 213);
            this.txt_modifyPartInventory.Name = "txt_modifyPartInventory";
            this.txt_modifyPartInventory.Size = new System.Drawing.Size(394, 35);
            this.txt_modifyPartInventory.TabIndex = 27;
            this.txt_modifyPartInventory.TextChanged += new System.EventHandler(this.modifyPartInventory_TextChanged);
            // 
            // txt_modifyPartName
            // 
            this.txt_modifyPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modifyPartName.Location = new System.Drawing.Point(172, 158);
            this.txt_modifyPartName.Name = "txt_modifyPartName";
            this.txt_modifyPartName.Size = new System.Drawing.Size(394, 35);
            this.txt_modifyPartName.TabIndex = 26;
            this.txt_modifyPartName.TextChanged += new System.EventHandler(this.modifyPartName_TextChanged);
            // 
            // txt_modifyProductID
            // 
            this.txt_modifyProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modifyProductID.Location = new System.Drawing.Point(172, 111);
            this.txt_modifyProductID.Name = "txt_modifyProductID";
            this.txt_modifyProductID.Size = new System.Drawing.Size(394, 35);
            this.txt_modifyProductID.TabIndex = 25;
            this.txt_modifyProductID.TextChanged += new System.EventHandler(this.modifyProductsID_TextChanged);
            // 
            // lbl_ModProductMin
            // 
            this.lbl_ModProductMin.AutoSize = true;
            this.lbl_ModProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductMin.Location = new System.Drawing.Point(95, 330);
            this.lbl_ModProductMin.Name = "lbl_ModProductMin";
            this.lbl_ModProductMin.Size = new System.Drawing.Size(52, 29);
            this.lbl_ModProductMin.TabIndex = 24;
            this.lbl_ModProductMin.Text = "Min";
            this.lbl_ModProductMin.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_ModProductMax
            // 
            this.lbl_ModProductMax.AutoSize = true;
            this.lbl_ModProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductMax.Location = new System.Drawing.Point(376, 333);
            this.lbl_ModProductMax.Name = "lbl_ModProductMax";
            this.lbl_ModProductMax.Size = new System.Drawing.Size(57, 29);
            this.lbl_ModProductMax.TabIndex = 23;
            this.lbl_ModProductMax.Text = "Max";
            this.lbl_ModProductMax.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_ModProductPrice
            // 
            this.lbl_ModProductPrice.AutoSize = true;
            this.lbl_ModProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductPrice.Location = new System.Drawing.Point(10, 269);
            this.lbl_ModProductPrice.Name = "lbl_ModProductPrice";
            this.lbl_ModProductPrice.Size = new System.Drawing.Size(137, 29);
            this.lbl_ModProductPrice.TabIndex = 22;
            this.lbl_ModProductPrice.Text = "Price / Cost";
            this.lbl_ModProductPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_ModProductInventory
            // 
            this.lbl_ModProductInventory.AutoSize = true;
            this.lbl_ModProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductInventory.Location = new System.Drawing.Point(10, 213);
            this.lbl_ModProductInventory.Name = "lbl_ModProductInventory";
            this.lbl_ModProductInventory.Size = new System.Drawing.Size(109, 29);
            this.lbl_ModProductInventory.TabIndex = 21;
            this.lbl_ModProductInventory.Text = "Inventory";
            this.lbl_ModProductInventory.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_ModProductName
            // 
            this.lbl_ModProductName.AutoSize = true;
            this.lbl_ModProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductName.Location = new System.Drawing.Point(10, 155);
            this.lbl_ModProductName.Name = "lbl_ModProductName";
            this.lbl_ModProductName.Size = new System.Drawing.Size(78, 29);
            this.lbl_ModProductName.TabIndex = 20;
            this.lbl_ModProductName.Text = "Name";
            this.lbl_ModProductName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_ModProductID
            // 
            this.lbl_ModProductID.AutoSize = true;
            this.lbl_ModProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductID.Location = new System.Drawing.Point(15, 107);
            this.lbl_ModProductID.Name = "lbl_ModProductID";
            this.lbl_ModProductID.Size = new System.Drawing.Size(36, 29);
            this.lbl_ModProductID.TabIndex = 19;
            this.lbl_ModProductID.Text = "ID";
            this.lbl_ModProductID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_ModProductMain
            // 
            this.lbl_ModProductMain.AutoSize = true;
            this.lbl_ModProductMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductMain.Location = new System.Drawing.Point(17, 33);
            this.lbl_ModProductMain.Name = "lbl_ModProductMain";
            this.lbl_ModProductMain.Size = new System.Drawing.Size(173, 29);
            this.lbl_ModProductMain.TabIndex = 18;
            this.lbl_ModProductMain.Text = "Modify Product";
            this.lbl_ModProductMain.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(683, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "All Parts";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgv_AssociatedModParts
            // 
            this.dgv_AssociatedModParts.AutoSize = true;
            this.dgv_AssociatedModParts.Location = new System.Drawing.Point(683, 381);
            this.dgv_AssociatedModParts.Name = "dgv_AssociatedModParts";
            this.dgv_AssociatedModParts.Size = new System.Drawing.Size(249, 20);
            this.dgv_AssociatedModParts.TabIndex = 32;
            this.dgv_AssociatedModParts.Text = "Parts Associated with this Product";
            this.dgv_AssociatedModParts.Click += new System.EventHandler(this.label9_Click);
            // 
            // dgv_AllModParts
            // 
            this.dgv_AllModParts.AllowUserToDeleteRows = false;
            this.dgv_AllModParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllModParts.Location = new System.Drawing.Point(687, 107);
            this.dgv_AllModParts.Name = "dgv_AllModParts";
            this.dgv_AllModParts.RowHeadersWidth = 62;
            this.dgv_AllModParts.RowTemplate.Height = 28;
            this.dgv_AllModParts.Size = new System.Drawing.Size(669, 217);
            this.dgv_AllModParts.TabIndex = 33;
            this.dgv_AllModParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(687, 416);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(669, 217);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_AddModParts
            // 
            this.btn_AddModParts.Location = new System.Drawing.Point(1244, 337);
            this.btn_AddModParts.Name = "btn_AddModParts";
            this.btn_AddModParts.Size = new System.Drawing.Size(112, 35);
            this.btn_AddModParts.TabIndex = 35;
            this.btn_AddModParts.Text = "Add Parts";
            this.btn_AddModParts.UseVisualStyleBackColor = true;
            this.btn_AddModParts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_DeleteModParts
            // 
            this.btn_DeleteModParts.Location = new System.Drawing.Point(1244, 649);
            this.btn_DeleteModParts.Name = "btn_DeleteModParts";
            this.btn_DeleteModParts.Size = new System.Drawing.Size(112, 35);
            this.btn_DeleteModParts.TabIndex = 36;
            this.btn_DeleteModParts.Text = "Delete";
            this.btn_DeleteModParts.UseVisualStyleBackColor = true;
            this.btn_DeleteModParts.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ModProductSave
            // 
            this.btn_ModProductSave.Location = new System.Drawing.Point(1095, 713);
            this.btn_ModProductSave.Name = "btn_ModProductSave";
            this.btn_ModProductSave.Size = new System.Drawing.Size(112, 35);
            this.btn_ModProductSave.TabIndex = 37;
            this.btn_ModProductSave.Text = "Save";
            this.btn_ModProductSave.UseVisualStyleBackColor = true;
            this.btn_ModProductSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ModProductCancel
            // 
            this.btn_ModProductCancel.Location = new System.Drawing.Point(1244, 713);
            this.btn_ModProductCancel.Name = "btn_ModProductCancel";
            this.btn_ModProductCancel.Size = new System.Drawing.Size(112, 35);
            this.btn_ModProductCancel.TabIndex = 38;
            this.btn_ModProductCancel.Text = "Cancel";
            this.btn_ModProductCancel.UseVisualStyleBackColor = true;
            this.btn_ModProductCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // ModifyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 772);
            this.Controls.Add(this.btn_ModProductCancel);
            this.Controls.Add(this.btn_ModProductSave);
            this.Controls.Add(this.btn_DeleteModParts);
            this.Controls.Add(this.btn_AddModParts);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgv_AllModParts);
            this.Controls.Add(this.dgv_AssociatedModParts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_modifyPartMax);
            this.Controls.Add(this.txt_modifyPartMin);
            this.Controls.Add(this.txt_modifyPartPriceCost);
            this.Controls.Add(this.txt_modifyPartInventory);
            this.Controls.Add(this.txt_modifyPartName);
            this.Controls.Add(this.txt_modifyProductID);
            this.Controls.Add(this.lbl_ModProductMin);
            this.Controls.Add(this.lbl_ModProductMax);
            this.Controls.Add(this.lbl_ModProductPrice);
            this.Controls.Add(this.lbl_ModProductInventory);
            this.Controls.Add(this.lbl_ModProductName);
            this.Controls.Add(this.lbl_ModProductID);
            this.Controls.Add(this.lbl_ModProductMain);
            this.Name = "ModifyProducts";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllModParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_modifyPartMax;
        private System.Windows.Forms.TextBox txt_modifyPartMin;
        private System.Windows.Forms.TextBox txt_modifyPartPriceCost;
        private System.Windows.Forms.TextBox txt_modifyPartInventory;
        private System.Windows.Forms.TextBox txt_modifyPartName;
        private System.Windows.Forms.TextBox txt_modifyProductID;
        private System.Windows.Forms.Label lbl_ModProductMin;
        private System.Windows.Forms.Label lbl_ModProductMax;
        private System.Windows.Forms.Label lbl_ModProductPrice;
        private System.Windows.Forms.Label lbl_ModProductInventory;
        private System.Windows.Forms.Label lbl_ModProductName;
        private System.Windows.Forms.Label lbl_ModProductID;
        private System.Windows.Forms.Label lbl_ModProductMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dgv_AssociatedModParts;
        private System.Windows.Forms.DataGridView dgv_AllModParts;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_AddModParts;
        private System.Windows.Forms.Button btn_DeleteModParts;
        private System.Windows.Forms.Button btn_ModProductSave;
        private System.Windows.Forms.Button btn_ModProductCancel;
    }
}