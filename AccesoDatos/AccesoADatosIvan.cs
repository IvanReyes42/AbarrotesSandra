using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class AccesoADatosIvan
    {
        SqlConnection Conexion = new SqlConnection
                ("data source=IVANREYESPC\\IVANREYES; Initial Catalog=Abarrotessandra; User ID=sa; Password=LaVacaLola42");
        public DataSet ConsultarCategorias(string Nombre)
        {
            var Conjunto = new DataSet();
            try
            {
                var Consultar = new SqlDataAdapter("EXEC MostrarCategorias'" + Nombre + "'", Conexion);

                Conexion.Open();
                Consultar.Fill(Conjunto, "Categorias");
                Conexion.Close();
                return Conjunto;
            }
            catch (Exception ex)
            {
                Conexion.Close();
                return Conjunto;
            }
        }
        public bool AgregarCategoria(Categorias categoria)
        {
            try
            {

                var Insertar = new SqlCommand("EXEC AgregarCategoria '" +
                    categoria.Nombre + "'", Conexion);
                Conexion.Open();
                Insertar.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                Conexion.Close();
                return false;
            }
        }

        public bool EliminarCategoria(Categorias categoria)
        {
            try
            {

                var Insertar = new SqlCommand("EXEC EliminarCategoria '" +
                    categoria.IdCategoria + "'", Conexion);


                Conexion.Open();
                Insertar.ExecuteNonQuery();
                Conexion.Close();

                return true;

            }
            catch (Exception ex)
            {

                Conexion.Close();
                return false;
            }
        }
        ///CRUD INVENTARIO
        public DataSet ConsultarProductos(string nombre)
        {
            var Conjunto = new DataSet();
            try
            {
                var Consultar = new SqlDataAdapter("EXEC MostrarProductos'" + nombre + "'", Conexion);

                Conexion.Open();
                Consultar.Fill(Conjunto, "Productos");
                Conexion.Close();
                return Conjunto;
            }
            catch (Exception ex)
            {
                Conexion.Close();
                return Conjunto;
            }
        }
        public bool AgregarProductos(Productos p)
        {
            try
            {
                var Insertar = new SqlCommand("EXEC AgregarProductos'" +
                    p.Nombre + "','"+p.Descripcion+"','"+p.Precio+"','"+p.FkIdCategoria+"','"+p.Estatus+"','"+p.StockMinimo+ "', ''", Conexion);
                Conexion.Open();
                Insertar.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception)
            {
                Conexion.Close();
                return false;
            }
        }
        public bool ModificarProductos(Productos p)
        {
            try
            {
                var Insertar = new SqlCommand("EXEC ModificarProductos'" +
                    p.IdProducto+"','"+p.Nombre + "','" + p.Descripcion + "','" + p.Precio + "','" + p.FkIdCategoria + "','" + p.Estatus + "','" +p.Cantidad+"','"+p.StockMinimo + "'", Conexion);
                Conexion.Open();
                Insertar.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception)
            {
                Conexion.Close();
                return false;
            }
        }
    }
}
