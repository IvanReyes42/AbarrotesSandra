using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TicketVenta
    {
        public string Fecha { get; set; }
        public double Total { get; set; }
        public int FkIdUsuario { get; set; }
    }
}
