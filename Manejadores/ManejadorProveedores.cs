using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data;

namespace Manejadores
{
    public class ManejadorProveedores
    {
        AccesoDatosDaniel add = new AccesoDatosDaniel();

        public string GuardarProveedores(EntidadProveedores ep)
        {
            string mensaje;
            if (add.GuardarProveedores(ep))
            {
                mensaje = "Datos registrados correctamente.";
            }
            else
            {
                mensaje = "Error al registrar los datos.";
            }
            return mensaje;
        }

        public string ModificarProveedores(EntidadProveedores ep)
        {
            string mensaje;
            if (add.ModificarProveedores(ep))
            {
                mensaje = "Datos modificados correctamente.";
            }
            else
            {
                mensaje = "Error al modificar los datos.";
            }
            return mensaje;
        }

        public DataSet ConsultarProveedores(string razonSocial)
        {
            var Conjunto = new DataSet();
            try
            {
                Conjunto = add.ConsultarProveedores(razonSocial);
                return Conjunto;
            }
            catch (Exception)
            {
                return Conjunto;
            }
        }
    }
}
