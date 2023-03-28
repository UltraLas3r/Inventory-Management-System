
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
            this.txt_ModifyProductMax = new System.Windows.Forms.TextBox();
            this.txt_ModifyProductMin = new System.Windows.Forms.TextBox();
            this.txt_ModifyProductPriceCost = new System.Windows.Forms.TextBox();
            this.txt_ModifyProductInventory = new System.Windows.Forms.TextBox();
            this.txt_ModifyProductName = new System.Windows.Forms.TextBox();
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
            this.dgv_AllParts = new System.Windows.Forms.DataGridView();
            this.dgv_AssociatedProductParts = new System.Windows.Forms.DataGridView();
            this.btn_AddModParts = new System.Windows.Forms.Button();
            this.btn_DeleteModParts = new System.Windows.Forms.Button();
            this.btn_ModProductSave = new System.Windows.Forms.Button();
            this.btn_ModProductCancel = new System.Windows.Forms.Button();
            this.btn_ModProdSearch = new System.Windows.Forms.Button();
            this.txt_ModProdSearch = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssociatedProductParts)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ModifyProductMax
            // 
            this.txt_ModifyProductMax.BackColor = System.Drawing.Color.White;
            this.txt_ModifyProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ModifyProductMax.Location = new System.Drawing.Point(395, 266);
            this.txt_ModifyProductMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ModifyProductMax.Name = "txt_ModifyProductMax";
            this.txt_ModifyProductMax.Size = new System.Drawing.Size(109, 30);
            this.txt_ModifyProductMax.TabIndex = 30;
            this.txt_ModifyProductMax.TextChanged += new System.EventHandler(this.modifyProductMax_TextChanged);
            // 
            // txt_ModifyProductMin
            // 
            this.txt_ModifyProductMin.BackColor = System.Drawing.Color.White;
            this.txt_ModifyProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ModifyProductMin.Location = new System.Drawing.Point(153, 267);
            this.txt_ModifyProductMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ModifyProductMin.Name = "txt_ModifyProductMin";
            this.txt_ModifyProductMin.Size = new System.Drawing.Size(109, 30);
            this.txt_ModifyProductMin.TabIndex = 29;
            this.txt_ModifyProductMin.TextChanged += new System.EventHandler(this.modifyProductMin_TextChanged);
            // 
            // txt_ModifyProductPriceCost
            // 
            this.txt_ModifyProductPriceCost.BackColor = System.Drawing.Color.White;
            this.txt_ModifyProductPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ModifyProductPriceCost.Location = new System.Drawing.Point(153, 218);
            this.txt_ModifyProductPriceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ModifyProductPriceCost.Name = "txt_ModifyProductPriceCost";
            this.txt_ModifyProductPriceCost.Size = new System.Drawing.Size(351, 30);
            this.txt_ModifyProductPriceCost.TabIndex = 28;
            this.txt_ModifyProductPriceCost.TextChanged += new System.EventHandler(this.modifyProductPriceCost_TextChanged);
            // 
            // txt_ModifyProductInventory
            // 
            this.txt_ModifyProductInventory.BackColor = System.Drawing.Color.White;
            this.txt_ModifyProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ModifyProductInventory.Location = new System.Drawing.Point(153, 170);
            this.txt_ModifyProductInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ModifyProductInventory.Name = "txt_ModifyProductInventory";
            this.txt_ModifyProductInventory.Size = new System.Drawing.Size(351, 30);
            this.txt_ModifyProductInventory.TabIndex = 27;
            this.txt_ModifyProductInventory.TextChanged += new System.EventHandler(this.modifyProductInventory_TextChanged);
            // 
            // txt_ModifyProductName
            // 
            this.txt_ModifyProductName.BackColor = System.Drawing.Color.White;
            this.txt_ModifyProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ModifyProductName.Location = new System.Drawing.Point(153, 126);
            this.txt_ModifyProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ModifyProductName.Name = "txt_ModifyProductName";
            this.txt_ModifyProductName.Size = new System.Drawing.Size(351, 30);
            this.txt_ModifyProductName.TabIndex = 26;
            this.txt_ModifyProductName.TextChanged += new System.EventHandler(this.modifyProductName_TextChanged);
            // 
            // txt_modifyProductID
            // 
            this.txt_modifyProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modifyProductID.Location = new System.Drawing.Point(153, 83);
            this.txt_modifyProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_modifyProductID.Name = "txt_modifyProductID";
            this.txt_modifyProductID.ReadOnly = true;
            this.txt_modifyProductID.Size = new System.Drawing.Size(351, 30);
            this.txt_modifyProductID.TabIndex = 25;
            // 
            // lbl_ModProductMin
            // 
            this.lbl_ModProductMin.AutoSize = true;
            this.lbl_ModProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductMin.Location = new System.Drawing.Point(84, 264);
            this.lbl_ModProductMin.Name = "lbl_ModProductMin";
            this.lbl_ModProductMin.Size = new System.Drawing.Size(44, 25);
            this.lbl_ModProductMin.TabIndex = 24;
            this.lbl_ModProductMin.Text = "Min";
            // 
            // lbl_ModProductMax
            // 
            this.lbl_ModProductMax.AutoSize = true;
            this.lbl_ModProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductMax.Location = new System.Drawing.Point(334, 266);
            this.lbl_ModProductMax.Name = "lbl_ModProductMax";
            this.lbl_ModProductMax.Size = new System.Drawing.Size(50, 25);
            this.lbl_ModProductMax.TabIndex = 23;
            this.lbl_ModProductMax.Text = "Max";
            // 
            // lbl_ModProductPrice
            // 
            this.lbl_ModProductPrice.AutoSize = true;
            this.lbl_ModProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductPrice.Location = new System.Drawing.Point(9, 215);
            this.lbl_ModProductPrice.Name = "lbl_ModProductPrice";
            this.lbl_ModProductPrice.Size = new System.Drawing.Size(113, 25);
            this.lbl_ModProductPrice.TabIndex = 22;
            this.lbl_ModProductPrice.Text = "Price / Cost";
            // 
            // lbl_ModProductInventory
            // 
            this.lbl_ModProductInventory.AutoSize = true;
            this.lbl_ModProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductInventory.Location = new System.Drawing.Point(9, 170);
            this.lbl_ModProductInventory.Name = "lbl_ModProductInventory";
            this.lbl_ModProductInventory.Size = new System.Drawing.Size(92, 25);
            this.lbl_ModProductInventory.TabIndex = 21;
            this.lbl_ModProductInventory.Text = "Inventory";
            // 
            // lbl_ModProductName
            // 
            this.lbl_ModProductName.AutoSize = true;
            this.lbl_ModProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductName.Location = new System.Drawing.Point(9, 124);
            this.lbl_ModProductName.Name = "lbl_ModProductName";
            this.lbl_ModProductName.Size = new System.Drawing.Size(64, 25);
            this.lbl_ModProductName.TabIndex = 20;
            this.lbl_ModProductName.Text = "Name";
            // 
            // lbl_ModProductID
            // 
            this.lbl_ModProductID.AutoSize = true;
            this.lbl_ModProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductID.Location = new System.Drawing.Point(13, 86);
            this.lbl_ModProductID.Name = "lbl_ModProductID";
            this.lbl_ModProductID.Size = new System.Drawing.Size(31, 25);
            this.lbl_ModProductID.TabIndex = 19;
            this.lbl_ModProductID.Text = "ID";
            // 
            // lbl_ModProductMain
            // 
            this.lbl_ModProductMain.AutoSize = true;
            this.lbl_ModProductMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ModProductMain.Location = new System.Drawing.Point(15, 26);
            this.lbl_ModProductMain.Name = "lbl_ModProductMain";
            this.lbl_ModProductMain.Size = new System.Drawing.Size(142, 25);
            this.lbl_ModProductMain.TabIndex = 18;
            this.lbl_ModProductMain.Text = "Modify Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(607, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "All Parts";
            // 
            // dgv_AssociatedModParts
            // 
            this.dgv_AssociatedModParts.AutoSize = true;
            this.dgv_AssociatedModParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_AssociatedModParts.Location = new System.Drawing.Point(607, 296);
            this.dgv_AssociatedModParts.Name = "dgv_AssociatedModParts";
            this.dgv_AssociatedModParts.Size = new System.Drawing.Size(305, 25);
            this.dgv_AssociatedModParts.TabIndex = 32;
            this.dgv_AssociatedModParts.Text = "Parts Associated with this Product";
            // 
            // dgv_AllParts
            // 
            this.dgv_AllParts.AllowUserToAddRows = false;
            this.dgv_AllParts.AllowUserToDeleteRows = false;
            this.dgv_AllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllParts.Location = new System.Drawing.Point(611, 86);
            this.dgv_AllParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_AllParts.Name = "dgv_AllParts";
            this.dgv_AllParts.RowHeadersWidth = 62;
            this.dgv_AllParts.RowTemplate.Height = 28;
            this.dgv_AllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllParts.Size = new System.Drawing.Size(595, 174);
            this.dgv_AllParts.TabIndex = 33;
            // 
            // dgv_AssociatedProductParts
            // 
            this.dgv_AssociatedProductParts.AllowUserToAddRows = false;
            this.dgv_AssociatedProductParts.AllowUserToDeleteRows = false;
            this.dgv_AssociatedProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AssociatedProductParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_AssociatedProductParts.Location = new System.Drawing.Point(611, 333);
            this.dgv_AssociatedProductParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_AssociatedProductParts.Name = "dgv_AssociatedProductParts";
            this.dgv_AssociatedProductParts.RowHeadersWidth = 62;
            this.dgv_AssociatedProductParts.RowTemplate.Height = 28;
            this.dgv_AssociatedProductParts.Size = new System.Drawing.Size(595, 174);
            this.dgv_AssociatedProductParts.TabIndex = 34;
            // 
            // btn_AddModParts
            // 
            this.btn_AddModParts.Location = new System.Drawing.Point(1106, 270);
            this.btn_AddModParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddModParts.Name = "btn_AddModParts";
            this.btn_AddModParts.Size = new System.Drawing.Size(100, 28);
            this.btn_AddModParts.TabIndex = 35;
            this.btn_AddModParts.Text = "Add Parts";
            this.btn_AddModParts.UseVisualStyleBackColor = true;
            this.btn_AddModParts.Click += new System.EventHandler(this.AddNewAssociatedPart);
            // 
            // btn_DeleteModParts
            // 
            this.btn_DeleteModParts.Location = new System.Drawing.Point(1106, 519);
            this.btn_DeleteModParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteModParts.Name = "btn_DeleteModParts";
            this.btn_DeleteModParts.Size = new System.Drawing.Size(100, 28);
            this.btn_DeleteModParts.TabIndex = 36;
            this.btn_DeleteModParts.Text = "Delete";
            this.btn_DeleteModParts.UseVisualStyleBackColor = true;
            this.btn_DeleteModParts.Click += new System.EventHandler(this.DeleteAssociatedPart);
            // 
            // btn_ModProductSave
            // 
            this.btn_ModProductSave.Location = new System.Drawing.Point(973, 570);
            this.btn_ModProductSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ModProductSave.Name = "btn_ModProductSave";
            this.btn_ModProductSave.Size = new System.Drawing.Size(100, 28);
            this.btn_ModProductSave.TabIndex = 37;
            this.btn_ModProductSave.Text = "Save";
            this.btn_ModProductSave.UseVisualStyleBackColor = true;
            this.btn_ModProductSave.Click += new System.EventHandler(this.ModifyProductSaveButton);
            // 
            // btn_ModProductCancel
            // 
            this.btn_ModProductCancel.Location = new System.Drawing.Point(1106, 570);
            this.btn_ModProductCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ModProductCancel.Name = "btn_ModProductCancel";
            this.btn_ModProductCancel.Size = new System.Drawing.Size(100, 28);
            this.btn_ModProductCancel.TabIndex = 38;
            this.btn_ModProductCancel.Text = "Cancel";
            this.btn_ModProductCancel.UseVisualStyleBackColor = true;
            this.btn_ModProductCancel.Click += new System.EventHandler(this.Btn_ModProductCancel);
            // 
            // btn_ModProdSearch
            // 
            this.btn_ModProdSearch.Location = new System.Drawing.Point(942, 34);
            this.btn_ModProdSearch.Name = "btn_ModProdSearch";
            this.btn_ModProdSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_ModProdSearch.TabIndex = 39;
            this.btn_ModProdSearch.Text = "Search";
            this.btn_ModProdSearch.UseVisualStyleBackColor = true;
            this.btn_ModProdSearch.Click += new System.EventHandler(this.btn_ModProdSearch_Click);
            // 
            // txt_ModProdSearch
            // 
            this.txt_ModProdSearch.Location = new System.Drawing.Point(1037, 34);
            this.txt_ModProdSearch.Name = "txt_ModProdSearch";
            this.txt_ModProdSearch.Size = new System.Drawing.Size(169, 22);
            this.txt_ModProdSearch.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Part ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 76;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Part Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Inventory";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Min";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 57;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Max";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 61;
            // 
            // ModifyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 618);
            this.Controls.Add(this.txt_ModProdSearch);
            this.Controls.Add(this.btn_ModProdSearch);
            this.Controls.Add(this.btn_ModProductCancel);
            this.Controls.Add(this.btn_ModProductSave);
            this.Controls.Add(this.btn_DeleteModParts);
            this.Controls.Add(this.btn_AddModParts);
            this.Controls.Add(this.dgv_AssociatedProductParts);
            this.Controls.Add(this.dgv_AllParts);
            this.Controls.Add(this.dgv_AssociatedModParts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ModifyProductMax);
            this.Controls.Add(this.txt_ModifyProductMin);
            this.Controls.Add(this.txt_ModifyProductPriceCost);
            this.Controls.Add(this.txt_ModifyProductInventory);
            this.Controls.Add(this.txt_ModifyProductName);
            this.Controls.Add(this.txt_modifyProductID);
            this.Controls.Add(this.lbl_ModProductMin);
            this.Controls.Add(this.lbl_ModProductMax);
            this.Controls.Add(this.lbl_ModProductPrice);
            this.Controls.Add(this.lbl_ModProductInventory);
            this.Controls.Add(this.lbl_ModProductName);
            this.Controls.Add(this.lbl_ModProductID);
            this.Controls.Add(this.lbl_ModProductMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModifyProducts";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssociatedProductParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ModifyProductMax;
        private System.Windows.Forms.TextBox txt_ModifyProductMin;
        private System.Windows.Forms.TextBox txt_ModifyProductPriceCost;
        private System.Windows.Forms.TextBox txt_ModifyProductInventory;
        private System.Windows.Forms.TextBox txt_ModifyProductName;
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
        private System.Windows.Forms.DataGridView dgv_AllParts;
        private System.Windows.Forms.DataGridView dgv_AssociatedProductParts;
        private System.Windows.Forms.Button btn_AddModParts;
        private System.Windows.Forms.Button btn_DeleteModParts;
        private System.Windows.Forms.Button btn_ModProductSave;
        private System.Windows.Forms.Button btn_ModProductCancel;
        private System.Windows.Forms.Button btn_ModProdSearch;
        private System.Windows.Forms.TextBox txt_ModProdSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}