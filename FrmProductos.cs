using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CarritoCompra
{
    public partial class FrmProductos : Form
    {
        DataBase db = new DataBase();
        DataTable recordset;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            getProducts();
            fillCategories();
            fillBrands();
        }

        private void fillCategories()
        {
            recordset = new DataTable();
            CmbCategory.DataSource = db.Find("PRODUCTO_CATEGORIAS", "*", "", "DESCRIPCION_CATEGORIA");
            CmbCategory.ValueMember = "ID_CATEGORIA";
            CmbCategory.DisplayMember = "DESCRIPCION_CATEGORIA";
            CmbCategory.SelectedIndex = -1;
        }

        private void fillBrands()
        {
            recordset = new DataTable();
            CmbBrand.DataSource = db.Find("MARCAS", "*", "", "DESCRIPCION");
            CmbBrand.ValueMember = "ID_MARCA";
            CmbBrand.DisplayMember = "DESCRIPCION";
            CmbBrand.SelectedIndex = -1;
        }

        private void TxtSearcher_TextChanged(object sender, EventArgs e)
        {
            getProducts(TxtSearcher.Text);
        }

        private void getProducts(string search = "", string category = "", string brand = "")
        {
            DataTable products = new DataTable();
            string data;
            data = "A.ID_PRODUCTO,A.NOMBRE_PRODUCTO,A.DESCRIPCION_PRODUCTO, A.PRECIO_PRODUCTO,B.DESCRIPCION AS MARCA FROM PRODUCTOS A INNER JOIN MARCAS B ON(A.ID_MARCA= B.ID_MARCA)";
            if (search == "" && category == "" && brand == "")
            {
                products = db.JoinTables(data, "", "A.ID_PRODUCTO");
            }
            else if (search != "" && category == "" && brand == "")
            {
                string condition = "A.NOMBRE_PRODUCTO LIKE '%" + search + "%'";
                products = db.JoinTables(data, condition, "A.ID_PRODUCTO");

            }
            else if (search == "" && category == "" && brand != "")
            {
                string condition = "A.ID_MARCA=" + brand + "";
                products = db.JoinTables(data, condition, "A.ID_PRODUCTO");

            }
            else if (search == "" && category != "" && brand == "")
            {
                string condition = "A.ID_CATEGORIA=" + category + "";
                products = db.JoinTables(data, condition, "A.ID_PRODUCTO");

            }
            else if (search == "" && category != "" && brand != "")
            {
                string condition = "A.ID_CATEGORIA=" + category + " AND A.ID_MARCA= " + brand + "";
                products = db.JoinTables(data, condition, "A.ID_PRODUCTO");

            }
            else if (search != "" && category != "" && brand != "")
            {
                string condition = "A.NOMBRE_PRODUCTO LIKE '%" + search + "%' AND A.ID_CATEGORIA=" + category + " AND A.ID_MARCA= " + brand + "";
                products = db.JoinTables(data, condition, "A.ID_PRODUCTO");

            }

            DgvProductos.Rows.Clear();
            if (products.Rows.Count > 0)
            {
                int i;
                for (i = 0; i < products.Rows.Count; i++)
                {
                    string idProduct,nameProduct, descriptionProduct, priceProduct,brandProduct;
                    idProduct= products.Rows[i][0].ToString();
                    nameProduct = products.Rows[i][1].ToString();
                    descriptionProduct = products.Rows[i][2].ToString();
                    priceProduct = products.Rows[i][3].ToString();
                    brandProduct =products.Rows[i][4].ToString();

                   DgvProductos.Rows.Add(idProduct,nameProduct,descriptionProduct,priceProduct,brandProduct);
                }

                DgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados");
            }

            products.Dispose();

        }
        
        private void CmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (CmbBrand.Text != "")
            {
                getProducts("", CmbCategory.SelectedValue.ToString(), CmbBrand.SelectedValue.ToString());
            }
            else
            {
                getProducts("",CmbCategory.SelectedValue.ToString(),"");
            }
            

        }

        private void CmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CmbCategory.Text != "")
            {
                getProducts("", CmbCategory.SelectedValue.ToString(), CmbBrand.SelectedValue.ToString());
            }
            else
            {
                getProducts("", "", CmbBrand.SelectedValue.ToString());
            }
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProductos.Rows.Count > 0)
            {
                FrmVerProducto verProducto = new FrmVerProducto();

                FrmVerProducto.idProductoSelected= DgvProductos.CurrentRow.Cells[0].Value.ToString();
                this.Hide();
                verProducto.ShowDialog();

                
            }

        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PbxGoCart_Click(object sender, EventArgs e)
        {
            if (Cart.numberOfProducts>0)
            {
                FrmCarrito cart = new FrmCarrito();
                cart.Show();
                this.Hide();

            }
        }
    }
}
