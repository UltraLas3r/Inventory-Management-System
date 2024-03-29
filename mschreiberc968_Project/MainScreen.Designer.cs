﻿
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
            this.modifyParts.Location = new System.Drawing.Point(388, 515);
            this.modifyParts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyParts.Name = "modifyParts";
            this.modifyParts.Size = new System.Drawing.Size(119, 56);
            this.modifyParts.TabIndex = 1;
            this.modifyParts.Text = "Modify";
            this.modifyParts.UseVisualStyleBackColor = true;
            this.modifyParts.Click += new System.EventHandler(this.modifyParts_Click);
            // 
            // addParts
            // 
            this.addParts.Location = new System.Drawing.Point(234, 515);
            this.addParts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addParts.Name = "addParts";
            this.addParts.Size = new System.Drawing.Size(125, 56);
            this.addParts.TabIndex = 3;
            this.addParts.Text = "Add";
            this.addParts.UseVisualStyleBackColor = true;
            this.addParts.Click += new System.EventHandler(this.addParts_Click);
            // 
            // deleteParts
            // 
            this.deleteParts.Location = new System.Drawing.Point(551, 515);
            this.deleteParts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteParts.Name = "deleteParts";
            this.deleteParts.Size = new System.Drawing.Size(119, 56);
            this.deleteParts.TabIndex = 2;
            this.deleteParts.Text = "Delete";
            this.deleteParts.UseVisualStyleBackColor = true;
            this.deleteParts.Click += new System.EventHandler(this.DeleteParts_Click);
            // 
            // addProducts
            // 
            this.addProducts.Location = new System.Drawing.Point(994, 515);
            this.addProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addProducts.Name = "addProducts";
            this.addProducts.Size = new System.Drawing.Size(119, 56);
            this.addProducts.TabIndex = 4;
            this.addProducts.Text = "Add";
            this.addProducts.UseVisualStyleBackColor = true;
            this.addProducts.Click += new System.EventHandler(this.addProducts_Click);
            // 
            // modifyProducts
            // 
            this.modifyProducts.Location = new System.Drawing.Point(1142, 515);
            this.modifyProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyProducts.Name = "modifyProducts";
            this.modifyProducts.Size = new System.Drawing.Size(119, 56);
            this.modifyProducts.TabIndex = 5;
            this.modifyProducts.Text = "Modify";
            this.modifyProducts.UseVisualStyleBackColor = true;
            this.modifyProducts.Click += new System.EventHandler(this.modifyProducts_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Location = new System.Drawing.Point(1306, 609);
            this.exitApplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(119, 56);
            this.exitApplication.TabIndex = 7;
            this.exitApplication.Text = "Exit";
            this.exitApplication.UseVisualStyleBackColor = true;
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // deleteProducts
            // 
            this.deleteProducts.Location = new System.Drawing.Point(1306, 515);
            this.deleteProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteProducts.Name = "deleteProducts";
            this.deleteProducts.Size = new System.Drawing.Size(119, 56);
            this.deleteProducts.TabIndex = 6;
            this.deleteProducts.Text = "Delete";
            this.deleteProducts.UseVisualStyleBackColor = true;
            this.deleteProducts.Click += new System.EventHandler(this.DeleteProducts);
            // 
            // dgv_Parts
            // 
            this.dgv_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Parts.Location = new System.Drawing.Point(36, 171);
            this.dgv_Parts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Parts.Name = "dgv_Parts";
            this.dgv_Parts.RowHeadersWidth = 62;
            this.dgv_Parts.RowTemplate.Height = 28;
            this.dgv_Parts.Size = new System.Drawing.Size(634, 318);
            this.dgv_Parts.TabIndex = 8;
            this.dgv_Parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Parts_CellClick);
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Location = new System.Drawing.Point(744, 171);
            this.dgv_Products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowHeadersWidth = 62;
            this.dgv_Products.RowTemplate.Height = 28;
            this.dgv_Products.Size = new System.Drawing.Size(682, 318);
            this.dgv_Products.TabIndex = 9;
            this.dgv_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Products_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory Management System";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(222, 112);
            this.partsSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(118, 39);
            this.partsSearchButton.TabIndex = 11;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(974, 112);
            this.productsSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(120, 39);
            this.productsSearchButton.TabIndex = 12;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.ProductsSearchButton_Click);
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Location = new System.Drawing.Point(346, 121);
            this.partsSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(324, 26);
            this.partsSearchBox.TabIndex = 13;
            // 
            // productsSearchBox
            // 
            this.productsSearchBox.Location = new System.Drawing.Point(1101, 118);
            this.productsSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsSearchBox.Name = "productsSearchBox";
            this.productsSearchBox.Size = new System.Drawing.Size(324, 26);
            this.productsSearchBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(738, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Products";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 692);
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
            this.Text = "Main Form";
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

