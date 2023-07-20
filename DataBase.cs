using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CarritoCompra
{
    internal class DataBase
    {
        //Propiedades de la clase DataBase
        SqlCommand com;//encargado de ejecutar las consultas en la bd
        SqlDataReader reader;
        DataTable recordset;
        string query;

        //cadena de conexion a la base de datos


        //Metodo Find
        //consulta la base de datos
        public DataTable Find(string table, string fields, string condition = "", string orderby = "")
        {
            recordset = new DataTable();


            if (condition == "" && orderby == "")
            {
                query = "Select " + fields + " from " + table;
            }
            else if (condition != "" && orderby == "")
            {
                query = "Select " + fields + " from " + table + " where " + condition;
            }
            else if (condition == "" && orderby != "")
            {
                query = "Select " + fields + " from " + table + " order by " + orderby;
            }
            else if (condition != "" && orderby != "")
            {
                query = "Select " + fields + " from " + table + " where " + condition + " order by " + orderby;
            }

            try
            {
                com = new SqlCommand(query, Connection.ConSql);
                Connection.OpenConnection();

                reader = com.ExecuteReader();
                recordset.Load(reader);

                reader.Close();
                com.Dispose();
                Connection.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Connection.EndsConnection();
            }
            return recordset;
        }
        //Fin Metodo Find

        //Metodo Save
        //inserta registros en la base de datos
        public int Save(string table, string fields, string values)
        {
            int ra = 0; //rowsaffected
            query = "Insert into " + table + "(" + fields + ") values(" + values + ")";
            try
            {
                com = new SqlCommand(query, Connection.ConSql);
                Connection.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Connection.CloseConnection();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
               Connection.EndsConnection();
            }
            return ra;
        }
        //fin Metodo Save

        //Metodo Update
        //Actualizar los registros de la base de datos
        public int Update(string table, string values, string condition = "")
        {
            int ra = 0; //rowsaffected
            if (condition == "")
            {
                query = "Update " + table + " set " + values;
            }
            else
            {
                query = "Update " + table + " set " + values + " where " + condition;
            }

            try
            {
                com = new SqlCommand(query, Connection.ConSql);
                Connection.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Connection.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Connection.EndsConnection();
            }
            return ra;
        }
        //Actualiza registros existentes
        //Fin Metodo Update

        //Metodo Destroy
        //Elimina registros de la base de datos
        public int Destroy(string table, string condition = "")
        {
            int ra = 0;
            if (condition == "")
            {
                query = "Delete from " + table;
            }
            else
            {
                query = "Delete from " + table + " where " + condition;
            }

            try
            {
                com = new SqlCommand(query, Connection.ConSql);
               Connection.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Connection.CloseConnection();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
               Connection.EndsConnection();
            }
            return ra;
        }
        //Fin Metodo Destroy
    }
}
