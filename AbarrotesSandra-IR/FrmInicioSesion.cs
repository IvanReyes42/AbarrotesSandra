using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace AbarrotesSandra_IR
{
    public partial class FrmInicioSesion : Form
    {
        ManejadorLogin ml = new ManejadorLogin();
        public static int IdUser; 
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text.Length >0 && txtPassword.Text.Length >0)
                {
                    Login();
                }
                else
                {
                    MessageBox.Show("Error usuario y/o contraseña no puede ir vacio");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al iniciar seción");
            }
        }
        public void Login()
        {
            var ListaUsuario = new List<Login>();
            ListaUsuario = ml.Login();
            string user, password, rol="";
            user = txtUsuario.Text;
            password = txtPassword.Text;
            int x = 0;
            

            foreach (var item in ListaUsuario)
            {
                if(user == item.Usuario && password == item.Password && item.Estatus == "Activo")
                {
                    IdUser = item.Idusuario;
                    rol = item.Rol;
                    x++;
                    
                }
            }
            if (x > 0)
            {
                txtUsuario.Clear();
                txtPassword.Clear();
                if(rol.Equals("Cajero"))
                {
                    //MessageBox.Show("Bienvenido Cajero");
                    Hide();
                    FrmPuntoDeVenta p = new FrmPuntoDeVenta();
                    p.Show();
                }
                else
                {
                    // MessageBox.Show("Bienvenido Administrador");
                    Hide();
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, de usuario y/o contraseña");
            }


        }
    }
}
