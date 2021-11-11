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
    public class ManejadorCategorias
    {
        public DataSet MostrarCategorias(string Nombre)
        {
            var AD = new AccesoADatosIvan();
            var Conjunto = new DataSet();
            Conjunto = AD.ConsultarCategorias(Nombre);
            return Conjunto;
        }
        public bool AgregarCategoria(Categorias categoria)
        {
            var AD = new AccesoADatosIvan();
            if (AD.AgregarCategoria(categoria))
                return true;
            else
                return false;
        }
        public bool EliminarCategoria(Categorias categoria)
        {
            var AD = new AccesoADatosIvan();
            if (AD.EliminarCategoria(categoria))
                return true;
            else
                return false;
        }
    }
}
