using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public int Idusuario { get; set; }
        public string Usuario { get; set; }
        public string  Password { get; set; }
        public string  Rol { get; set; }
        public string Estatus { get; set; }
    }
}
