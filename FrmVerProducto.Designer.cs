namespace CarritoCompra
{
    partial class FrmVerProducto
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
            this.PbxProductImage = new System.Windows.Forms.PictureBox();
            this.LblNameProduct = new System.Windows.Forms.Label();
            this.LblDescriptionProduct = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblBrand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxProductImage
            // 
            this.PbxProductImage.Location = new System.Drawing.Point(26, 50);
            this.PbxProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.PbxProductImage.Name = "PbxProductImage";
            this.PbxProductImage.Size = new System.Drawing.Size(273, 300);
            this.PbxProductImage.TabIndex = 0;
            this.PbxProductImage.TabStop = false;
            // 
            // LblNameProduct
            // 
            this.LblNameProduct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameProduct.Location = new System.Drawing.Point(320, 50);
            this.LblNameProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNameProduct.Name = "LblNameProduct";
            this.LblNameProduct.Size = new System.Drawing.Size(225, 49);
            this.LblNameProduct.TabIndex = 1;
            this.LblNameProduct.Text = "Box PCs ";
            // 
            // LblDescriptionProduct
            // 
            this.LblDescriptionProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescriptionProduct.Location = new System.Drawing.Point(323, 127);
            this.LblDescriptionProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescriptionProduct.Name = "LblDescriptionProduct";
            this.LblDescriptionProduct.Size = new System.Drawing.Size(185, 74);
            this.LblDescriptionProduct.TabIndex = 1;
            this.LblDescriptionProduct.Text = "Box PCs DDR3L 2x SODIMM Socket 16GB";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(323, 99);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(60, 19);
            this.LblPrice.TabIndex = 2;
            this.LblPrice.Text = "30 USD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrand.Location = new System.Drawing.Point(377, 201);
            this.LblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(33, 16);
            this.LblBrand.TabIndex = 4;
            this.LblBrand.Text = "Asus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModel.Location = new System.Drawing.Point(377, 238);
            this.LblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(54, 16);
            this.LblModel.TabIndex = 4;
            this.LblModel.Text = "15series";
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Location = new System.Drawing.Point(324, 317);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(133, 33);
            this.BtnAddToCart.TabIndex = 5;
            this.BtnAddToCart.Text = "Agregar al carrito";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(389, 275);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(68, 22);
            this.TxtCantidad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // FrmVerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 383);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblDescriptionProduct);
            this.Controls.Add(this.LblNameProduct);
            this.Controls.Add(this.PbxProductImage);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVerProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVerProducto_FormClosing);
            this.Load += new System.EventHandler(this.FrmVerProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxProductImage;
        private System.Windows.Forms.Label LblNameProduct;
        private System.Windows.Forms.Label LblDescriptionProduct;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label4;
    }
}