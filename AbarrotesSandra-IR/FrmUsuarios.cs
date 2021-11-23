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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu = new ManejadorUsuarios();
        EntidadUsuarios eu = new EntidadUsuarios(0, "", "", "", "", "", "", "", "", "");
        int fila = 0;
        string r;
        int id = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            try
            {
                dgvUsuarios.DataSource = mu.ConsultarUsuarios(txtBuscar.Text).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al mostrar datos de los Usuarios");
            }
        }

        public void GenerarDatos(int fila)
        {
            try
            {
                eu.ID = int.Parse(dgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                eu.Nombre = dgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                eu.ApellidoP = dgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                eu.ApellidoM = dgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                eu.Usuario = dgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                eu.Email = dgvUsuarios.Rows[fila].Cells[5].Value.ToString();
                eu.Telefono = dgvUsuarios.Rows[fila].Cells[6].Value.ToString();
                eu.Rol = dgvUsuarios.Rows[fila].Cells[7].Value.ToString();
                eu.Estatus = dgvUsuarios.Rows[fila].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar entidad.");
            }
        }

        public void limpiarCajas()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtUsuario.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtContraseña.Clear();
            txtConfContraseña.Clear();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal.op = 0;
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
            groupBox1.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtContraseña.Enabled = true;
            txtConfContraseña.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id = eu.ID;
            if (id > 0)
            {
                groupBox1.Enabled = true;
                txtContraseña.Enabled = false;
                txtConfContraseña.Enabled = false;

                txtID.Text = eu.ID.ToString();
                txtNombre.Text = eu.Nombre;
                txtApellidoPaterno.Text = eu.ApellidoP;
                txtApellidoMaterno.Text = eu.ApellidoM;
                txtUsuario.Text = eu.Usuario;
                txtEmail.Text = eu.Email;
                txtTelefono.Text = eu.Telefono;

                int indexrol = cmbRol.FindString(eu.Rol);
                int indexes = cmbEstatus.FindString(eu.Estatus);
                cmbRol.SelectedIndex = indexrol;
                cmbEstatus.SelectedIndex = indexes;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder modificar.", "Error al modificar.");
            }
        }
        
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            GenerarDatos(fila);
            LlenarDatos();
        }
        public void LlenarDatos()
        {
            txtID.Text = eu.ID.ToString();
            txtNombre.Text = eu.Nombre;
            txtApellidoPaterno.Text = eu.ApellidoP;
            txtApellidoMaterno.Text = eu.ApellidoM;
            txtUsuario.Text = eu.Usuario;
            txtEmail.Text = eu.Email;
            txtTelefono.Text = eu.Telefono;

            int indexrol = cmbRol.FindString(eu.Rol);
            int indexes = cmbEstatus.FindString(eu.Estatus);
            cmbRol.SelectedIndex = indexrol;
            cmbEstatus.SelectedIndex = indexes;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (eu.ID > 0)
            {
                DialogResult rs = MessageBox.Show("¿Estas seguro de eliminar el usuario " + eu.Nombre + " " + eu.ApellidoP + " " + eu.ApellidoM + "?", "!Atención", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    r = mu.EliminarUsuarios(eu);
                    MessageBox.Show("Usuario eliminado correctamente");
                    eu.ID = 0;
                    fila = 0;
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila que no este vacia");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                string m = mu.ModificarUsuarios(new EntidadUsuarios(int.Parse(txtID.Text), txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtUsuario.Text,
                    txtEmail.Text, txtTelefono.Text, cmbRol.Text, cmbEstatus.Text, "")); 
                MessageBox.Show(m);
                Actualizar();
                limpiarCajas();
                groupBox1.Enabled = false;
                id = 0;
            }
            else
            {
                if (mu.validarContrasena(txtContraseña, txtConfContraseña))
                {
                    string m = mu.GuardarUsuarios(new EntidadUsuarios(0, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtUsuario.Text,
                   txtEmail.Text, txtTelefono.Text, cmbRol.Text, cmbEstatus.Text, txtContraseña.Text));
                    MessageBox.Show(m);
                    Actualizar();
                    limpiarCajas();
                    groupBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCajas();
            groupBox1.Enabled = false;
            id = 0;
        }
    }
}
