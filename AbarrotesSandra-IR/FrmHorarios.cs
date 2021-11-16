using Entidades;
using Manejadores;
using System;
using System.Windows.Forms;

namespace AbarrotesSandra_IR
{
    public partial class FrmHorarios : Form
    {
        ManejadorHorarios mh = new ManejadorHorarios();
        EntidadHorarios eh = new EntidadHorarios(0, "", "", "", "", "");
        int fila = 0;
        string r;
        int id = 0;

        public FrmHorarios()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal.op = 0;
            Close();
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            Actualizar();
            groupBox1.Enabled = false;
        }

        public void Actualizar()
        {
            try
            {
                dgvHorario.DataSource = mh.ConsultarHorarios(dtpBuscar.Text).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al mostrar los Horarios");
            }
        }

        public void GenerarDatos(int fila)
        {
            try
            {
                eh.ID = int.Parse(dgvHorario.Rows[fila].Cells[0].Value.ToString());
                eh.Nombre = dgvHorario.Rows[fila].Cells[1].Value.ToString();
                eh.ApellidoP = dgvHorario.Rows[fila].Cells[2].Value.ToString();
                eh.ApellidoM = dgvHorario.Rows[fila].Cells[3].Value.ToString();
                eh.Fecha = dgvHorario.Rows[fila].Cells[4].Value.ToString();
                eh.Turno = dgvHorario.Rows[fila].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar entidad.");
            }
        }

        public void LimpiarCajas()
        {
            txtID.Clear();
            txtEmpleado.Clear();
            dtpFecha.Value = DateTime.Now.Date;
        }

        private void dtpBuscar_ValueChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id = eh.ID;
            if (id > 0)
            {
                groupBox1.Enabled = true;

                txtID.Text = eh.ID.ToString();
                txtEmpleado.Text = eh.Nombre + " " + eh.ApellidoP + " " + eh.ApellidoM;
                dtpFecha.Text = eh.Fecha;
                cmbTurno.SelectedIndex = cmbTurno.FindString(eh.Turno);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder modificar.", "Error al modificar.");
            }
        }

        private void dgvHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            GenerarDatos(fila);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mh.ValidarEmpleado(txtEmpleado).Equals(""))
            {
                string nombre, apellidop, apellidom;
                string[] separar = txtEmpleado.Text.Split(' ');
                nombre = separar[0];
                apellidop = separar[1];
                apellidom = separar[2];

                if (id > 0)
                {
                    string m = mh.ModificarHorarios(new EntidadHorarios(int.Parse(txtID.Text), nombre, apellidop, apellidom, dtpFecha.Text, cmbTurno.Text));
                    MessageBox.Show(m);
                    Actualizar();
                    LimpiarCajas();
                    groupBox1.Enabled = false;
                    id = 0;
                }
                else
                {
                    string m = mh.GuardarHorarios(new EntidadHorarios(0, nombre, apellidop, apellidom, dtpFecha.Text, cmbTurno.Text));
                    MessageBox.Show(m);
                    Actualizar();
                    LimpiarCajas();
                    groupBox1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(mh.ValidarEmpleado(txtEmpleado), "Error!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            groupBox1.Enabled = false;
            id = 0;
        }
    }
}
