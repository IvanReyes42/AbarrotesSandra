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
    public partial class FrmCategorias : Form
    {
        Categorias ca = new Categorias();
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
        }
        public void LlenarData(string Nombre)
        {
            try
            {
                var MC = new ManejadorCategorias();
                var Conjunto = new DataSet();
                Conjunto = MC.MostrarCategorias(Nombre);
                dgvCategoria.DataSource = Conjunto.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar los datos");
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            LlenarData("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarData(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            GrupoCategoria.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            GrupoCategoria.Enabled = false;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length != 0 && txtNombre.Text != null)
                {
                    var MC = new ManejadorCategorias();
                    Categorias c = new Categorias();
                    c.IdCategoria = 0;
                    c.Nombre = txtNombre.Text;

                    if (MC.AgregarCategoria(c))
                    {
                        MessageBox.Show("Dato Agregado correctamente");
                        Limpiar();
                        GrupoCategoria.Enabled = false;
                        btnNuevo.Enabled = true;
                        btnEliminar.Enabled = true;
                        LlenarData("");
                    }
                    else
                    {
                        MessageBox.Show("Erro al guardar los datos");
                    }
                }
                else
                {
                    MessageBox.Show("El campo nombre no puede ir vacio");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar los datos");
            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = e.RowIndex;
                ca.IdCategoria = int.Parse(dgvCategoria.Rows[fila].Cells[0].Value.ToString());
                ca.Nombre = dgvCategoria.Rows[fila].Cells[1].Value.ToString();
                txtNombre.Text = ca.Nombre;
                txtID.Text = ca.IdCategoria.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ca.IdCategoria > 0)
            {
                DialogResult rs = MessageBox.Show("¿Estas seguro de eliminar la categoria " + ca.Nombre + "?", "!Atencion!", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    var MC = new ManejadorCategorias();
                    if (MC.EliminarCategoria(ca))
                    {
                        MessageBox.Show("Categoria eliminada correctamente");
                        Limpiar();
                        LlenarData("");
                    }
                    else
                    {
                        MessageBox.Show("Error no puedes eliminar la categoria por que cuenta con registros en la ventana productos");
                    }
                }

            }
            else
                MessageBox.Show("Por favor seleccione un valor para eliminar");
        }
    }
}
