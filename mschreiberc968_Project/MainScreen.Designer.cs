
using System;

namespace mschreiberc968_Project
{
    partial class MainScreen
    {
      



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
            this.modifyParts = new System.Windows.Forms.Button();
            this.addParts = new System.Windows.Forms.Button();
            this.deleteParts = new System.Windows.Forms.Button();
            this.addProducts = new System.Windows.Forms.Button();
            this.modifyProducts = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.deleteProducts = new System.Windows.Forms.Button();
            this.dgv_Parts = new System.Windows.Forms.DataGridView();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            this.productsSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyParts
            // 
            this.modifyParts.Location = new System.Drawing.Point(454, 412);
            this.modifyParts.Margin = new System.Windows.Forms.Padding(4);
            this.modifyParts.Name = "modifyParts";
            this.modifyParts.Size = new System.Drawing.Size(106, 45);
            this.modifyParts.TabIndex = 1;
            this.modifyParts.Text = "Modify";
            this.modifyParts.UseVisualStyleBackColor = true;
            this.modifyParts.Click += new System.EventHandler(this.modifyParts_Click);
            // 
            // addParts
            // 
            this.addParts.Location = new System.Drawing.Point(325, 412);
            this.addParts.Margin = new System.Windows.Forms.Padding(4);
            this.addParts.Name = "addParts";
            this.addParts.Size = new System.Drawing.Size(111, 45);
            this.addParts.TabIndex = 3;
            this.addParts.Text = "Add";
            this.addParts.UseVisualStyleBackColor = true;
            this.addParts.Click += new System.EventHandler(this.addParts_Click);
            // 
            // deleteParts
            // 
            this.deleteParts.Location = new System.Drawing.Point(586, 412);
            this.deleteParts.Margin = new System.Windows.Forms.Padding(4);
            this.deleteParts.Name = "deleteParts";
            this.deleteParts.Size = new System.Drawing.Size(106, 45);
            this.deleteParts.TabIndex = 2;
            this.deleteParts.Text = "Delete";
            this.deleteParts.UseVisualStyleBackColor = true;
            this.deleteParts.Click += new System.EventHandler(this.deleteParts_Click);
            // 
            // addProducts
            // 
            this.addProducts.Location = new System.Drawing.Point(999, 412);
            this.addProducts.Margin = new System.Windows.Forms.Padding(4);
            this.addProducts.Name = "addProducts";
            this.addProducts.Size = new System.Drawing.Size(106, 45);
            this.addProducts.TabIndex = 4;
            this.addProducts.Text = "Add";
            this.addProducts.UseVisualStyleBackColor = true;
            this.addProducts.Click += new System.EventHandler(this.addProducts_Click);
            // 
            // modifyProducts
            // 
            this.modifyProducts.Location = new System.Drawing.Point(1148, 412);
            this.modifyProducts.Margin = new System.Windows.Forms.Padding(4);
            this.modifyProducts.Name = "modifyProducts";
            this.modifyProducts.Size = new System.Drawing.Size(106, 45);
            this.modifyProducts.TabIndex = 5;
            this.modifyProducts.Text = "Modify";
            this.modifyProducts.UseVisualStyleBackColor = true;
            this.modifyProducts.Click += new System.EventHandler(this.modifyProducts_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Location = new System.Drawing.Point(1315, 489);
            this.exitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(106, 45);
            this.exitApplication.TabIndex = 7;
            this.exitApplication.Text = "Exit";
            this.exitApplication.UseVisualStyleBackColor = true;
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // deleteProducts
            // 
            this.deleteProducts.Location = new System.Drawing.Point(1308, 412);
            this.deleteProducts.Margin = new System.Windows.Forms.Padding(4);
            this.deleteProducts.Name = "deleteProducts";
            this.deleteProducts.Size = new System.Drawing.Size(106, 45);
            this.deleteProducts.TabIndex = 6;
            this.deleteProducts.Text = "Delete";
            this.deleteProducts.UseVisualStyleBackColor = true;
            // 
            // dgv_Parts
            // 
            this.dgv_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Parts.Location = new System.Drawing.Point(32, 137);
            this.dgv_Parts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Parts.Name = "dgv_Parts";
            this.dgv_Parts.RowHeadersWidth = 62;
            this.dgv_Parts.RowTemplate.Height = 28;
            this.dgv_Parts.Size = new System.Drawing.Size(674, 254);
            this.dgv_Parts.TabIndex = 8;
            this.dgv_Parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Parts_CellClick);
            this.dgv_Parts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Parts_CellContentClick);
            this.dgv_Parts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Location = new System.Drawing.Point(740, 137);
            this.dgv_Products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowHeadersWidth = 62;
            this.dgv_Products.RowTemplate.Height = 28;
            this.dgv_Products.Size = new System.Drawing.Size(674, 254);
            this.dgv_Products.TabIndex = 9;
            this.dgv_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Products_CellContentClick);
            this.dgv_Products.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myProductsBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory Management System";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(1015, 88);
            this.partsSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(105, 31);
            this.partsSearchButton.TabIndex = 11;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(269, 88);
            this.productsSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(107, 31);
            this.productsSearchButton.TabIndex = 12;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Location = new System.Drawing.Point(404, 94);
            this.partsSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(288, 22);
            this.partsSearchBox.TabIndex = 13;
            // 
            // productsSearchBox
            // 
            this.productsSearchBox.Location = new System.Drawing.Point(1125, 94);
            this.productsSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsSearchBox.Name = "productsSearchBox";
            this.productsSearchBox.Size = new System.Drawing.Size(288, 22);
            this.productsSearchBox.TabIndex = 14;
            this.productsSearchBox.TextChanged += new System.EventHandler(this.productsSearchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(746, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Products";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 545);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsSearchBox);
            this.Controls.Add(this.partsSearchBox);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Products);
            this.Controls.Add(this.dgv_Parts);
            this.Controls.Add(this.exitApplication);
            this.Controls.Add(this.deleteProducts);
            this.Controls.Add(this.modifyProducts);
            this.Controls.Add(this.addProducts);
            this.Controls.Add(this.addParts);
            this.Controls.Add(this.deleteParts);
            this.Controls.Add(this.modifyParts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.Button modifyParts;
        private System.Windows.Forms.Button addParts;
        private System.Windows.Forms.Button deleteParts;
        private System.Windows.Forms.Button addProducts;
        private System.Windows.Forms.Button modifyProducts;
        private System.Windows.Forms.Button exitApplication;
        private System.Windows.Forms.Button deleteProducts;
        private System.Windows.Forms.DataGridView dgv_Parts;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.TextBox partsSearchBox;
        private System.Windows.Forms.TextBox productsSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

