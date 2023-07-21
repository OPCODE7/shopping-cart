using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoCompra
{
    internal class Helper
    {
        //Metodo MsgWarning
        //Envia una advertencia a pantalla en cuadro de dialogo 
        public void MsgWarning(string msg)
        {
            MessageBox.Show(msg, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Fin Metodo MsgWarning

        //Metodo MsgSuccess
        //Envia un cuadro de dialogo a pantalla indicando que un proceso se realizo exitosamente
        public void MsgSuccess(string msg)
        {
            MessageBox.Show(msg, "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Fin MsgSuccess


        //Metodo SanitizeStr
        public string SanitizeStr(string str)
        {
            string strout = "";//cadena de salida

            //arreglo de caracteres prohibidos
            string[] forbiddenchars = { "'", "=", "-", ">", ";", "/", "!" };
            int i, j; //variables para interar ciclos
            int coincidences;// variable de coincidencias

            for (i = 0; i < str.Length; i++)
            {
                coincidences = 0;
                for (j = 0; j < forbiddenchars.Length; j++)
                {
                    coincidences = str.Substring(i, 1) == forbiddenchars[j] ? coincidences + 1 : coincidences + 0;
                }
                strout = coincidences == 0 ? strout + str.Substring(i, 1) : strout;

            }
            return strout;



        }
        //Fin Metodo SanitizeStr


        //Metodo GetOnlyNumbers
        //Bloquear cualquier caracter que no sea numero
        public Boolean GetOnlyNumbers(KeyPressEventArgs e)
        {
            Boolean resp = false;
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                resp = true;

            }

            return resp;

        }
        //Fin GetOnlyNumbers


        //MetodoMsgQuestion
        //Manda un cuadro de dialogo en el cual se confirma si se quiere realizar algun proceso
        public string MsgQuestion(string msg)
        {
            ; string Op = "N";
            if (MessageBox.Show(msg, "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Op = "S";

            }
            return Op;

        }
        //FinMetodoMsgQuestion

    }
}

