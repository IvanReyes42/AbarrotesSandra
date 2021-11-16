using AccesoDatos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        AccesoDatosDaniel add = new AccesoDatosDaniel();

        public string GuardarUsuarios(EntidadUsuarios eu)
        {
            string mensaje;
            if (add.GuardarUsuarios(eu))
            {
                mensaje = "Datos registrados correctamente.";
            }
            else
            {
                mensaje = "Error al registrar los datos.";
            }
            return mensaje;
        }

        public string ModificarUsuarios(EntidadUsuarios eu)
        {
            string mensaje;
            if (add.ModificarUsuarios(eu))
            {
                mensaje = "Datos modificados correctamente.";
            }
            else
            {
                mensaje = "Error al modificar los datos.";
            }
            return mensaje;
        }

        public string EliminarUsuarios(EntidadUsuarios eu)
        {
            return add.EliminarUsuarios(eu);
        }

        public DataSet ConsultarUsuarios(string usuario)
        {
            var Conjunto = new DataSet();
            try
            {
                Conjunto = add.ConsultarUsuarios(usuario);
                return Conjunto;
            }
            catch (Exception)
            {
                return Conjunto;
            }
        }

        public bool validarContrasena(TextBox tb1, TextBox tb2)
        {
            bool r = false;

            if (tb1.Text == tb2.Text)
            {
                r = true;
            }
            return r;
        }
    }
}
