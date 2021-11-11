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
    public partial class FrmInventario : Form
    {
        ManejadorProductos mp = new ManejadorProductos();
        int Id = 0;
        Productos p = new Productos();
        string Categoria = "";
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal.op = 0;
            Close();
          
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias fc = new FrmCategorias();
            fc.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes fr = new FrmReportes();
            fr.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Botonera(false);
            groupBox1.Enabled = true;
            Id = 0;
            

        }
        public void Botonera(bool valor)
        {
            btnModificar.Enabled = valor;
            btnNuevo.Enabled = valor;
            btnReportes.Enabled = valor;
            btnCategoria.Enabled = valor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Botonera(true);
            groupBox1.Enabled = false;
           
            Limpiar();
        }
        public void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStockMinimo.Clear();

        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            LlenarData("");
            LlenarCombo();
        }
        public void LlenarData(string nombre)
        {
            try
            {
                dgvInventario.DataSource = mp.ConsultarProductos(nombre).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar los datos");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarData(txtBuscar.Text);
        }
        public void LlenarCombo()
        {
            cmbCategoria.DataSource = mp.LlenarComboCategoria().Tables[0];
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Productos pr = new Productos();
                pr.Nombre = txtNombre.Text;
                pr.Descripcion = txtDescripcion.Text;
                pr.Precio = double.Parse(txtPrecio.Text);
                pr.Estatus = cmbEstatus.Text;
                pr.FkIdCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                pr.Cantidad = double.Parse(txtCantidad.Text);
                pr.StockMinimo = double.Parse(txtStockMinimo.Text);
                if (Id==0)
                {
                    
                    if (mp.AgregarProductos(pr))
                    {
                        Limpiar();
                        LlenarData("");
                        Botonera(true);
                        groupBox1.Enabled = false;
                        MessageBox.Show("Dato Agregado Correctamente");

                    }
                    else
                        MessageBox.Show("Error al guardar");
                    

                }
                else if(Id >0)
                {
                    pr.IdProducto = Id;
                    if(mp.ModificarProductos(pr))
                    {
                        Limpiar();
                        LlenarData("");
                        Botonera(true);
                        groupBox1.Enabled = false;
                        MessageBox.Show("Dato modificado correctamente");
                    }
                    else
                        MessageBox.Show("Error al modificar los datos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar datos");
            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            p.IdProducto = int.Parse(dgvInventario.Rows[fila].Cells[0].Value.ToString());
            p.Nombre = dgvInventario.Rows[fila].Cells[1].Value.ToString();
            p.Descripcion = dgvInventario.Rows[fila].Cells[2].Value.ToString();
            p.Cantidad = double.Parse(dgvInventario.Rows[fila].Cells[3].Value.ToString());
            p.Precio = double.Parse(dgvInventario.Rows[fila].Cells[4].Value.ToString());
            Categoria = dgvInventario.Rows[fila].Cells[5].Value.ToString();
            p.Estatus = dgvInventario.Rows[fila].Cells[6].Value.ToString();
            p.StockMinimo = double.Parse(dgvInventario.Rows[fila].Cells[0].Value.ToString());

            Id = p.IdProducto;
            
        }
        public void LlenarDatos(string categoria)
        {
            try
            {
                txtID.Text = p.IdProducto.ToString();
                txtNombre.Text = p.Nombre;
                txtDescripcion.Text = p.Descripcion;
                txtCantidad.Text = p.Cantidad.ToString();
                txtPrecio.Text = p.Precio.ToString();
                txtStockMinimo.Text = p.StockMinimo.ToString();
                int indexc = cmbCategoria.FindString(categoria);
                cmbCategoria.SelectedIndex = indexc;
                int indexe = cmbEstatus.FindString(p.Estatus);
                cmbEstatus.SelectedIndex = indexe;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al selecionar el dato");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                Botonera(false);
                groupBox1.Enabled = true;
                LlenarDatos(Categoria);

            }
            else
                MessageBox.Show("Por Favor Seleccione un dato para modificar");
        }
    }
}
