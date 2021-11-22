using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class AccesoDatosDaniel
    {
        SqlConnection conexion = new SqlConnection
               //("data source=DANIELHP; Initial Catalog=AbarrotesSandra; User ID=sa; Password=Knj89%36L154ÑvR;");
               ("data source=IVANREYESPC\\IVANREYES; Initial Catalog=Abarrotessandra; User ID=sa; Password=LaVacaLola42");

        public bool GuardarUsuarios(EntidadUsuarios eu)
        {
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ModificarUsuarios(EntidadUsuarios eu)
        {
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string EliminarUsuarios(EntidadUsuarios eu)
        {
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

        //---------------------------------------------METODOS HORARIOS----------------------------------------------------------------------------------

        public bool GuardarHorarios(EntidadHorarios eh)
        {
            try
            {
                var insertar = new SqlCommand("EXEC GuardarHorarios '" + eh.Nombre + "', '" + eh.ApellidoP + "', '" + eh.ApellidoM + "', '" + eh.Fecha + "'," +
                    "'" + eh.Turno + "'", conexion);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ModificarHorarios(EntidadHorarios eh)
        {
            try
            {
                var insertar = new SqlCommand("EXEC ModificarHorarios '" + eh.ID + "','" + eh.Nombre + "', '" + eh.ApellidoP + "', '" + eh.ApellidoM + "', '" + eh.Fecha + "'," +
                    "'" + eh.Turno + "', ''", conexion);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string EliminarHorarios(EntidadHorarios eh)
        {
            try
            {
                var insertar = new SqlCommand("EXEC EliminarHorarios '" + eh.ID + "', ''", conexion);
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

        public DataSet ConsultarHorarios(string fecha)
        {
            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarHorarios '" + fecha + "'", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "Horarios");
                conexion.Close();
                return conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return conjunto;
            }
        }

        public DataSet ListarEmpleados()
        {
            var Conjunto = new DataSet();
            try
            {
                var Consultar = new SqlDataAdapter("EXEC ListarEmpleados", conexion);

                conexion.Open();
                Consultar.Fill(Conjunto, "Usuarios");
                conexion.Close();
                return Conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return Conjunto;
            }
        }

        //---------------------------------------------------------METODOS PROVEEDORES-----------------------------------------------------------------

        public bool GuardarProveedores(EntidadProveedores ep)
        {
            try
            {
                var insertar = new SqlCommand("EXEC GuardarProveedores '" + ep.Nombre + "', '" + ep.ApellidoP + "', '" + ep.ApellidoM + "', '" + ep.Telefono + "'," +
                    "'" + ep.RFC + "', '" + ep.RazonSocial + "', '" + ep.Estatus + "', ''", conexion);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ModificarProveedores(EntidadProveedores ep)
        {
            try
            {
                var insertar = new SqlCommand("EXEC ModificarProveedores '" + ep.ID + "','" + ep.Nombre + "', '" + ep.ApellidoP + "', '" + ep.ApellidoM + "', '" + ep.Telefono + "'," +
                    "'" + ep.RFC + "', '" + ep.RazonSocial + "', '" + ep.Estatus + "'", conexion);
                conexion.Open();
                insertar.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataSet ConsultarProveedores(string razonSocial)
        {
            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarProveedores '" + razonSocial + "'", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "Proveedores");
                conexion.Close();
                return conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return conjunto;
            }
        }

        //-----------------------------------------------------------------------METODOS REPORTES----------------------------------------------------------

        public DataSet ConsultarGastos(string fechaInicio, string fechaFin)
        {
            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarGastos '" + fechaInicio + "', '" + fechaFin + "'", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "Productos");
                conexion.Close();
                return conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return conjunto;
            }
        }

        public DataSet ConsultarTotalGastos(string fechaInicio, string fechaFin)
        {
            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarTotalGastos '" + fechaInicio + "', '" + fechaFin + "'", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "Compras");
                conexion.Close();
                return conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return conjunto;
            }
        }

        public DataSet ConsultarVentas(string fechaInicio, string fechaFin)
        {
            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarVentas '" + fechaInicio + "', '" + fechaFin + "'", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "Productos");
                conexion.Close();
                return conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return conjunto;
            }
        }

        public DataSet ConsultarTotalVentas(string fechaInicio, string fechaFin)
        {
            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarTotalVentas '" + fechaInicio + "', '" + fechaFin + "'", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "TicketVenta");
                conexion.Close();
                return conjunto;
            }
            catch (Exception)
            {
                conexion.Close();
                return conjunto;
            }
        }

        public DataSet ConsultarInventario()
        {
            var conjunto = new DataSet();

            try
            {
                var consultar = new SqlDataAdapter("EXEC ConsultarInventario", conexion);
                conexion.Open();
                consultar.Fill(conjunto, "Productos");
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
