using Entidades;
using Manejadores;
using System;
using System.Windows.Forms;

namespace AbarrotesSandra_IR
{
    public partial class FrmProveedores : Form
    {
        ManejadorProveedores mp = new ManejadorProveedores();
        EntidadProveedores ep = new EntidadProveedores(0, "", "", "", "", "", "", "");
        int fila = 0;
        string r;
        int id = 0;

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal.op = 0;
            Close();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Actualizar();
            groupBox1.Enabled = false;
        }

        public void Actualizar()
        {
            try
            {
                dgvProveedores.DataSource = mp.ConsultarProveedores(txtBuscar.Text).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al mostrar datos de los proveedores");
            }
        }

        public void GenerarDatos(int fila)
        {
            try
            {
                ep.ID = int.Parse(dgvProveedores.Rows[fila].Cells[0].Value.ToString());
                ep.Nombre = dgvProveedores.Rows[fila].Cells[1].Value.ToString();
                ep.ApellidoP = dgvProveedores.Rows[fila].Cells[2].Value.ToString();
                ep.ApellidoM = dgvProveedores.Rows[fila].Cells[3].Value.ToString();
                ep.Telefono = dgvProveedores.Rows[fila].Cells[4].Value.ToString();
                ep.RFC = dgvProveedores.Rows[fila].Cells[5].Value.ToString();
                ep.RazonSocial = dgvProveedores.Rows[fila].Cells[6].Value.ToString();
                ep.Estatus = dgvProveedores.Rows[fila].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar la entidad.");
            }
        }

        public void limpiarCajas()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtTelefono.Clear();
            txtRFC.Clear();
            txtRazonSocial.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id = ep.ID;
            if (id > 0)
            {
                groupBox1.Enabled = true;

                txtId.Text = ep.ID.ToString();
                txtNombre.Text = ep.Nombre;
                txtAP.Text = ep.ApellidoP;
                txtAM.Text = ep.ApellidoM;
                txtTelefono.Text = ep.Telefono;
                txtRFC.Text = ep.RFC;
                txtRazonSocial.Text = ep.RazonSocial;
                int indexestatus = cmbEstatus.FindString(ep.Estatus);
                cmbEstatus.SelectedIndex = indexestatus;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder modificar.", "Error al modificar.");
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            GenerarDatos(fila);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                string m = mp.ModificarProveedores(new EntidadProveedores(int.Parse(txtId.Text), txtNombre.Text, txtAP.Text, txtAM.Text, txtTelefono.Text,
                    txtRFC.Text, txtRazonSocial.Text, cmbEstatus.Text));
                MessageBox.Show(m);
                Actualizar();
                limpiarCajas();
                groupBox1.Enabled = false;
                id = 0;
            }
            else
            {
                string m = mp.GuardarProveedores(new EntidadProveedores(0, txtNombre.Text, txtAP.Text, txtAM.Text, txtTelefono.Text,
                txtRFC.Text, txtRazonSocial.Text, cmbEstatus.Text));
                MessageBox.Show(m);
                Actualizar();
                limpiarCajas();
                groupBox1.Enabled = false;
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
