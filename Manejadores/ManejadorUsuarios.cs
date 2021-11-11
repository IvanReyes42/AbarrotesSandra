using AccesoDatos;
using Entidades;
using System;
using System.Data;

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
    }
}
