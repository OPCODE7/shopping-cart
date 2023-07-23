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
    public partial class FrmVerProducto : Form
    {
        public static string idProductoSelected;
        DataBase db= new DataBase();
        Helper h = new Helper();
        FrmProductos productos = new FrmProductos();


        public FrmVerProducto()
        {
            InitializeComponent();
        }

        private void FrmVerProducto_Load(object sender, EventArgs e)
        {
            getProducto();
            this.Text += $"|{User.USERNAME}";

        }


        private void getProducto()
        {
            DataTable product = new DataTable();
            string pathApp= Application.StartupPath.ToString();
            string pathImages = pathApp.Substring(0, pathApp.Length - 9);




            string data = "A.NOMBRE_PRODUCTO,A.DESCRIPCION_PRODUCTO,A.PRECIO_PRODUCTO,B.DESCRIPCION AS MARCA,D.URL_IMAGEN, C.DESCRIPCION AS MODELO FROM PRODUCTOS A INNER JOIN MARCAS B ON(A.ID_MARCA = B.ID_MARCA) INNER JOIN MODELO C ON(A.ID_MODELO = C.ID_MODELO) INNER JOIN PRODUCTO_IMAGENES D ON (A.ID_PRODUCTO=D.ID_PRODUCTO)";

            product = db.JoinTables(data,"A.ID_PRODUCTO= '" + idProductoSelected + "'");

            if (product.Rows.Count > 0)
            {
                DataRow rowedit = product.Rows[0];
                PbxProductImage.Image = Image.FromFile(pathImages + rowedit["URL_IMAGEN"].ToString());
                LblNameProduct.Text = rowedit["NOMBRE_PRODUCTO"].ToString();
                LblPrice.Text = rowedit["PRECIO_PRODUCTO"].ToString() + "USD";
                LblDescriptionProduct.Text= rowedit["DESCRIPCION_PRODUCTO"].ToString();
                LblBrand.Text= rowedit["MARCA"].ToString();
                LblModel.Text = rowedit["MODELO"].ToString();

            }
            else
            {
                MessageBox.Show("Error no se encontro informacion");
            }

        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            DataTable inventory= new DataTable();
            int stock= 0;

            inventory = db.Find("INVENTARIO","CANTIDAD","ID_PRODUCTO= '"+idProductoSelected+"'");


            if (inventory.Rows.Count>0)
            {
                DataRow rowInventory = inventory.Rows[0];
                stock = Convert.ToInt32(rowInventory["CANTIDAD"]);
            }

            if (Regex.IsMatch(TxtCantidad.Text.Trim(), @"^\d+$"))
            {
                if (Convert.ToInt32(TxtCantidad.Text.Trim()) > stock)
                {
                    h.MsgWarning("No hay suficiente stock del producto");

                }
                else
                {


                    if (Cart.numberOfProducts == 0)
                    {


                        //añadir registro a la tabla carrito y seguido de esto a la tabla carrito detalle


                        if (db.Save("CARRITO", "ID_USUARIO", User.IDUSER) > 0)
                        {
                            Cart.numberOfProducts++;
                            productos.LblShoppingCart.Text = Cart.numberOfProducts.ToString();
                            //h.MsgSuccess("El registro se realizo correctamente");
                            DataTable cart = new DataTable();
                            string idCart = "";
                            cart = db.Find("CARRITO", " TOP 1 ID_CARRITO", "", "ID_CARRITO DESC");

                            if (cart.Rows.Count > 0)
                            {
                                DataRow rowCart = cart.Rows[0];
                                idCart = rowCart["ID_CARRITO"].ToString();
                                Cart.numberCart = rowCart["ID_CARRITO"].ToString();
                            }

                            string columns, data;
                            columns = "ID_CARRITO,ID_PRODUCTO,ID_USUARIO,CANTIDAD";
                            data = "" + idCart + "," + idProductoSelected + "," + User.IDUSER + "," + TxtCantidad.Text + "";

                            if (db.Save("CARRITO_DETALLE", columns, data) > 0)
                            {
                                h.MsgSuccess("Producto agregado al carrito");
                            }

                        }

                    }
                    else
                    {

                        // añadir registros solo a la tabla carrito detalle tomando en cuenta que ya se ha generado un carrito de compra asociar estos registros a ese carrito
                        DataTable cart = new DataTable();
                        string idCart = "";
                        cart = db.Find("CARRITO", " TOP 1 ID_CARRITO", "", "ID_CARRITO DESC");

                        if (cart.Rows.Count > 0)
                        {
                            DataRow rowCart = cart.Rows[0];
                            idCart = rowCart["ID_CARRITO"].ToString();
                        }

                        string columns, data;
                        columns = "ID_CARRITO,ID_PRODUCTO,ID_USUARIO,CANTIDAD";
                        data = "" + idCart + "," + idProductoSelected + "," + User.IDUSER + "," + TxtCantidad.Text + "";

                        if (db.Save("CARRITO_DETALLE", columns, data) > 0)
                        {
                            Cart.numberOfProducts++;
                            productos.LblShoppingCart.Text = Cart.numberOfProducts.ToString();
                            h.MsgSuccess("Producto agregado al carrito");
                        }

                    }
                    this.Hide();
                    productos.Show();
                }
            }
            else
            {
                h.MsgWarning("Ingresar cantidad en formato correcto, solo números");
                TxtCantidad.Focus();
            }
        }

        private void FrmVerProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            productos.Show();
        }

        private void TxtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddToCart.PerformClick();
            }
        }
    }
}
