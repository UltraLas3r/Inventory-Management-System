
namespace mschreiberc968_Project
{
    partial class AddProduct
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
            this.btn_AddProductCancel = new System.Windows.Forms.Button();
            this.btn_AddProductSave = new System.Windows.Forms.Button();
            this.btn_DeleteParts = new System.Windows.Forms.Button();
            this.btn_AddParts = new System.Windows.Forms.Button();
            this.dgv_AssociatedAddParts = new System.Windows.Forms.DataGridView();
            this.dgv_AllAddParts = new System.Windows.Forms.DataGridView();
            this.lbl_AddProduct_AssociatedParts = new System.Windows.Forms.Label();
            this.lbl_AddProduct_AllParts = new System.Windows.Forms.Label();
            this.txt_AddProductMax = new System.Windows.Forms.TextBox();
            this.txt_AddProductMin = new System.Windows.Forms.TextBox();
            this.txt_AddProductPriceCost = new System.Windows.Forms.TextBox();
            this.txt_AddProductInventory = new System.Windows.Forms.TextBox();
            this.txt_AddProductName = new System.Windows.Forms.TextBox();
            this.txt_AddProductID = new System.Windows.Forms.TextBox();
            this.lbl_AddProductMin = new System.Windows.Forms.Label();
            this.lbl_AddProductMax = new System.Windows.Forms.Label();
            this.lbl_AddProductPrice = new System.Windows.Forms.Label();
            this.lbl_AddProductInventory = new System.Windows.Forms.Label();
            this.lbl_AddProductName = new System.Windows.Forms.Label();
            this.lbl_AddProductID = new System.Windows.Forms.Label();
            this.lbl_AddProductMain = new System.Windows.Forms.Label();
            this.btn_AddProdSearch = new System.Windows.Forms.Button();
            this.txt_AddProdSearch = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssociatedAddParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAddParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddProductCancel
            // 
            this.btn_AddProductCancel.Location = new System.Drawing.Point(1117, 567);
            this.btn_AddProductCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddProductCancel.Name = "btn_AddProductCancel";
            this.btn_AddProductCancel.Size = new System.Drawing.Size(100, 28);
            this.btn_AddProductCancel.TabIndex = 59;
            this.btn_AddProductCancel.Text = "Cancel";
            this.btn_AddProductCancel.UseVisualStyleBackColor = true;
            this.btn_AddProductCancel.Click += new System.EventHandler(this.btn_AddProductCancel_Click);
            // 
            // btn_AddProductSave
            // 
            this.btn_AddProductSave.Location = new System.Drawing.Point(985, 567);
            this.btn_AddProductSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddProductSave.Name = "btn_AddProductSave";
            this.btn_AddProductSave.Size = new System.Drawing.Size(100, 28);
            this.btn_AddProductSave.TabIndex = 58;
            this.btn_AddProductSave.Text = "Save";
            this.btn_AddProductSave.UseVisualStyleBackColor = true;
            this.btn_AddProductSave.Click += new System.EventHandler(this.btn_AddProductSave_Click);
            // 
            // btn_DeleteParts
            // 
            this.btn_DeleteParts.Location = new System.Drawing.Point(1117, 516);
            this.btn_DeleteParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteParts.Name = "btn_DeleteParts";
            this.btn_DeleteParts.Size = new System.Drawing.Size(100, 28);
            this.btn_DeleteParts.TabIndex = 57;
            this.btn_DeleteParts.Text = "Delete";
            this.btn_DeleteParts.UseVisualStyleBackColor = true;
            this.btn_DeleteParts.Click += new System.EventHandler(this.btn_DeleteParts_Click);
            // 
            // btn_AddParts
            // 
            this.btn_AddParts.Location = new System.Drawing.Point(1117, 266);
            this.btn_AddParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddParts.Name = "btn_AddParts";
            this.btn_AddParts.Size = new System.Drawing.Size(100, 28);
            this.btn_AddParts.TabIndex = 56;
            this.btn_AddParts.Text = "Add Parts";
            this.btn_AddParts.UseVisualStyleBackColor = true;
            this.btn_AddParts.Click += new System.EventHandler(this.btn_AddParts_Click);
            // 
            // dgv_AssociatedAddParts
            // 
            this.dgv_AssociatedAddParts.AllowUserToDeleteRows = false;
            this.dgv_AssociatedAddParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AssociatedAddParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgv_AssociatedAddParts.Location = new System.Drawing.Point(622, 330);
            this.dgv_AssociatedAddParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_AssociatedAddParts.Name = "dgv_AssociatedAddParts";
            this.dgv_AssociatedAddParts.RowHeadersWidth = 62;
            this.dgv_AssociatedAddParts.RowTemplate.Height = 28;
            this.dgv_AssociatedAddParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AssociatedAddParts.Size = new System.Drawing.Size(595, 174);
            this.dgv_AssociatedAddParts.TabIndex = 55;
            // 
            // dgv_AllAddParts
            // 
            this.dgv_AllAddParts.AllowUserToDeleteRows = false;
            this.dgv_AllAddParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllAddParts.Location = new System.Drawing.Point(622, 82);
            this.dgv_AllAddParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_AllAddParts.Name = "dgv_AllAddParts";
            this.dgv_AllAddParts.RowHeadersWidth = 62;
            this.dgv_AllAddParts.RowTemplate.Height = 28;
            this.dgv_AllAddParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllAddParts.Size = new System.Drawing.Size(595, 174);
            this.dgv_AllAddParts.TabIndex = 54;
            // 
            // lbl_AddProduct_AssociatedParts
            // 
            this.lbl_AddProduct_AssociatedParts.AutoSize = true;
            this.lbl_AddProduct_AssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProduct_AssociatedParts.Location = new System.Drawing.Point(619, 302);
            this.lbl_AddProduct_AssociatedParts.Name = "lbl_AddProduct_AssociatedParts";
            this.lbl_AddProduct_AssociatedParts.Size = new System.Drawing.Size(305, 25);
            this.lbl_AddProduct_AssociatedParts.TabIndex = 53;
            this.lbl_AddProduct_AssociatedParts.Text = "Parts Associated with this Product";
            // 
            // lbl_AddProduct_AllParts
            // 
            this.lbl_AddProduct_AllParts.AutoSize = true;
            this.lbl_AddProduct_AllParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProduct_AllParts.Location = new System.Drawing.Point(619, 30);
            this.lbl_AddProduct_AllParts.Name = "lbl_AddProduct_AllParts";
            this.lbl_AddProduct_AllParts.Size = new System.Drawing.Size(84, 25);
            this.lbl_AddProduct_AllParts.TabIndex = 52;
            this.lbl_AddProduct_AllParts.Text = "All Parts";
            // 
            // txt_AddProductMax
            // 
            this.txt_AddProductMax.BackColor = System.Drawing.Color.White;
            this.txt_AddProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductMax.Location = new System.Drawing.Point(406, 325);
            this.txt_AddProductMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AddProductMax.Name = "txt_AddProductMax";
            this.txt_AddProductMax.Size = new System.Drawing.Size(109, 30);
            this.txt_AddProductMax.TabIndex = 51;
            this.txt_AddProductMax.TextChanged += new System.EventHandler(this.txt_AddProductMax_TextChanged);
            // 
            // txt_AddProductMin
            // 
            this.txt_AddProductMin.BackColor = System.Drawing.Color.White;
            this.txt_AddProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductMin.Location = new System.Drawing.Point(164, 325);
            this.txt_AddProductMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AddProductMin.Name = "txt_AddProductMin";
            this.txt_AddProductMin.Size = new System.Drawing.Size(109, 30);
            this.txt_AddProductMin.TabIndex = 50;
            this.txt_AddProductMin.TextChanged += new System.EventHandler(this.txt_AddProductMin_TextChanged);
            // 
            // txt_AddProductPriceCost
            // 
            this.txt_AddProductPriceCost.BackColor = System.Drawing.Color.White;
            this.txt_AddProductPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductPriceCost.Location = new System.Drawing.Point(164, 262);
            this.txt_AddProductPriceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AddProductPriceCost.Name = "txt_AddProductPriceCost";
            this.txt_AddProductPriceCost.Size = new System.Drawing.Size(351, 30);
            this.txt_AddProductPriceCost.TabIndex = 49;
            this.txt_AddProductPriceCost.TextChanged += new System.EventHandler(this.txt_AddProductPriceCost_TextChanged);
            // 
            // txt_AddProductInventory
            // 
            this.txt_AddProductInventory.BackColor = System.Drawing.Color.White;
            this.txt_AddProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductInventory.Location = new System.Drawing.Point(164, 216);
            this.txt_AddProductInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AddProductInventory.Name = "txt_AddProductInventory";
            this.txt_AddProductInventory.Size = new System.Drawing.Size(351, 30);
            this.txt_AddProductInventory.TabIndex = 48;
            this.txt_AddProductInventory.TextChanged += new System.EventHandler(this.txt_AddProductInventory_TextChanged);
            // 
            // txt_AddProductName
            // 
            this.txt_AddProductName.BackColor = System.Drawing.Color.White;
            this.txt_AddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductName.Location = new System.Drawing.Point(164, 164);
            this.txt_AddProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AddProductName.Name = "txt_AddProductName";
            this.txt_AddProductName.Size = new System.Drawing.Size(351, 30);
            this.txt_AddProductName.TabIndex = 47;
            this.txt_AddProductName.TextChanged += new System.EventHandler(this.txt_AddProductName_TextChanged);
            // 
            // txt_AddProductID
            // 
            this.txt_AddProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductID.Location = new System.Drawing.Point(164, 116);
            this.txt_AddProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AddProductID.Name = "txt_AddProductID";
            this.txt_AddProductID.ReadOnly = true;
            this.txt_AddProductID.Size = new System.Drawing.Size(351, 30);
            this.txt_AddProductID.TabIndex = 46;
            // 
            // lbl_AddProductMin
            // 
            this.lbl_AddProductMin.AutoSize = true;
            this.lbl_AddProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductMin.Location = new System.Drawing.Point(89, 330);
            this.lbl_AddProductMin.Name = "lbl_AddProductMin";
            this.lbl_AddProductMin.Size = new System.Drawing.Size(44, 25);
            this.lbl_AddProductMin.TabIndex = 45;
            this.lbl_AddProductMin.Text = "Min";
            // 
            // lbl_AddProductMax
            // 
            this.lbl_AddProductMax.AutoSize = true;
            this.lbl_AddProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductMax.Location = new System.Drawing.Point(350, 328);
            this.lbl_AddProductMax.Name = "lbl_AddProductMax";
            this.lbl_AddProductMax.Size = new System.Drawing.Size(50, 25);
            this.lbl_AddProductMax.TabIndex = 44;
            this.lbl_AddProductMax.Text = "Max";
            // 
            // lbl_AddProductPrice
            // 
            this.lbl_AddProductPrice.AutoSize = true;
            this.lbl_AddProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductPrice.Location = new System.Drawing.Point(27, 267);
            this.lbl_AddProductPrice.Name = "lbl_AddProductPrice";
            this.lbl_AddProductPrice.Size = new System.Drawing.Size(113, 25);
            this.lbl_AddProductPrice.TabIndex = 43;
            this.lbl_AddProductPrice.Text = "Price / Cost";
            // 
            // lbl_AddProductInventory
            // 
            this.lbl_AddProductInventory.AutoSize = true;
            this.lbl_AddProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductInventory.Location = new System.Drawing.Point(27, 216);
            this.lbl_AddProductInventory.Name = "lbl_AddProductInventory";
            this.lbl_AddProductInventory.Size = new System.Drawing.Size(92, 25);
            this.lbl_AddProductInventory.TabIndex = 42;
            this.lbl_AddProductInventory.Text = "Inventory";
            // 
            // lbl_AddProductName
            // 
            this.lbl_AddProductName.AutoSize = true;
            this.lbl_AddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductName.Location = new System.Drawing.Point(27, 169);
            this.lbl_AddProductName.Name = "lbl_AddProductName";
            this.lbl_AddProductName.Size = new System.Drawing.Size(64, 25);
            this.lbl_AddProductName.TabIndex = 41;
            this.lbl_AddProductName.Text = "Name";
            // 
            // lbl_AddProductID
            // 
            this.lbl_AddProductID.AutoSize = true;
            this.lbl_AddProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductID.Location = new System.Drawing.Point(27, 121);
            this.lbl_AddProductID.Name = "lbl_AddProductID";
            this.lbl_AddProductID.Size = new System.Drawing.Size(31, 25);
            this.lbl_AddProductID.TabIndex = 40;
            this.lbl_AddProductID.Text = "ID";
            // 
            // lbl_AddProductMain
            // 
            this.lbl_AddProductMain.AutoSize = true;
            this.lbl_AddProductMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductMain.Location = new System.Drawing.Point(27, 23);
            this.lbl_AddProductMain.Name = "lbl_AddProductMain";
            this.lbl_AddProductMain.Size = new System.Drawing.Size(120, 25);
            this.lbl_AddProductMain.TabIndex = 39;
            this.lbl_AddProductMain.Text = "Add Product";
            // 
            // btn_AddProdSearch
            // 
            this.btn_AddProdSearch.Location = new System.Drawing.Point(898, 30);
            this.btn_AddProdSearch.Name = "btn_AddProdSearch";
            this.btn_AddProdSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_AddProdSearch.TabIndex = 60;
            this.btn_AddProdSearch.Text = "Search";
            this.btn_AddProdSearch.UseVisualStyleBackColor = true;
            // 
            // txt_AddProdSearch
            // 
            this.txt_AddProdSearch.Location = new System.Drawing.Point(989, 31);
            this.txt_AddProdSearch.Name = "txt_AddProdSearch";
            this.txt_AddProdSearch.Size = new System.Drawing.Size(228, 22);
            this.txt_AddProdSearch.TabIndex = 61;
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
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 67;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Inventory";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
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
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 618);
            this.Controls.Add(this.txt_AddProdSearch);
            this.Controls.Add(this.btn_AddProdSearch);
            this.Controls.Add(this.btn_AddProductCancel);
            this.Controls.Add(this.btn_AddProductSave);
            this.Controls.Add(this.btn_DeleteParts);
            this.Controls.Add(this.btn_AddParts);
            this.Controls.Add(this.dgv_AssociatedAddParts);
            this.Controls.Add(this.dgv_AllAddParts);
            this.Controls.Add(this.lbl_AddProduct_AssociatedParts);
            this.Controls.Add(this.lbl_AddProduct_AllParts);
            this.Controls.Add(this.txt_AddProductMax);
            this.Controls.Add(this.txt_AddProductMin);
            this.Controls.Add(this.txt_AddProductPriceCost);
            this.Controls.Add(this.txt_AddProductInventory);
            this.Controls.Add(this.txt_AddProductName);
            this.Controls.Add(this.txt_AddProductID);
            this.Controls.Add(this.lbl_AddProductMin);
            this.Controls.Add(this.lbl_AddProductMax);
            this.Controls.Add(this.lbl_AddProductPrice);
            this.Controls.Add(this.lbl_AddProductInventory);
            this.Controls.Add(this.lbl_AddProductName);
            this.Controls.Add(this.lbl_AddProductID);
            this.Controls.Add(this.lbl_AddProductMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssociatedAddParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAddParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddProductCancel;
        private System.Windows.Forms.Button btn_AddProductSave;
        private System.Windows.Forms.Button btn_DeleteParts;
        private System.Windows.Forms.Button btn_AddParts;
        private System.Windows.Forms.DataGridView dgv_AssociatedAddParts;
        private System.Windows.Forms.DataGridView dgv_AllAddParts;
        private System.Windows.Forms.Label lbl_AddProduct_AssociatedParts;
        private System.Windows.Forms.Label lbl_AddProduct_AllParts;
        private System.Windows.Forms.TextBox txt_AddProductMax;
        private System.Windows.Forms.TextBox txt_AddProductMin;
        private System.Windows.Forms.TextBox txt_AddProductPriceCost;
        private System.Windows.Forms.TextBox txt_AddProductInventory;
        private System.Windows.Forms.TextBox txt_AddProductName;
        private System.Windows.Forms.TextBox txt_AddProductID;
        private System.Windows.Forms.Label lbl_AddProductMin;
        private System.Windows.Forms.Label lbl_AddProductMax;
        private System.Windows.Forms.Label lbl_AddProductPrice;
        private System.Windows.Forms.Label lbl_AddProductInventory;
        private System.Windows.Forms.Label lbl_AddProductName;
        private System.Windows.Forms.Label lbl_AddProductID;
        private System.Windows.Forms.Label lbl_AddProductMain;
        private System.Windows.Forms.Button btn_AddProdSearch;
        private System.Windows.Forms.TextBox txt_AddProdSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}