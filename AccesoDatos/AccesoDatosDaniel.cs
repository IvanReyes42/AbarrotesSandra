using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class AccesoDatosDaniel
    {
        public bool GuardarUsuarios(EntidadUsuarios eu)
        {
            var conexion = new SqlConnection
              //("data source=DANIELHP; Initial Catalog=AbarrotesSandra; User ID=sa; Password=Knj89%36L154ÑvR;");
              ("data source=IVANREYESPC\\IVANREYES; Initial Catalog=Abarrotessandra; User ID=sa; Password=LaVacaLola42");
            try
            {
                var insertar = new SqlCommand("EXEC GuardarUsuarios '" + eu.Nombre + "', '" + eu.ApellidoP + "', '" + eu.ApellidoM + "', '" + eu.Usuario + "'," +
                    "'" + eu.Email + "', '" + eu.Telefono + "', '" + eu.Rol + "', '" + eu.Estatus + "', '" + eu.Contrasena + "', ''", conexion);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ModificarUsuarios(EntidadUsuarios eu)
        {
            var conexion = new SqlConnection
              //("data source=DANIELHP; Initial Catalog=AbarrotesSandra; User ID=sa; Password=Knj89%36L154ÑvR;");
              ("data source=IVANREYESPC\\IVANREYES; Initial Catalog=Abarrotessandra; User ID=sa; Password=LaVacaLola42");
            try
            {
                var insertar = new SqlCommand("EXEC ModificarUsuarios '" + eu.ID + "','" + eu.Nombre + "', '" + eu.ApellidoP + "', '" + eu.ApellidoM + "', '" + eu.Usuario + "'," +
                    "'" + eu.Email + "', '" + eu.Telefono + "', '" + eu.Rol + "', '" + eu.Estatus + "'", conexion);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string EliminarUsuarios(EntidadUsuarios eu)
        {
            var conexion = new SqlConnection
            // ("data source=DANIELHP; Initial Catalog=AbarrotesSandra; User ID=sa; Password=Knj89%36L154ÑvR;");
             ("data source=IVANREYESPC\\IVANREYES; Initial Catalog=Abarrotessandra; User ID=sa; Password=LaVacaLola42");
            try
            {
                var insertar = new SqlCommand("EXEC EliminarUsuarios '" + eu.ID + "', ''", conexion);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                string mensaje = insertar.Parameters["@ParametroSalida"].Value.ToString();
                return mensaje;
            }
            catch (Exception ex)
            {
                conexion.Close();
                return ex.Message;
            }
        }

        public DataSet ConsultarUsuarios(string usuario)
        {
            var conexion = new SqlConnection
              //("data source=DANIELHP; Initial Catalog=AbarrotesSandra; User ID=sa; Password=Knj89%36L154ÑvR;");
              ("data source=IVANREYESPC\\IVANREYES; Initial Catalog=Abarrotessandra; User ID=sa; Password=LaVacaLola42");

            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarUsuarios '" + usuario + "'", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "Usuarios");
                conexion.Close();
                return conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return conjunto;
            }
        }
    }
}
