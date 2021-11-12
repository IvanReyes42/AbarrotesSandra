using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace AbarrotesSandra_IR
{
    public partial class FrmCompras : Form
    {
        ManejadorCompras mc = new ManejadorCompras();
        Compras c = new Compras();
        int Id = 0;
        double cantidadactual = 0.0;
        string producto, proveedor;
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal.op = 0;
            Close();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            LlenarData("", "");
            LlenarComboProductos();
            LlenarComboProveedor();
        }
        public void LlenarData(string nombre, string fecha)
        {
            try
            {
                dvgCompras.DataSource = mc.ConsultarCompras(nombre, fecha).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los campos");
            }
        }

        private void txtFechaBusqueda_ValueChanged(object sender, EventArgs e)
        {
            LlenarData(txtBusqueda.Text, txtFechaBusqueda.Text);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarData(txtBusqueda.Text, txtFechaBusqueda.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Botonera(false);
            Limpiar();
            Id = 0;
        }
        public void Botonera(bool valor)
        {
            btnNuevo.Enabled = valor;
            btnModificar.Enabled = valor;
            GrupoCompra.Enabled = !valor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Botonera(true);
            Limpiar();
        }
        public void Limpiar()
        {
            txtId.Clear();
            txtFecha.Value = DateTime.Now;
            txtCantidad.Clear();
            txtTotal.Clear();
        }
        public void LlenarComboProductos()
        {
            cmbProductos.DataSource = mc.LlenarComboProductos().Tables[0];
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Codigo";
        }
        public void LlenarComboProveedor()
        {
            cmbProveedores.DataSource = mc.LlenarComboProveedor().Tables[0];
            cmbProveedores.DisplayMember = "RazonSocial";
            cmbProveedores.ValueMember = "FkIdUser";
        }

        private void dvgCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = e.RowIndex;
                c.IdCompras = int.Parse(dvgCompras.Rows[fila].Cells[0].Value.ToString());
                c.Fecha = dvgCompras.Rows[fila].Cells[1].Value.ToString();
                producto = dvgCompras.Rows[fila].Cells[2].Value.ToString();
                proveedor = dvgCompras.Rows[fila].Cells[3].Value.ToString();
                c.Cantidad = double.Parse(dvgCompras.Rows[fila].Cells[4].Value.ToString());
                c.Total = double.Parse(dvgCompras.Rows[fila].Cells[5].Value.ToString());
                cantidadactual = c.Cantidad;
                Id = c.IdCompras;
                LlenarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el dato");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Compras cp = new Compras();
                
                cp.Fecha = txtFecha.Text;
                cp.FkIdInventario = int.Parse(cmbProductos.SelectedValue.ToString());
                cp.FkIdProveedor = int.Parse(cmbProveedores.SelectedValue.ToString());
                cp.Cantidad = double.Parse(txtCantidad.Text);
                cp.Total = double.Parse(txtTotal.Text);
                if(Id==0)
                {
                    if (mc.GuardarComprar(cp))
                    {
                        MessageBox.Show("Datos guardados correctamente");
                        Limpiar();
                        Botonera(true);
                        LlenarData("", "");
                    }
                    else
                        MessageBox.Show("Error al guardar datos");
                }
                else if (Id>0)
                {
                    
                    cp.IdCompras = int.Parse(txtId.Text);
                    if(mc.ModificarCompra(cp,cantidadactual))
                    {
                        MessageBox.Show("Datos modificados correctamente");
                        Limpiar();
                        Botonera(true);
                        LlenarData("", "");
                    }
                    else
                        MessageBox.Show("Error al modificar los datos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
                Botonera(false);
            else
                MessageBox.Show("Por Favor Seleccione un dato para modificar");
        }

        private void txtBusqueda_DoubleClick(object sender, EventArgs e)
        {
            LlenarData("", "");
        }

        public void LlenarDatos()
        {
            txtId.Text = c.IdCompras.ToString();
            txtFecha.Value = DateTime.Parse(c.Fecha);
            txtCantidad.Text = c.Cantidad.ToString();
            txtTotal.Text = c.Total.ToString();
            int indexprod = cmbProductos.FindString(producto);
            cmbProductos.SelectedIndex = indexprod;

            int indexprov = cmbProveedores.FindString(proveedor);
            cmbProveedores.SelectedIndex = indexprov;

        }
    }
}
