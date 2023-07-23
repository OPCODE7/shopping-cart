using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            this.Text += $"|{User.USERNAME}";

        }

        public void getDetailsCart()
        {
            DataTable cartDetails = new DataTable();
            DataTable promotionProducts = new DataTable();

            string data;
            data = "A.ID_CARRITO_DETALLE,B.NOMBRE_PRODUCTO,B.PRECIO_PRODUCTO,A.CANTIDAD,A.ID_PRODUCTO FROM CARRITO_DETALLE A INNER JOIN PRODUCTOS B ON(A.ID_PRODUCTO= B.ID_PRODUCTO)";

            string dataPromotions= "A.ID_PRODUCTO,D.DESCUENTO FROM  PRODUCTOS A INNER JOIN PRODUCTOS_EN_PROMOCION B ON(A.ID_PRODUCTO= B.ID_PRODUCTO) INNER JOIN PROMOCIONES C ON(B.ID_PROMOCION = C.ID_PROMOCION) INNER JOIN PROMOCION_CUPONES_DESCUENTO D ON(C.ID_PROMOCION_CUPON_DESCUENTO = D.ID_PROMOCION_CUPONES_DESCUENTO)";

            cartDetails = db.JoinTables(data, "A.ID_CARRITO= '" + Cart.numberCart + "'");
            promotionProducts = db.JoinTables(dataPromotions);


            DgvCart.Rows.Clear();
            if (cartDetails.Rows.Count > 0)
            {
                int i;
                double totalToPay = 0;
                for (i = 0; i < cartDetails.Rows.Count; i++)
                {
                    string idDetailCart,nameProduct,priceProduct, amount,discount= "0",idProducto;
                    double subTotal,totalDiscount;
                    idDetailCart= cartDetails.Rows[i][0].ToString();
                    nameProduct = cartDetails.Rows[i][1].ToString();
                    priceProduct = cartDetails.Rows[i][2].ToString();
                    amount = cartDetails.Rows[i][3].ToString();
                    idProducto = cartDetails.Rows[i][4].ToString();

                    for (int j = 0; j < promotionProducts.Rows.Count; j++)
                    {
                        string idProductoPromocion = promotionProducts.Rows[j][0].ToString();
                        if (idProductoPromocion == idProducto)
                        {
                            discount = promotionProducts.Rows[j][1].ToString();
                        }

                    }
                    
                    subTotal = Convert.ToDouble(priceProduct) * Convert.ToDouble(amount);
                    totalDiscount = subTotal * (Convert.ToDouble(discount) / 100);
                    subTotal = subTotal - totalDiscount;


                    if (discount == "0")
                    {
                        DgvCart.Rows.Add(idDetailCart,idProducto,nameProduct, priceProduct, amount,"0%",subTotal);
                    }
                    else{
                        DgvCart.Rows.Add(idDetailCart,idProducto,nameProduct, priceProduct, amount, discount+"%", subTotal);

                    }
                }

                foreach (DataGridViewRow row in DgvCart.Rows)
                {
                    totalToPay += Convert.ToDouble(row.Cells["SUBTOTAL"].Value);
                    
                }
                LblTotal.Text = totalToPay.ToString() + " USD";

            }
            else
            {
                MessageBox.Show("Carrito vacio");
            }

            cartDetails.Dispose();
            promotionProducts.Dispose();

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
            if (e.ColumnIndex.ToString()=="7")
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
            if (e.ColumnIndex.ToString() == "4")
            {
                if (DgvCart.Rows.Count > 0)
                {

                    if (DgvCart.CurrentRow.Cells[0].Value != null)
                    {
                        DataTable inventory = new DataTable();
                        int stock = 0;

                        string idProductSelected = DgvCart.CurrentRow.Cells[1].Value.ToString();
                        string amount = DgvCart.CurrentRow.Cells[4].Value.ToString();

                        inventory = db.Find("INVENTARIO", "CANTIDAD", "ID_PRODUCTO= '" + idProductSelected + "'");


                        if (inventory.Rows.Count > 0)
                        {
                            DataRow rowInventory = inventory.Rows[0];
                            stock = Convert.ToInt32(rowInventory["CANTIDAD"]);
                        }

                        if(Regex.IsMatch(amount, @"^\d+$"))
                        {
                            if (Convert.ToInt32(amount) > stock)
                            {
                                h.MsgWarning("No hay suficiente stock del producto");
                            }
                            else
                            {
                                string values = "CANTIDAD= '" +amount +"'";
                                string idDetailCart = DgvCart.CurrentRow.Cells[0].Value.ToString();
                                if (db.Update("CARRITO_DETALLE", values, "ID_CARRITO_DETALLE= '" + idDetailCart + "'") > 0)
                                {
                                    getDetailsCart();

                                }
                            }
                        }
                        else
                        {
                            h.MsgWarning("Ingresar cantidad en formato correcto");

                        }
                    }
                }

            }

        }
    }
}
