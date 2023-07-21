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
    public partial class FrmLogin : Form
    {
        Helper h = new Helper();
        DataBase db = new DataBase();

        bool isvalid;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Validator();
            if (isvalid)
            {
                //Sanitizando cada control
                string username = h.SanitizeStr(TxtUserName.Text.Trim());
                string password = h.SanitizeStr(TxtPwd.Text.Trim());

                DataTable user = new DataTable();
                user = db.Find("USUARIO", "*", "NOMBRE_USUARIO= '" + username + "'");

                if (user.Rows.Count > 0)
                {
                    DataRow infouser = user.Rows[0];

                    if (username == infouser["NOMBRE_USUARIO"].ToString() &&
                         password == infouser["CLAVE"].ToString())
                    {

                        User.IDUSER = infouser["ID_USUARIO"].ToString();
                        User.USERNAME = username;

                        FrmProductos productos = new FrmProductos();
                        this.Hide();
                        productos.Show();

                    }
                    else
                    {
                        h.MsgWarning("Credenciales invalidas, contactar con el administrador!");

                    }

                }
                else
                {
                    h.MsgWarning("Usuario no existe,verificar!");
                }
            }

           
        }

        private void Validator()
        {
            isvalid = true;
            if (TxtUserName.Text.Trim().Length == 0)
            {
                h.MsgWarning("Ingresar nombre de usuario!");
                TxtUserName.Focus();
                isvalid = false;
                return;
            }

            if (TxtPwd.Text.Trim().Length == 0)
            {
                h.MsgWarning("Ingresar clave de acceso!");
                TxtPwd.Focus();
                isvalid = false;
                return;

            }

        }
    }
}
