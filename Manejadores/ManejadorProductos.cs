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
    public class ManejadorProductos
    {
        public DataSet ConsultarProductos(string nombre)
        {
            var AD = new AccesoADatosIvan();
            var Conjunto = new DataSet();
            Conjunto = AD.ConsultarProductos(nombre);
            return Conjunto;
        }
        public DataSet LlenarComboCategoria()
        {
            var AD = new AccesoADatosIvan();
            var Conjunto = new DataSet();
            Conjunto = AD.ConsultarCategorias("");
            return Conjunto;
        }
        public bool AgregarProductos(Productos productos)
        {
            var AD = new AccesoADatosIvan();
            if (AD.AgregarProductos(productos))
                return true;
            else
                return false;
        }
        public bool ModificarProductos(Productos productos)
        {
            var AD = new AccesoADatosIvan();
            if (AD.ModificarProductos(productos))
                return true;
            else
                return false;
        }
    }
}
