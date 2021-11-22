using System;
using System.Drawing;
using System.Windows.Forms;

namespace AbarrotesSandra_IR
{
    public partial class FrmMenuPrincipal : Form
    {
       public static int op = 0;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.LightSlateGray;
                }
            }
        }

     

        private void pbSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion i = new FrmInicioSesion();
            i.Show();
            Close();
        }

        private void tsbVentas_Click(object sender, EventArgs e)
        {
            DesmarcarBotones();
            tsbVentas.Checked = true;
            if (op == 0)
            {
                op++;
                FrmPuntoDeVenta pv = new FrmPuntoDeVenta();
                pv.MdiParent = this;
                pv.Show();
            }
        }

        private void tsbCompras_Click(object sender, EventArgs e)
        {
            DesmarcarBotones();
            tsbCompras.Checked = true;
            if (op == 0)
            {
                op++;
                FrmCompras co = new FrmCompras();
                co.MdiParent = this;
                co.Show();
            }
        }

        private void tsbProveedores_Click(object sender, EventArgs e)
        {
            DesmarcarBotones();
            tsbProveedores.Checked = true;
            if (op == 0)
            {
                op++;
                FrmProveedores p = new FrmProveedores();
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tsbInventario_Click(object sender, EventArgs e)
        {
            DesmarcarBotones();
            tsbInventario.Checked = true;
            if (op == 0)
            {
                op++;
                FrmInventario i = new FrmInventario();
                i.MdiParent = this;
                i.Show();
            }
        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            DesmarcarBotones();
            tsbUsuarios.Checked = true;
            if (op == 0)
            {
                op++;
                FrmUsuarios u = new FrmUsuarios();
                u.MdiParent = this;
                u.Show();
            }
        }

        private void tsbHorarios_Click(object sender, EventArgs e)
        {
            DesmarcarBotones();
            tsbHorarios.Checked = true;
            if (op == 0)
            {
                op++;
                FrmHorarios h = new FrmHorarios();
                h.MdiParent = this;
                h.Show();
            }
        }

        private void tsbReportes_Click(object sender, EventArgs e)
        {
            DesmarcarBotones();
            tsbReportes.Checked = true;
            
            if (op == 0)
            {
                op++;
                FrmReportes r = new FrmReportes();
                r.MdiParent = this;
                r.Show();
            }
        }

        private void DesmarcarBotones()
        {
            tsbVentas.Checked = false;
            tsbCompras.Checked = false;
            tsbProveedores.Checked = false;
            tsbInventario.Checked = false;
            tsbUsuarios.Checked = false;
            tsbHorarios.Checked = false;
            tsbReportes.Checked = false;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.WhiteSmoke;
                }
            }
        }
    }
}
