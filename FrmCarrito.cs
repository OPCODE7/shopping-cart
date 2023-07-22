using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoCompra
{
    public partial class FrmCarrito : Form
    {
        DataBase db = new DataBase();
        Helper h = new Helper();
        FrmProductos products = new FrmProductos();
        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            getDetailsCart();

        }

        public void getDetailsCart()
        {
            DataTable cartDetails = new DataTable();
            string data;
            data = "A.ID_CARRITO_DETALLE,B.NOMBRE_PRODUCTO,B.PRECIO_PRODUCTO,A.CANTIDAD FROM CARRITO_DETALLE A INNER JOIN PRODUCTOS B ON(A.ID_PRODUCTO= B.ID_PRODUCTO)";

            cartDetails = db.JoinTables(data, "A.ID_CARRITO= '" + Cart.numberCart + "'");
           

            DgvCart.Rows.Clear();
            if (cartDetails.Rows.Count > 0)
            {
                int i;
                double totalToPay = 0;
                for (i = 0; i < cartDetails.Rows.Count; i++)
                {
                    string idDetailCart,nameProduct,priceProduct, amount;
                    double subTotal;
                    idDetailCart= cartDetails.Rows[i][0].ToString();
                    nameProduct = cartDetails.Rows[i][1].ToString();
                    priceProduct = cartDetails.Rows[i][2].ToString();
                    amount = cartDetails.Rows[i][3].ToString();
                    subTotal = Convert.ToDouble(priceProduct) * Convert.ToDouble(amount);

                    DgvCart.Rows.Add(idDetailCart,nameProduct, priceProduct, amount,subTotal);
                }

                foreach (DataGridViewRow row in DgvCart.Rows)
                {
                    totalToPay += Convert.ToDouble(row.Cells["SUBTOTAL"].Value);
                    
                }
                LblTotal.Text = totalToPay.ToString();

            }
            else
            {
                MessageBox.Show("Carrito vacio");
            }

            cartDetails.Dispose();

        }

        private void BtnBackToFrmProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            products.LblShoppingCart.Text = Cart.numberOfProducts.ToString();
            products.Show();
        }

        private void FrmCarrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            products.LblShoppingCart.Text = Cart.numberOfProducts.ToString();
            products.Show();
        }

        private void DgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.ToString()=="5")
            {
                string idDetailCart= DgvCart.CurrentRow.Cells[0].Value.ToString();
                if (db.Destroy("CARRITO_DETALLE", "ID_CARRITO_DETALLE= '" + idDetailCart + "'")> 0)
                {
                    h.MsgSuccess("producto eliminado del carrito");
                    getDetailsCart();
                    Cart.numberOfProducts--;
                }

            }
        }

        private void DgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.ToString() == "3")
            {
                if (DgvCart.Rows.Count > 0)
                {

                    if (DgvCart.CurrentRow.Cells[0].Value != null)
                    {
                        string values= "CANTIDAD= '"+ DgvCart.CurrentRow.Cells[3].Value.ToString() + "'";
                        string idDetailCart = DgvCart.CurrentRow.Cells[0].Value.ToString();
                        if (db.Update("CARRITO_DETALLE", values, "ID_CARRITO_DETALLE= '" + idDetailCart + "'") > 0)
                        {
                            getDetailsCart();

                        }
                    }
                }

            }

        }
    }
}
