using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }
        public double Precio { get; set; }
        public int FkIdCategoria { get; set; }
        public string Estatus { get; set; }
        public double Cantidad { get; set; }
        public double StockMinimo { get; set; }
    }
}
