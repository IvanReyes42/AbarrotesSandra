using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compras
    {
        public int IdCompras { get; set; }
        public string  Fecha { get; set; }
        public int FkIdProveedor { get; set; }
        public int FkIdInventario { get; set; }
        public double  Cantidad { get; set; }
        public double Total { get; set; }
    }
}
