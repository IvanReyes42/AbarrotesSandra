using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Manejadores
{

    public class ManejadorReportes
    {
        AccesoDatosDaniel add = new AccesoDatosDaniel();

        public DataSet ConsultarGastos(string fechaInicio, string fechaFin)
        {
            return add.ConsultarGastos(fechaInicio, fechaFin);
        }

        public string ConsultarTotalGastos(string fechaInicio, string fechaFin)
        {
            DataTable dt = new DataTable();
            dt = add.ConsultarTotalGastos(fechaInicio, fechaFin).Tables[0];
            DataRow r = dt.Rows[0];
            return r["Total"].ToString();
        }

        public DataSet ConsultarVentas(string fechaInicio, string fechaFin)
        {
            return add.ConsultarVentas(fechaInicio, fechaFin);
        }

        public string ConsultarTotalVentas(string fechaInicio, string fechaFin)
        {
            DataTable dt = new DataTable();
            dt = add.ConsultarTotalVentas(fechaInicio, fechaFin).Tables[0];
            DataRow r = dt.Rows[0];
            return r["Total"].ToString();
        }

        public DataSet ConsultarInventario()
        {
            return add.ConsultarInventario();
        }
    }
}
