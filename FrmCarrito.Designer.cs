﻿namespace CarritoCompra
{
    partial class FrmCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrito));
            this.DgvCart = new System.Windows.Forms.DataGridView();
            this.ID_CARRITO_DETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBackToFrmProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCart
            // 
            this.DgvCart.AllowUserToAddRows = false;
            this.DgvCart.AllowUserToDeleteRows = false;
            this.DgvCart.AllowUserToResizeColumns = false;
            this.DgvCart.AllowUserToResizeRows = false;
            this.DgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CARRITO_DETALLE,
            this.COD_PRODUCTO,
            this.NOMBRE_PRODUCTO,
            this.PRECIO_PRODUCTO,
            this.CANTIDAD,
            this.DESCUENTO,
            this.SUBTOTAL,
            this.ELIMINAR});
            this.DgvCart.Location = new System.Drawing.Point(22, 30);
            this.DgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCart.Name = "DgvCart";
            this.DgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvCart.Size = new System.Drawing.Size(1015, 282);
            this.DgvCart.TabIndex = 0;
            this.DgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCart_CellClick);
            this.DgvCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCart_CellValueChanged);
            // 
            // ID_CARRITO_DETALLE
            // 
            this.ID_CARRITO_DETALLE.HeaderText = "ID_DETALLE";
            this.ID_CARRITO_DETALLE.Name = "ID_CARRITO_DETALLE";
            this.ID_CARRITO_DETALLE.ReadOnly = true;
            // 
            // COD_PRODUCTO
            // 
            this.COD_PRODUCTO.HeaderText = "COD_PRODUCTO";
            this.COD_PRODUCTO.Name = "COD_PRODUCTO";
            this.COD_PRODUCTO.ReadOnly = true;
            this.COD_PRODUCTO.Width = 120;
            // 
            // NOMBRE_PRODUCTO
            // 
            this.NOMBRE_PRODUCTO.HeaderText = "NOMBRE_PRODUCTO";
            this.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO";
            this.NOMBRE_PRODUCTO.ReadOnly = true;
            this.NOMBRE_PRODUCTO.Width = 200;
            // 
            // PRECIO_PRODUCTO
            // 
            this.PRECIO_PRODUCTO.HeaderText = "PRECIO_PRODUCTO";
            this.PRECIO_PRODUCTO.Name = "PRECIO_PRODUCTO";
            this.PRECIO_PRODUCTO.ReadOnly = true;
            this.PRECIO_PRODUCTO.Width = 150;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // DESCUENTO
            // 
            this.DESCUENTO.HeaderText = "DESCUENTO";
            this.DESCUENTO.Name = "DESCUENTO";
            this.DESCUENTO.ReadOnly = true;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.HeaderText = "SUBTOTAL";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR PRODUCTO";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ELIMINAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(956, 338);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(14, 16);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total a pagar:";
            // 
            // BtnBackToFrmProducts
            // 
            this.BtnBackToFrmProducts.Location = new System.Drawing.Point(31, 331);
            this.BtnBackToFrmProducts.Name = "BtnBackToFrmProducts";
            this.BtnBackToFrmProducts.Size = new System.Drawing.Size(150, 23);
            this.BtnBackToFrmProducts.TabIndex = 2;
            this.BtnBackToFrmProducts.Text = "Volver a productos";
            this.BtnBackToFrmProducts.UseVisualStyleBackColor = true;
            this.BtnBackToFrmProducts.Click += new System.EventHandler(this.BtnBackToFrmProducts_Click);
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 385);
            this.Controls.Add(this.BtnBackToFrmProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.DgvCart);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCarrito_FormClosing);
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCart;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBackToFrmProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARRITO_DETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}