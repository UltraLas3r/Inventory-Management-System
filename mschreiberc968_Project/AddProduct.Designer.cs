
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssociatedAddParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAddParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddProductCancel
            // 
            this.btn_AddProductCancel.Location = new System.Drawing.Point(1257, 709);
            this.btn_AddProductCancel.Name = "btn_AddProductCancel";
            this.btn_AddProductCancel.Size = new System.Drawing.Size(112, 35);
            this.btn_AddProductCancel.TabIndex = 59;
            this.btn_AddProductCancel.Text = "Cancel";
            this.btn_AddProductCancel.UseVisualStyleBackColor = true;
            // 
            // btn_AddProductSave
            // 
            this.btn_AddProductSave.Location = new System.Drawing.Point(1108, 709);
            this.btn_AddProductSave.Name = "btn_AddProductSave";
            this.btn_AddProductSave.Size = new System.Drawing.Size(112, 35);
            this.btn_AddProductSave.TabIndex = 58;
            this.btn_AddProductSave.Text = "Save";
            this.btn_AddProductSave.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteParts
            // 
            this.btn_DeleteParts.Location = new System.Drawing.Point(1257, 645);
            this.btn_DeleteParts.Name = "btn_DeleteParts";
            this.btn_DeleteParts.Size = new System.Drawing.Size(112, 35);
            this.btn_DeleteParts.TabIndex = 57;
            this.btn_DeleteParts.Text = "Delete";
            this.btn_DeleteParts.UseVisualStyleBackColor = true;
            // 
            // btn_AddParts
            // 
            this.btn_AddParts.Location = new System.Drawing.Point(1257, 333);
            this.btn_AddParts.Name = "btn_AddParts";
            this.btn_AddParts.Size = new System.Drawing.Size(112, 35);
            this.btn_AddParts.TabIndex = 56;
            this.btn_AddParts.Text = "Add Parts";
            this.btn_AddParts.UseVisualStyleBackColor = true;
            // 
            // dgv_AssociatedAddParts
            // 
            this.dgv_AssociatedAddParts.AllowUserToDeleteRows = false;
            this.dgv_AssociatedAddParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AssociatedAddParts.Location = new System.Drawing.Point(700, 412);
            this.dgv_AssociatedAddParts.Name = "dgv_AssociatedAddParts";
            this.dgv_AssociatedAddParts.RowHeadersWidth = 62;
            this.dgv_AssociatedAddParts.RowTemplate.Height = 28;
            this.dgv_AssociatedAddParts.Size = new System.Drawing.Size(669, 217);
            this.dgv_AssociatedAddParts.TabIndex = 55;
            // 
            // dgv_AllAddParts
            // 
            this.dgv_AllAddParts.AllowUserToDeleteRows = false;
            this.dgv_AllAddParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllAddParts.Location = new System.Drawing.Point(700, 103);
            this.dgv_AllAddParts.Name = "dgv_AllAddParts";
            this.dgv_AllAddParts.RowHeadersWidth = 62;
            this.dgv_AllAddParts.RowTemplate.Height = 28;
            this.dgv_AllAddParts.Size = new System.Drawing.Size(669, 217);
            this.dgv_AllAddParts.TabIndex = 54;
            // 
            // lbl_AddProduct_AssociatedParts
            // 
            this.lbl_AddProduct_AssociatedParts.AutoSize = true;
            this.lbl_AddProduct_AssociatedParts.Location = new System.Drawing.Point(696, 377);
            this.lbl_AddProduct_AssociatedParts.Name = "lbl_AddProduct_AssociatedParts";
            this.lbl_AddProduct_AssociatedParts.Size = new System.Drawing.Size(249, 20);
            this.lbl_AddProduct_AssociatedParts.TabIndex = 53;
            this.lbl_AddProduct_AssociatedParts.Text = "Parts Associated with this Product";
            // 
            // lbl_AddProduct_AllParts
            // 
            this.lbl_AddProduct_AllParts.AutoSize = true;
            this.lbl_AddProduct_AllParts.Location = new System.Drawing.Point(696, 38);
            this.lbl_AddProduct_AllParts.Name = "lbl_AddProduct_AllParts";
            this.lbl_AddProduct_AllParts.Size = new System.Drawing.Size(67, 20);
            this.lbl_AddProduct_AllParts.TabIndex = 52;
            this.lbl_AddProduct_AllParts.Text = "All Parts";
            // 
            // txt_AddProductMax
            // 
            this.txt_AddProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductMax.Location = new System.Drawing.Point(457, 329);
            this.txt_AddProductMax.Name = "txt_AddProductMax";
            this.txt_AddProductMax.Size = new System.Drawing.Size(122, 35);
            this.txt_AddProductMax.TabIndex = 51;
            // 
            // txt_AddProductMin
            // 
            this.txt_AddProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductMin.Location = new System.Drawing.Point(185, 330);
            this.txt_AddProductMin.Name = "txt_AddProductMin";
            this.txt_AddProductMin.Size = new System.Drawing.Size(122, 35);
            this.txt_AddProductMin.TabIndex = 50;
            // 
            // txt_AddProductPriceCost
            // 
            this.txt_AddProductPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductPriceCost.Location = new System.Drawing.Point(185, 268);
            this.txt_AddProductPriceCost.Name = "txt_AddProductPriceCost";
            this.txt_AddProductPriceCost.Size = new System.Drawing.Size(394, 35);
            this.txt_AddProductPriceCost.TabIndex = 49;
            // 
            // txt_AddProductInventory
            // 
            this.txt_AddProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductInventory.Location = new System.Drawing.Point(185, 209);
            this.txt_AddProductInventory.Name = "txt_AddProductInventory";
            this.txt_AddProductInventory.Size = new System.Drawing.Size(394, 35);
            this.txt_AddProductInventory.TabIndex = 48;
            // 
            // txt_AddProductName
            // 
            this.txt_AddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductName.Location = new System.Drawing.Point(185, 154);
            this.txt_AddProductName.Name = "txt_AddProductName";
            this.txt_AddProductName.Size = new System.Drawing.Size(394, 35);
            this.txt_AddProductName.TabIndex = 47;
            // 
            // txt_AddProductID
            // 
            this.txt_AddProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AddProductID.Location = new System.Drawing.Point(185, 107);
            this.txt_AddProductID.Name = "txt_AddProductID";
            this.txt_AddProductID.Size = new System.Drawing.Size(394, 35);
            this.txt_AddProductID.TabIndex = 46;
            // 
            // lbl_AddProductMin
            // 
            this.lbl_AddProductMin.AutoSize = true;
            this.lbl_AddProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductMin.Location = new System.Drawing.Point(108, 326);
            this.lbl_AddProductMin.Name = "lbl_AddProductMin";
            this.lbl_AddProductMin.Size = new System.Drawing.Size(52, 29);
            this.lbl_AddProductMin.TabIndex = 45;
            this.lbl_AddProductMin.Text = "Min";
            // 
            // lbl_AddProductMax
            // 
            this.lbl_AddProductMax.AutoSize = true;
            this.lbl_AddProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductMax.Location = new System.Drawing.Point(389, 329);
            this.lbl_AddProductMax.Name = "lbl_AddProductMax";
            this.lbl_AddProductMax.Size = new System.Drawing.Size(57, 29);
            this.lbl_AddProductMax.TabIndex = 44;
            this.lbl_AddProductMax.Text = "Max";
            // 
            // lbl_AddProductPrice
            // 
            this.lbl_AddProductPrice.AutoSize = true;
            this.lbl_AddProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductPrice.Location = new System.Drawing.Point(23, 265);
            this.lbl_AddProductPrice.Name = "lbl_AddProductPrice";
            this.lbl_AddProductPrice.Size = new System.Drawing.Size(137, 29);
            this.lbl_AddProductPrice.TabIndex = 43;
            this.lbl_AddProductPrice.Text = "Price / Cost";
            // 
            // lbl_AddProductInventory
            // 
            this.lbl_AddProductInventory.AutoSize = true;
            this.lbl_AddProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductInventory.Location = new System.Drawing.Point(23, 209);
            this.lbl_AddProductInventory.Name = "lbl_AddProductInventory";
            this.lbl_AddProductInventory.Size = new System.Drawing.Size(109, 29);
            this.lbl_AddProductInventory.TabIndex = 42;
            this.lbl_AddProductInventory.Text = "Inventory";
            // 
            // lbl_AddProductName
            // 
            this.lbl_AddProductName.AutoSize = true;
            this.lbl_AddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductName.Location = new System.Drawing.Point(23, 151);
            this.lbl_AddProductName.Name = "lbl_AddProductName";
            this.lbl_AddProductName.Size = new System.Drawing.Size(78, 29);
            this.lbl_AddProductName.TabIndex = 41;
            this.lbl_AddProductName.Text = "Name";
            // 
            // lbl_AddProductID
            // 
            this.lbl_AddProductID.AutoSize = true;
            this.lbl_AddProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductID.Location = new System.Drawing.Point(28, 103);
            this.lbl_AddProductID.Name = "lbl_AddProductID";
            this.lbl_AddProductID.Size = new System.Drawing.Size(36, 29);
            this.lbl_AddProductID.TabIndex = 40;
            this.lbl_AddProductID.Text = "ID";
            // 
            // lbl_AddProductMain
            // 
            this.lbl_AddProductMain.AutoSize = true;
            this.lbl_AddProductMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_AddProductMain.Location = new System.Drawing.Point(30, 29);
            this.lbl_AddProductMain.Name = "lbl_AddProductMain";
            this.lbl_AddProductMain.Size = new System.Drawing.Size(145, 29);
            this.lbl_AddProductMain.TabIndex = 39;
            this.lbl_AddProductMain.Text = "Add Product";
            this.lbl_AddProductMain.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 772);
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
    }
}