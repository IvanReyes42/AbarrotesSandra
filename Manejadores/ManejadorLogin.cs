using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorLogin
    {
        public List<Login> Login()
        {
            var AD = new AccesoADatosIvan();
            var dt = new DataTable();
            var ListaUsuario = new List<Login>();
            dt = AD.Login();
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Login l = new Login();
                    l.Idusuario = int.Parse(dt.Rows[i]["FkIdUser"].ToString());
                    l.Usuario = dt.Rows[i]["Usuario"].ToString();
                    l.Password = dt.Rows[i]["Contraseña"].ToString();
                    l.Rol = dt.Rows[i]["Rol"].ToString();
                    l.Estatus = dt.Rows[i]["Estatus"].ToString();
                    ListaUsuario.Add(l);
                }
                return ListaUsuario;
            }
            catch (Exception)
            {
                return ListaUsuario;
            }

        }
    }
}
