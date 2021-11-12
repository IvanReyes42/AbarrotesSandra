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
    public class ManejadorCompras
    {
        public DataSet ConsultarCompras(string nombre, string fecha)
        {
            AccesoADatosIvan AD = new AccesoADatosIvan();
            var Conjunto = new DataSet();
            Conjunto = AD.ConsultarCompras(nombre,fecha);
            return Conjunto;
        }
        public DataSet LlenarComboProductos()
        {
            AccesoADatosIvan AD = new AccesoADatosIvan();
            var Conjunto = new DataSet();
            Conjunto = AD.ConsultarProductos("");
            return Conjunto;
        }
        public DataSet LlenarComboProveedor()
        {
            AccesoADatosIvan AD = new AccesoADatosIvan();
            var Conjunto = new DataSet();
            Conjunto = AD.LlenarComboProveedor();
            return Conjunto;
        }
        public bool GuardarComprar(Compras c)
        {
            AccesoADatosIvan AD = new AccesoADatosIvan();
            if (AD.GuardarCompra(c))
                return true;
            else
                return false;
        }
        public bool ModificarCompra(Compras c, double cantidadactual)
        {
            AccesoADatosIvan AD = new AccesoADatosIvan();
            if (AD.ModificarCompras(c,cantidadactual))
                return true;
            else
                return false;
        }
    }
}
