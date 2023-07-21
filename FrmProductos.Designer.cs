﻿namespace CarritoCompra
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearcher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.CmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblShoppingCart = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.DescripcionProducto,
            this.PrecioProducto,
            this.MarcaProducto,
            this.Detalle});
            this.DgvProductos.Location = new System.Drawing.Point(44, 116);
            this.DgvProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(983, 462);
            this.DgvProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar producto";
            // 
            // TxtSearcher
            // 
            this.TxtSearcher.Location = new System.Drawing.Point(168, 66);
            this.TxtSearcher.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearcher.Name = "TxtSearcher";
            this.TxtSearcher.Size = new System.Drawing.Size(211, 26);
            this.TxtSearcher.TabIndex = 2;
            this.TxtSearcher.TextChanged += new System.EventHandler(this.TxtSearcher_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // CmbCategory
            // 
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(475, 66);
            this.CmbCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(264, 26);
            this.CmbCategory.TabIndex = 4;
            this.CmbCategory.SelectionChangeCommitted += new System.EventHandler(this.CmbCategory_SelectionChangeCommitted);
            // 
            // CmbBrand
            // 
            this.CmbBrand.FormattingEnabled = true;
            this.CmbBrand.Location = new System.Drawing.Point(810, 66);
            this.CmbBrand.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Size = new System.Drawing.Size(221, 26);
            this.CmbBrand.TabIndex = 6;
            this.CmbBrand.SelectionChangeCommitted += new System.EventHandler(this.CmbBrand_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1003, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LblShoppingCart
            // 
            this.LblShoppingCart.AutoSize = true;
            this.LblShoppingCart.Location = new System.Drawing.Point(1014, 14);
            this.LblShoppingCart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblShoppingCart.Name = "LblShoppingCart";
            this.LblShoppingCart.Size = new System.Drawing.Size(16, 18);
            this.LblShoppingCart.TabIndex = 8;
            this.LblShoppingCart.Text = "0";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 200;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.HeaderText = "Descripcion";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            this.DescripcionProducto.Width = 320;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            this.PrecioProducto.Width = 120;
            // 
            // MarcaProducto
            // 
            this.MarcaProducto.HeaderText = "Marca";
            this.MarcaProducto.Name = "MarcaProducto";
            this.MarcaProducto.ReadOnly = true;
            this.MarcaProducto.Width = 120;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Ver detalle";
            this.Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Detalle.Image")));
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 601);
            this.Controls.Add(this.LblShoppingCart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSearcher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearcher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.ComboBox CmbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblShoppingCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaProducto;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
    }
}