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
    public partial class FrmVerProducto : Form
    {
        public static string idProductoSelected;
        DataBase db= new DataBase();
        public FrmVerProducto()
        {
            InitializeComponent();
        }

        private void FrmVerProducto_Load(object sender, EventArgs e)
        {
            getProducto();

        }


        private void getProducto()
        {
            DataTable product = new DataTable();
            string data = "A.NOMBRE_PRODUCTO,A.DESCRIPCION_PRODUCTO,A.PRECIO_PRODUCTO,B.DESCRIPCION AS MARCA, C.DESCRIPCION AS MODELO FROM PRODUCTOS A INNER JOIN MARCAS B ON(A.ID_MARCA = B.ID_MARCA) INNER JOIN MODELO C ON(A.ID_MODELO = C.ID_MODELO)";

            product = db.JoinTables(data,"ID_PRODUCTO= '" + idProductoSelected + "'");

            if (product.Rows.Count > 0)
            {
                DataRow rowedit = product.Rows[0];
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
            FrmProductos productos = new FrmProductos();
            if (productos.LblShoppingCart.Text=="0")
            {
                //añadir registro a la tabla carrito y seguido de esto a la tabla carrito detalle

            }
            else
            {
                //añadir registros solo a la tabla carrito detalle tomando en cuenta que ya se ha generado un carrito de compra asociar estos registros a ese carrito
            }
        }
    }
}
